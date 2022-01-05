// Copyright 2022 Google LLC
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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Iot.V1
{
    /// <summary>Settings for <see cref="DeviceManagerClient"/> instances.</summary>
    public sealed partial class DeviceManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeviceManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeviceManagerSettings"/>.</returns>
        public static DeviceManagerSettings GetDefault() => new DeviceManagerSettings();

        /// <summary>Constructs a new <see cref="DeviceManagerSettings"/> object with default settings.</summary>
        public DeviceManagerSettings()
        {
        }

        private DeviceManagerSettings(DeviceManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDeviceRegistrySettings = existing.CreateDeviceRegistrySettings;
            GetDeviceRegistrySettings = existing.GetDeviceRegistrySettings;
            UpdateDeviceRegistrySettings = existing.UpdateDeviceRegistrySettings;
            DeleteDeviceRegistrySettings = existing.DeleteDeviceRegistrySettings;
            ListDeviceRegistriesSettings = existing.ListDeviceRegistriesSettings;
            CreateDeviceSettings = existing.CreateDeviceSettings;
            GetDeviceSettings = existing.GetDeviceSettings;
            UpdateDeviceSettings = existing.UpdateDeviceSettings;
            DeleteDeviceSettings = existing.DeleteDeviceSettings;
            ListDevicesSettings = existing.ListDevicesSettings;
            ModifyCloudToDeviceConfigSettings = existing.ModifyCloudToDeviceConfigSettings;
            ListDeviceConfigVersionsSettings = existing.ListDeviceConfigVersionsSettings;
            ListDeviceStatesSettings = existing.ListDeviceStatesSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            SendCommandToDeviceSettings = existing.SendCommandToDeviceSettings;
            BindDeviceToGatewaySettings = existing.BindDeviceToGatewaySettings;
            UnbindDeviceFromGatewaySettings = existing.UnbindDeviceFromGatewaySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeviceManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.CreateDeviceRegistry</c> and <c>DeviceManagerClient.CreateDeviceRegistryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeviceRegistrySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.GetDeviceRegistry</c> and <c>DeviceManagerClient.GetDeviceRegistryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeviceRegistrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.UpdateDeviceRegistry</c> and <c>DeviceManagerClient.UpdateDeviceRegistryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeviceRegistrySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.DeleteDeviceRegistry</c> and <c>DeviceManagerClient.DeleteDeviceRegistryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeviceRegistrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.ListDeviceRegistries</c> and <c>DeviceManagerClient.ListDeviceRegistriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceRegistriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.CreateDevice</c> and <c>DeviceManagerClient.CreateDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeviceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.GetDevice</c> and <c>DeviceManagerClient.GetDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeviceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.UpdateDevice</c> and <c>DeviceManagerClient.UpdateDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeviceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.DeleteDevice</c> and <c>DeviceManagerClient.DeleteDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeviceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.ListDevices</c> and <c>DeviceManagerClient.ListDevicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDevicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.ModifyCloudToDeviceConfig</c> and
        /// <c>DeviceManagerClient.ModifyCloudToDeviceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ModifyCloudToDeviceConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.ListDeviceConfigVersions</c> and <c>DeviceManagerClient.ListDeviceConfigVersionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceConfigVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.ListDeviceStates</c> and <c>DeviceManagerClient.ListDeviceStatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceStatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.SetIamPolicy</c> and <c>DeviceManagerClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.GetIamPolicy</c> and <c>DeviceManagerClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.TestIamPermissions</c> and <c>DeviceManagerClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.SendCommandToDevice</c> and <c>DeviceManagerClient.SendCommandToDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SendCommandToDeviceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.BindDeviceToGateway</c> and <c>DeviceManagerClient.BindDeviceToGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BindDeviceToGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManagerClient.UnbindDeviceFromGateway</c> and <c>DeviceManagerClient.UnbindDeviceFromGatewayAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UnbindDeviceFromGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeviceManagerSettings"/> object.</returns>
        public DeviceManagerSettings Clone() => new DeviceManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeviceManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DeviceManagerClientBuilder : gaxgrpc::ClientBuilderBase<DeviceManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeviceManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeviceManagerClientBuilder()
        {
            UseJwtAccessWithScopes = DeviceManagerClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref DeviceManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeviceManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeviceManagerClient Build()
        {
            DeviceManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeviceManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeviceManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeviceManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeviceManagerClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DeviceManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeviceManagerClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DeviceManagerClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DeviceManagerClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeviceManagerClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DeviceManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Internet of Things (IoT) service. Securely connect and manage IoT devices.
    /// </remarks>
    public abstract partial class DeviceManagerClient
    {
        /// <summary>
        /// The default endpoint for the DeviceManager service, which is a host of "cloudiot.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudiot.googleapis.com:443";

        /// <summary>The default DeviceManager scopes.</summary>
        /// <remarks>
        /// The default DeviceManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloudiot</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloudiot",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DeviceManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeviceManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeviceManagerClient"/>.</returns>
        public static stt::Task<DeviceManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeviceManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeviceManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeviceManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeviceManagerClient"/>.</returns>
        public static DeviceManagerClient Create() => new DeviceManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeviceManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeviceManagerSettings"/>.</param>
        /// <returns>The created <see cref="DeviceManagerClient"/>.</returns>
        internal static DeviceManagerClient Create(grpccore::CallInvoker callInvoker, DeviceManagerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeviceManager.DeviceManagerClient grpcClient = new DeviceManager.DeviceManagerClient(callInvoker);
            return new DeviceManagerClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DeviceManager client</summary>
        public virtual DeviceManager.DeviceManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry CreateDeviceRegistry(CreateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(CreateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(CreateDeviceRegistryRequest request, st::CancellationToken cancellationToken) =>
            CreateDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region where this device registry must be created.
        /// For example, `projects/example-project/locations/us-central1`.
        /// </param>
        /// <param name="deviceRegistry">
        /// Required. The device registry. The field `name` must be empty. The server will
        /// generate that field from the device registry `id` provided and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry CreateDeviceRegistry(string parent, DeviceRegistry deviceRegistry, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceRegistry(new CreateDeviceRegistryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeviceRegistry = gax::GaxPreconditions.CheckNotNull(deviceRegistry, nameof(deviceRegistry)),
            }, callSettings);

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region where this device registry must be created.
        /// For example, `projects/example-project/locations/us-central1`.
        /// </param>
        /// <param name="deviceRegistry">
        /// Required. The device registry. The field `name` must be empty. The server will
        /// generate that field from the device registry `id` provided and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(string parent, DeviceRegistry deviceRegistry, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceRegistryAsync(new CreateDeviceRegistryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeviceRegistry = gax::GaxPreconditions.CheckNotNull(deviceRegistry, nameof(deviceRegistry)),
            }, callSettings);

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region where this device registry must be created.
        /// For example, `projects/example-project/locations/us-central1`.
        /// </param>
        /// <param name="deviceRegistry">
        /// Required. The device registry. The field `name` must be empty. The server will
        /// generate that field from the device registry `id` provided and the
        /// `parent` field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(string parent, DeviceRegistry deviceRegistry, st::CancellationToken cancellationToken) =>
            CreateDeviceRegistryAsync(parent, deviceRegistry, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region where this device registry must be created.
        /// For example, `projects/example-project/locations/us-central1`.
        /// </param>
        /// <param name="deviceRegistry">
        /// Required. The device registry. The field `name` must be empty. The server will
        /// generate that field from the device registry `id` provided and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry CreateDeviceRegistry(gagr::LocationName parent, DeviceRegistry deviceRegistry, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceRegistry(new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeviceRegistry = gax::GaxPreconditions.CheckNotNull(deviceRegistry, nameof(deviceRegistry)),
            }, callSettings);

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region where this device registry must be created.
        /// For example, `projects/example-project/locations/us-central1`.
        /// </param>
        /// <param name="deviceRegistry">
        /// Required. The device registry. The field `name` must be empty. The server will
        /// generate that field from the device registry `id` provided and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(gagr::LocationName parent, DeviceRegistry deviceRegistry, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceRegistryAsync(new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeviceRegistry = gax::GaxPreconditions.CheckNotNull(deviceRegistry, nameof(deviceRegistry)),
            }, callSettings);

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region where this device registry must be created.
        /// For example, `projects/example-project/locations/us-central1`.
        /// </param>
        /// <param name="deviceRegistry">
        /// Required. The device registry. The field `name` must be empty. The server will
        /// generate that field from the device registry `id` provided and the
        /// `parent` field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(gagr::LocationName parent, DeviceRegistry deviceRegistry, st::CancellationToken cancellationToken) =>
            CreateDeviceRegistryAsync(parent, deviceRegistry, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry GetDeviceRegistry(GetDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> GetDeviceRegistryAsync(GetDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> GetDeviceRegistryAsync(GetDeviceRegistryRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry GetDeviceRegistry(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceRegistry(new GetDeviceRegistryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> GetDeviceRegistryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceRegistryAsync(new GetDeviceRegistryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> GetDeviceRegistryAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeviceRegistryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry GetDeviceRegistry(RegistryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceRegistry(new GetDeviceRegistryRequest
            {
                RegistryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> GetDeviceRegistryAsync(RegistryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceRegistryAsync(new GetDeviceRegistryRequest
            {
                RegistryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> GetDeviceRegistryAsync(RegistryName name, st::CancellationToken cancellationToken) =>
            GetDeviceRegistryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry UpdateDeviceRegistry(UpdateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> UpdateDeviceRegistryAsync(UpdateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> UpdateDeviceRegistryAsync(UpdateDeviceRegistryRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="deviceRegistry">
        /// Required. The new values for the device registry. The `id` field must be empty, and
        /// the `name` field must indicate the path of the resource. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Only updates the `device_registry` fields indicated by this mask.
        /// The field mask must not be empty, and it must not contain fields that
        /// are immutable or only set by the server.
        /// Mutable top-level fields: `event_notification_config`, `http_config`,
        /// `mqtt_config`, and `state_notification_config`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceRegistry UpdateDeviceRegistry(DeviceRegistry deviceRegistry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeviceRegistry(new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = gax::GaxPreconditions.CheckNotNull(deviceRegistry, nameof(deviceRegistry)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="deviceRegistry">
        /// Required. The new values for the device registry. The `id` field must be empty, and
        /// the `name` field must indicate the path of the resource. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Only updates the `device_registry` fields indicated by this mask.
        /// The field mask must not be empty, and it must not contain fields that
        /// are immutable or only set by the server.
        /// Mutable top-level fields: `event_notification_config`, `http_config`,
        /// `mqtt_config`, and `state_notification_config`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> UpdateDeviceRegistryAsync(DeviceRegistry deviceRegistry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeviceRegistryAsync(new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = gax::GaxPreconditions.CheckNotNull(deviceRegistry, nameof(deviceRegistry)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="deviceRegistry">
        /// Required. The new values for the device registry. The `id` field must be empty, and
        /// the `name` field must indicate the path of the resource. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Only updates the `device_registry` fields indicated by this mask.
        /// The field mask must not be empty, and it must not contain fields that
        /// are immutable or only set by the server.
        /// Mutable top-level fields: `event_notification_config`, `http_config`,
        /// `mqtt_config`, and `state_notification_config`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceRegistry> UpdateDeviceRegistryAsync(DeviceRegistry deviceRegistry, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeviceRegistryAsync(deviceRegistry, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeviceRegistry(DeleteDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceRegistryAsync(DeleteDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceRegistryAsync(DeleteDeviceRegistryRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeviceRegistryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeviceRegistry(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeviceRegistry(new DeleteDeviceRegistryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceRegistryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeviceRegistryAsync(new DeleteDeviceRegistryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceRegistryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeviceRegistryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeviceRegistry(RegistryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeviceRegistry(new DeleteDeviceRegistryRequest
            {
                RegistryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceRegistryAsync(RegistryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeviceRegistryAsync(new DeleteDeviceRegistryRequest
            {
                RegistryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceRegistryAsync(RegistryName name, st::CancellationToken cancellationToken) =>
            DeleteDeviceRegistryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistries(ListDeviceRegistriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistriesAsync(ListDeviceRegistriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region path. For example,
        /// `projects/example-project/locations/us-central1`.
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
        /// <returns>A pageable sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceRegistries(new ListDeviceRegistriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region path. For example,
        /// `projects/example-project/locations/us-central1`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceRegistriesAsync(new ListDeviceRegistriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region path. For example,
        /// `projects/example-project/locations/us-central1`.
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
        /// <returns>A pageable sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistries(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceRegistries(new ListDeviceRegistriesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and cloud region path. For example,
        /// `projects/example-project/locations/us-central1`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistriesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceRegistriesAsync(new ListDeviceRegistriesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device CreateDevice(CreateDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> CreateDeviceAsync(CreateDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> CreateDeviceAsync(CreateDeviceRequest request, st::CancellationToken cancellationToken) =>
            CreateDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the device registry where this device should be created.
        /// For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="device">
        /// Required. The device registration details. The field `name` must be empty. The server
        /// generates `name` from the device registry `id` and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device CreateDevice(string parent, Device device, gaxgrpc::CallSettings callSettings = null) =>
            CreateDevice(new CreateDeviceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Device = gax::GaxPreconditions.CheckNotNull(device, nameof(device)),
            }, callSettings);

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the device registry where this device should be created.
        /// For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="device">
        /// Required. The device registration details. The field `name` must be empty. The server
        /// generates `name` from the device registry `id` and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> CreateDeviceAsync(string parent, Device device, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceAsync(new CreateDeviceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Device = gax::GaxPreconditions.CheckNotNull(device, nameof(device)),
            }, callSettings);

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the device registry where this device should be created.
        /// For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="device">
        /// Required. The device registration details. The field `name` must be empty. The server
        /// generates `name` from the device registry `id` and the
        /// `parent` field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> CreateDeviceAsync(string parent, Device device, st::CancellationToken cancellationToken) =>
            CreateDeviceAsync(parent, device, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the device registry where this device should be created.
        /// For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="device">
        /// Required. The device registration details. The field `name` must be empty. The server
        /// generates `name` from the device registry `id` and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device CreateDevice(RegistryName parent, Device device, gaxgrpc::CallSettings callSettings = null) =>
            CreateDevice(new CreateDeviceRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Device = gax::GaxPreconditions.CheckNotNull(device, nameof(device)),
            }, callSettings);

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the device registry where this device should be created.
        /// For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="device">
        /// Required. The device registration details. The field `name` must be empty. The server
        /// generates `name` from the device registry `id` and the
        /// `parent` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> CreateDeviceAsync(RegistryName parent, Device device, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceAsync(new CreateDeviceRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Device = gax::GaxPreconditions.CheckNotNull(device, nameof(device)),
            }, callSettings);

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the device registry where this device should be created.
        /// For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="device">
        /// Required. The device registration details. The field `name` must be empty. The server
        /// generates `name` from the device registry `id` and the
        /// `parent` field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> CreateDeviceAsync(RegistryName parent, Device device, st::CancellationToken cancellationToken) =>
            CreateDeviceAsync(parent, device, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device GetDevice(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(GetDeviceRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device GetDevice(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDevice(new GetDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceAsync(new GetDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeviceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device GetDevice(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDevice(new GetDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceAsync(new GetDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(DeviceName name, st::CancellationToken cancellationToken) =>
            GetDeviceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device UpdateDevice(UpdateDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> UpdateDeviceAsync(UpdateDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> UpdateDeviceAsync(UpdateDeviceRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="device">
        /// Required. The new values for the device. The `id` and `num_id` fields must
        /// be empty, and the field `name` must specify the name path. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0`or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Only updates the `device` fields indicated by this mask.
        /// The field mask must not be empty, and it must not contain fields that
        /// are immutable or only set by the server.
        /// Mutable top-level fields: `credentials`, `blocked`, and `metadata`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device UpdateDevice(Device device, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDevice(new UpdateDeviceRequest
            {
                Device = gax::GaxPreconditions.CheckNotNull(device, nameof(device)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="device">
        /// Required. The new values for the device. The `id` and `num_id` fields must
        /// be empty, and the field `name` must specify the name path. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0`or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Only updates the `device` fields indicated by this mask.
        /// The field mask must not be empty, and it must not contain fields that
        /// are immutable or only set by the server.
        /// Mutable top-level fields: `credentials`, `blocked`, and `metadata`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> UpdateDeviceAsync(Device device, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeviceAsync(new UpdateDeviceRequest
            {
                Device = gax::GaxPreconditions.CheckNotNull(device, nameof(device)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="device">
        /// Required. The new values for the device. The `id` and `num_id` fields must
        /// be empty, and the field `name` must specify the name path. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0`or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Only updates the `device` fields indicated by this mask.
        /// The field mask must not be empty, and it must not contain fields that
        /// are immutable or only set by the server.
        /// Mutable top-level fields: `credentials`, `blocked`, and `metadata`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> UpdateDeviceAsync(Device device, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeviceAsync(device, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDevice(DeleteDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceAsync(DeleteDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceAsync(DeleteDeviceRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDevice(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDevice(new DeleteDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeviceAsync(new DeleteDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeviceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDevice(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDevice(new DeleteDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceAsync(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeviceAsync(new DeleteDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeviceAsync(DeviceName name, st::CancellationToken cancellationToken) =>
            DeleteDeviceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDevicesResponse, Device> ListDevices(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDevicesResponse, Device> ListDevicesAsync(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The device registry path. Required. For example,
        /// `projects/my-project/locations/us-central1/registries/my-registry`.
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
        /// <returns>A pageable sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDevicesResponse, Device> ListDevices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDevices(new ListDevicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The device registry path. Required. For example,
        /// `projects/my-project/locations/us-central1/registries/my-registry`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDevicesResponse, Device> ListDevicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDevicesAsync(new ListDevicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The device registry path. Required. For example,
        /// `projects/my-project/locations/us-central1/registries/my-registry`.
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
        /// <returns>A pageable sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDevicesResponse, Device> ListDevices(RegistryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDevices(new ListDevicesRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="parent">
        /// Required. The device registry path. Required. For example,
        /// `projects/my-project/locations/us-central1/registries/my-registry`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDevicesResponse, Device> ListDevicesAsync(RegistryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDevicesAsync(new ListDevicesRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceConfig ModifyCloudToDeviceConfig(ModifyCloudToDeviceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(ModifyCloudToDeviceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(ModifyCloudToDeviceConfigRequest request, st::CancellationToken cancellationToken) =>
            ModifyCloudToDeviceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The configuration data for the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceConfig ModifyCloudToDeviceConfig(string name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            ModifyCloudToDeviceConfig(new ModifyCloudToDeviceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The configuration data for the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(string name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            ModifyCloudToDeviceConfigAsync(new ModifyCloudToDeviceConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The configuration data for the device.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(string name, proto::ByteString binaryData, st::CancellationToken cancellationToken) =>
            ModifyCloudToDeviceConfigAsync(name, binaryData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The configuration data for the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceConfig ModifyCloudToDeviceConfig(DeviceName name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            ModifyCloudToDeviceConfig(new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The configuration data for the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(DeviceName name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            ModifyCloudToDeviceConfigAsync(new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The configuration data for the device.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(DeviceName name, proto::ByteString binaryData, st::CancellationToken cancellationToken) =>
            ModifyCloudToDeviceConfigAsync(name, binaryData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDeviceConfigVersionsResponse ListDeviceConfigVersions(ListDeviceConfigVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(ListDeviceConfigVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(ListDeviceConfigVersionsRequest request, st::CancellationToken cancellationToken) =>
            ListDeviceConfigVersionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDeviceConfigVersionsResponse ListDeviceConfigVersions(string name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceConfigVersions(new ListDeviceConfigVersionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceConfigVersionsAsync(new ListDeviceConfigVersionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(string name, st::CancellationToken cancellationToken) =>
            ListDeviceConfigVersionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDeviceConfigVersionsResponse ListDeviceConfigVersions(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceConfigVersions(new ListDeviceConfigVersionsRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceConfigVersionsAsync(new ListDeviceConfigVersionsRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(DeviceName name, st::CancellationToken cancellationToken) =>
            ListDeviceConfigVersionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDeviceStatesResponse ListDeviceStates(ListDeviceStatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(ListDeviceStatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(ListDeviceStatesRequest request, st::CancellationToken cancellationToken) =>
            ListDeviceStatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDeviceStatesResponse ListDeviceStates(string name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceStates(new ListDeviceStatesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceStatesAsync(new ListDeviceStatesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(string name, st::CancellationToken cancellationToken) =>
            ListDeviceStatesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDeviceStatesResponse ListDeviceStates(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceStates(new ListDeviceStatesRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(DeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            ListDeviceStatesAsync(new ListDeviceStatesRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(DeviceName name, st::CancellationToken cancellationToken) =>
            ListDeviceStatesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendCommandToDeviceResponse SendCommandToDevice(SendCommandToDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(SendCommandToDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(SendCommandToDeviceRequest request, st::CancellationToken cancellationToken) =>
            SendCommandToDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendCommandToDeviceResponse SendCommandToDevice(string name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDevice(new SendCommandToDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(string name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDeviceAsync(new SendCommandToDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(string name, proto::ByteString binaryData, st::CancellationToken cancellationToken) =>
            SendCommandToDeviceAsync(name, binaryData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendCommandToDeviceResponse SendCommandToDevice(DeviceName name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDevice(new SendCommandToDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(DeviceName name, proto::ByteString binaryData, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDeviceAsync(new SendCommandToDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(DeviceName name, proto::ByteString binaryData, st::CancellationToken cancellationToken) =>
            SendCommandToDeviceAsync(name, binaryData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="subfolder">
        /// Optional subfolder for the command. If empty, the command will be delivered
        /// to the /devices/{device-id}/commands topic, otherwise it will be delivered
        /// to the /devices/{device-id}/commands/{subfolder} topic. Multi-level
        /// subfolders are allowed. This field must not have more than 256 characters,
        /// and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendCommandToDeviceResponse SendCommandToDevice(string name, proto::ByteString binaryData, string subfolder, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDevice(new SendCommandToDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
                Subfolder = subfolder ?? "",
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="subfolder">
        /// Optional subfolder for the command. If empty, the command will be delivered
        /// to the /devices/{device-id}/commands topic, otherwise it will be delivered
        /// to the /devices/{device-id}/commands/{subfolder} topic. Multi-level
        /// subfolders are allowed. This field must not have more than 256 characters,
        /// and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(string name, proto::ByteString binaryData, string subfolder, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDeviceAsync(new SendCommandToDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
                Subfolder = subfolder ?? "",
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="subfolder">
        /// Optional subfolder for the command. If empty, the command will be delivered
        /// to the /devices/{device-id}/commands topic, otherwise it will be delivered
        /// to the /devices/{device-id}/commands/{subfolder} topic. Multi-level
        /// subfolders are allowed. This field must not have more than 256 characters,
        /// and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(string name, proto::ByteString binaryData, string subfolder, st::CancellationToken cancellationToken) =>
            SendCommandToDeviceAsync(name, binaryData, subfolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="subfolder">
        /// Optional subfolder for the command. If empty, the command will be delivered
        /// to the /devices/{device-id}/commands topic, otherwise it will be delivered
        /// to the /devices/{device-id}/commands/{subfolder} topic. Multi-level
        /// subfolders are allowed. This field must not have more than 256 characters,
        /// and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendCommandToDeviceResponse SendCommandToDevice(DeviceName name, proto::ByteString binaryData, string subfolder, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDevice(new SendCommandToDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
                Subfolder = subfolder ?? "",
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="subfolder">
        /// Optional subfolder for the command. If empty, the command will be delivered
        /// to the /devices/{device-id}/commands topic, otherwise it will be delivered
        /// to the /devices/{device-id}/commands/{subfolder} topic. Multi-level
        /// subfolders are allowed. This field must not have more than 256 characters,
        /// and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(DeviceName name, proto::ByteString binaryData, string subfolder, gaxgrpc::CallSettings callSettings = null) =>
            SendCommandToDeviceAsync(new SendCommandToDeviceRequest
            {
                DeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BinaryData = gax::GaxPreconditions.CheckNotNull(binaryData, nameof(binaryData)),
                Subfolder = subfolder ?? "",
            }, callSettings);

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the device. For example,
        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
        /// </param>
        /// <param name="binaryData">
        /// Required. The command data to send to the device.
        /// </param>
        /// <param name="subfolder">
        /// Optional subfolder for the command. If empty, the command will be delivered
        /// to the /devices/{device-id}/commands topic, otherwise it will be delivered
        /// to the /devices/{device-id}/commands/{subfolder} topic. Multi-level
        /// subfolders are allowed. This field must not have more than 256 characters,
        /// and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(DeviceName name, proto::ByteString binaryData, string subfolder, st::CancellationToken cancellationToken) =>
            SendCommandToDeviceAsync(name, binaryData, subfolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BindDeviceToGatewayResponse BindDeviceToGateway(BindDeviceToGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(BindDeviceToGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(BindDeviceToGatewayRequest request, st::CancellationToken cancellationToken) =>
            BindDeviceToGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to associate with the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BindDeviceToGatewayResponse BindDeviceToGateway(string parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            BindDeviceToGateway(new BindDeviceToGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to associate with the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(string parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            BindDeviceToGatewayAsync(new BindDeviceToGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to associate with the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(string parent, string gatewayId, string deviceId, st::CancellationToken cancellationToken) =>
            BindDeviceToGatewayAsync(parent, gatewayId, deviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to associate with the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BindDeviceToGatewayResponse BindDeviceToGateway(RegistryName parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            BindDeviceToGateway(new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to associate with the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(RegistryName parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            BindDeviceToGatewayAsync(new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to associate with the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(RegistryName parent, string gatewayId, string deviceId, st::CancellationToken cancellationToken) =>
            BindDeviceToGatewayAsync(parent, gatewayId, deviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnbindDeviceFromGatewayResponse UnbindDeviceFromGateway(UnbindDeviceFromGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(UnbindDeviceFromGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(UnbindDeviceFromGatewayRequest request, st::CancellationToken cancellationToken) =>
            UnbindDeviceFromGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to disassociate from the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnbindDeviceFromGatewayResponse UnbindDeviceFromGateway(string parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            UnbindDeviceFromGateway(new UnbindDeviceFromGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to disassociate from the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(string parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            UnbindDeviceFromGatewayAsync(new UnbindDeviceFromGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to disassociate from the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(string parent, string gatewayId, string deviceId, st::CancellationToken cancellationToken) =>
            UnbindDeviceFromGatewayAsync(parent, gatewayId, deviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to disassociate from the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnbindDeviceFromGatewayResponse UnbindDeviceFromGateway(RegistryName parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            UnbindDeviceFromGateway(new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to disassociate from the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(RegistryName parent, string gatewayId, string deviceId, gaxgrpc::CallSettings callSettings = null) =>
            UnbindDeviceFromGatewayAsync(new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                DeviceId = gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)),
            }, callSettings);

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the registry. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </param>
        /// <param name="gatewayId">
        /// Required. The value of `gateway_id` can be either the device numeric ID or the
        /// user-defined device identifier.
        /// </param>
        /// <param name="deviceId">
        /// Required. The device to disassociate from the specified gateway. The value of
        /// `device_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(RegistryName parent, string gatewayId, string deviceId, st::CancellationToken cancellationToken) =>
            UnbindDeviceFromGatewayAsync(parent, gatewayId, deviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DeviceManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Internet of Things (IoT) service. Securely connect and manage IoT devices.
    /// </remarks>
    public sealed partial class DeviceManagerClientImpl : DeviceManagerClient
    {
        private readonly gaxgrpc::ApiCall<CreateDeviceRegistryRequest, DeviceRegistry> _callCreateDeviceRegistry;

        private readonly gaxgrpc::ApiCall<GetDeviceRegistryRequest, DeviceRegistry> _callGetDeviceRegistry;

        private readonly gaxgrpc::ApiCall<UpdateDeviceRegistryRequest, DeviceRegistry> _callUpdateDeviceRegistry;

        private readonly gaxgrpc::ApiCall<DeleteDeviceRegistryRequest, wkt::Empty> _callDeleteDeviceRegistry;

        private readonly gaxgrpc::ApiCall<ListDeviceRegistriesRequest, ListDeviceRegistriesResponse> _callListDeviceRegistries;

        private readonly gaxgrpc::ApiCall<CreateDeviceRequest, Device> _callCreateDevice;

        private readonly gaxgrpc::ApiCall<GetDeviceRequest, Device> _callGetDevice;

        private readonly gaxgrpc::ApiCall<UpdateDeviceRequest, Device> _callUpdateDevice;

        private readonly gaxgrpc::ApiCall<DeleteDeviceRequest, wkt::Empty> _callDeleteDevice;

        private readonly gaxgrpc::ApiCall<ListDevicesRequest, ListDevicesResponse> _callListDevices;

        private readonly gaxgrpc::ApiCall<ModifyCloudToDeviceConfigRequest, DeviceConfig> _callModifyCloudToDeviceConfig;

        private readonly gaxgrpc::ApiCall<ListDeviceConfigVersionsRequest, ListDeviceConfigVersionsResponse> _callListDeviceConfigVersions;

        private readonly gaxgrpc::ApiCall<ListDeviceStatesRequest, ListDeviceStatesResponse> _callListDeviceStates;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<SendCommandToDeviceRequest, SendCommandToDeviceResponse> _callSendCommandToDevice;

        private readonly gaxgrpc::ApiCall<BindDeviceToGatewayRequest, BindDeviceToGatewayResponse> _callBindDeviceToGateway;

        private readonly gaxgrpc::ApiCall<UnbindDeviceFromGatewayRequest, UnbindDeviceFromGatewayResponse> _callUnbindDeviceFromGateway;

        /// <summary>
        /// Constructs a client wrapper for the DeviceManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeviceManagerSettings"/> used within this client.</param>
        public DeviceManagerClientImpl(DeviceManager.DeviceManagerClient grpcClient, DeviceManagerSettings settings)
        {
            GrpcClient = grpcClient;
            DeviceManagerSettings effectiveSettings = settings ?? DeviceManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateDeviceRegistry = clientHelper.BuildApiCall<CreateDeviceRegistryRequest, DeviceRegistry>(grpcClient.CreateDeviceRegistryAsync, grpcClient.CreateDeviceRegistry, effectiveSettings.CreateDeviceRegistrySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeviceRegistry);
            Modify_CreateDeviceRegistryApiCall(ref _callCreateDeviceRegistry);
            _callGetDeviceRegistry = clientHelper.BuildApiCall<GetDeviceRegistryRequest, DeviceRegistry>(grpcClient.GetDeviceRegistryAsync, grpcClient.GetDeviceRegistry, effectiveSettings.GetDeviceRegistrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeviceRegistry);
            Modify_GetDeviceRegistryApiCall(ref _callGetDeviceRegistry);
            _callUpdateDeviceRegistry = clientHelper.BuildApiCall<UpdateDeviceRegistryRequest, DeviceRegistry>(grpcClient.UpdateDeviceRegistryAsync, grpcClient.UpdateDeviceRegistry, effectiveSettings.UpdateDeviceRegistrySettings).WithGoogleRequestParam("device_registry.name", request => request.DeviceRegistry?.Name);
            Modify_ApiCall(ref _callUpdateDeviceRegistry);
            Modify_UpdateDeviceRegistryApiCall(ref _callUpdateDeviceRegistry);
            _callDeleteDeviceRegistry = clientHelper.BuildApiCall<DeleteDeviceRegistryRequest, wkt::Empty>(grpcClient.DeleteDeviceRegistryAsync, grpcClient.DeleteDeviceRegistry, effectiveSettings.DeleteDeviceRegistrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeviceRegistry);
            Modify_DeleteDeviceRegistryApiCall(ref _callDeleteDeviceRegistry);
            _callListDeviceRegistries = clientHelper.BuildApiCall<ListDeviceRegistriesRequest, ListDeviceRegistriesResponse>(grpcClient.ListDeviceRegistriesAsync, grpcClient.ListDeviceRegistries, effectiveSettings.ListDeviceRegistriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeviceRegistries);
            Modify_ListDeviceRegistriesApiCall(ref _callListDeviceRegistries);
            _callCreateDevice = clientHelper.BuildApiCall<CreateDeviceRequest, Device>(grpcClient.CreateDeviceAsync, grpcClient.CreateDevice, effectiveSettings.CreateDeviceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDevice);
            Modify_CreateDeviceApiCall(ref _callCreateDevice);
            _callGetDevice = clientHelper.BuildApiCall<GetDeviceRequest, Device>(grpcClient.GetDeviceAsync, grpcClient.GetDevice, effectiveSettings.GetDeviceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDevice);
            Modify_GetDeviceApiCall(ref _callGetDevice);
            _callUpdateDevice = clientHelper.BuildApiCall<UpdateDeviceRequest, Device>(grpcClient.UpdateDeviceAsync, grpcClient.UpdateDevice, effectiveSettings.UpdateDeviceSettings).WithGoogleRequestParam("device.name", request => request.Device?.Name);
            Modify_ApiCall(ref _callUpdateDevice);
            Modify_UpdateDeviceApiCall(ref _callUpdateDevice);
            _callDeleteDevice = clientHelper.BuildApiCall<DeleteDeviceRequest, wkt::Empty>(grpcClient.DeleteDeviceAsync, grpcClient.DeleteDevice, effectiveSettings.DeleteDeviceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDevice);
            Modify_DeleteDeviceApiCall(ref _callDeleteDevice);
            _callListDevices = clientHelper.BuildApiCall<ListDevicesRequest, ListDevicesResponse>(grpcClient.ListDevicesAsync, grpcClient.ListDevices, effectiveSettings.ListDevicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDevices);
            Modify_ListDevicesApiCall(ref _callListDevices);
            _callModifyCloudToDeviceConfig = clientHelper.BuildApiCall<ModifyCloudToDeviceConfigRequest, DeviceConfig>(grpcClient.ModifyCloudToDeviceConfigAsync, grpcClient.ModifyCloudToDeviceConfig, effectiveSettings.ModifyCloudToDeviceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callModifyCloudToDeviceConfig);
            Modify_ModifyCloudToDeviceConfigApiCall(ref _callModifyCloudToDeviceConfig);
            _callListDeviceConfigVersions = clientHelper.BuildApiCall<ListDeviceConfigVersionsRequest, ListDeviceConfigVersionsResponse>(grpcClient.ListDeviceConfigVersionsAsync, grpcClient.ListDeviceConfigVersions, effectiveSettings.ListDeviceConfigVersionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListDeviceConfigVersions);
            Modify_ListDeviceConfigVersionsApiCall(ref _callListDeviceConfigVersions);
            _callListDeviceStates = clientHelper.BuildApiCall<ListDeviceStatesRequest, ListDeviceStatesResponse>(grpcClient.ListDeviceStatesAsync, grpcClient.ListDeviceStates, effectiveSettings.ListDeviceStatesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListDeviceStates);
            Modify_ListDeviceStatesApiCall(ref _callListDeviceStates);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>(grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>(grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>(grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callSendCommandToDevice = clientHelper.BuildApiCall<SendCommandToDeviceRequest, SendCommandToDeviceResponse>(grpcClient.SendCommandToDeviceAsync, grpcClient.SendCommandToDevice, effectiveSettings.SendCommandToDeviceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSendCommandToDevice);
            Modify_SendCommandToDeviceApiCall(ref _callSendCommandToDevice);
            _callBindDeviceToGateway = clientHelper.BuildApiCall<BindDeviceToGatewayRequest, BindDeviceToGatewayResponse>(grpcClient.BindDeviceToGatewayAsync, grpcClient.BindDeviceToGateway, effectiveSettings.BindDeviceToGatewaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBindDeviceToGateway);
            Modify_BindDeviceToGatewayApiCall(ref _callBindDeviceToGateway);
            _callUnbindDeviceFromGateway = clientHelper.BuildApiCall<UnbindDeviceFromGatewayRequest, UnbindDeviceFromGatewayResponse>(grpcClient.UnbindDeviceFromGatewayAsync, grpcClient.UnbindDeviceFromGateway, effectiveSettings.UnbindDeviceFromGatewaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUnbindDeviceFromGateway);
            Modify_UnbindDeviceFromGatewayApiCall(ref _callUnbindDeviceFromGateway);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDeviceRegistryApiCall(ref gaxgrpc::ApiCall<CreateDeviceRegistryRequest, DeviceRegistry> call);

        partial void Modify_GetDeviceRegistryApiCall(ref gaxgrpc::ApiCall<GetDeviceRegistryRequest, DeviceRegistry> call);

        partial void Modify_UpdateDeviceRegistryApiCall(ref gaxgrpc::ApiCall<UpdateDeviceRegistryRequest, DeviceRegistry> call);

        partial void Modify_DeleteDeviceRegistryApiCall(ref gaxgrpc::ApiCall<DeleteDeviceRegistryRequest, wkt::Empty> call);

        partial void Modify_ListDeviceRegistriesApiCall(ref gaxgrpc::ApiCall<ListDeviceRegistriesRequest, ListDeviceRegistriesResponse> call);

        partial void Modify_CreateDeviceApiCall(ref gaxgrpc::ApiCall<CreateDeviceRequest, Device> call);

        partial void Modify_GetDeviceApiCall(ref gaxgrpc::ApiCall<GetDeviceRequest, Device> call);

        partial void Modify_UpdateDeviceApiCall(ref gaxgrpc::ApiCall<UpdateDeviceRequest, Device> call);

        partial void Modify_DeleteDeviceApiCall(ref gaxgrpc::ApiCall<DeleteDeviceRequest, wkt::Empty> call);

        partial void Modify_ListDevicesApiCall(ref gaxgrpc::ApiCall<ListDevicesRequest, ListDevicesResponse> call);

        partial void Modify_ModifyCloudToDeviceConfigApiCall(ref gaxgrpc::ApiCall<ModifyCloudToDeviceConfigRequest, DeviceConfig> call);

        partial void Modify_ListDeviceConfigVersionsApiCall(ref gaxgrpc::ApiCall<ListDeviceConfigVersionsRequest, ListDeviceConfigVersionsResponse> call);

        partial void Modify_ListDeviceStatesApiCall(ref gaxgrpc::ApiCall<ListDeviceStatesRequest, ListDeviceStatesResponse> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_SendCommandToDeviceApiCall(ref gaxgrpc::ApiCall<SendCommandToDeviceRequest, SendCommandToDeviceResponse> call);

        partial void Modify_BindDeviceToGatewayApiCall(ref gaxgrpc::ApiCall<BindDeviceToGatewayRequest, BindDeviceToGatewayResponse> call);

        partial void Modify_UnbindDeviceFromGatewayApiCall(ref gaxgrpc::ApiCall<UnbindDeviceFromGatewayRequest, UnbindDeviceFromGatewayResponse> call);

        partial void OnConstruction(DeviceManager.DeviceManagerClient grpcClient, DeviceManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeviceManager client</summary>
        public override DeviceManager.DeviceManagerClient GrpcClient { get; }

        partial void Modify_CreateDeviceRegistryRequest(ref CreateDeviceRegistryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeviceRegistryRequest(ref GetDeviceRegistryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeviceRegistryRequest(ref UpdateDeviceRegistryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeviceRegistryRequest(ref DeleteDeviceRegistryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceRegistriesRequest(ref ListDeviceRegistriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeviceRequest(ref CreateDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeviceRequest(ref GetDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeviceRequest(ref UpdateDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeviceRequest(ref DeleteDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDevicesRequest(ref ListDevicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ModifyCloudToDeviceConfigRequest(ref ModifyCloudToDeviceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceConfigVersionsRequest(ref ListDeviceConfigVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceStatesRequest(ref ListDeviceStatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SendCommandToDeviceRequest(ref SendCommandToDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BindDeviceToGatewayRequest(ref BindDeviceToGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnbindDeviceFromGatewayRequest(ref UnbindDeviceFromGatewayRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceRegistry CreateDeviceRegistry(CreateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeviceRegistryRequest(ref request, ref callSettings);
            return _callCreateDeviceRegistry.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a device registry that contains devices.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceRegistry> CreateDeviceRegistryAsync(CreateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeviceRegistryRequest(ref request, ref callSettings);
            return _callCreateDeviceRegistry.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceRegistry GetDeviceRegistry(GetDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceRegistryRequest(ref request, ref callSettings);
            return _callGetDeviceRegistry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceRegistry> GetDeviceRegistryAsync(GetDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceRegistryRequest(ref request, ref callSettings);
            return _callGetDeviceRegistry.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceRegistry UpdateDeviceRegistry(UpdateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeviceRegistryRequest(ref request, ref callSettings);
            return _callUpdateDeviceRegistry.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceRegistry> UpdateDeviceRegistryAsync(UpdateDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeviceRegistryRequest(ref request, ref callSettings);
            return _callUpdateDeviceRegistry.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDeviceRegistry(DeleteDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeviceRegistryRequest(ref request, ref callSettings);
            _callDeleteDeviceRegistry.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a device registry configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDeviceRegistryAsync(DeleteDeviceRegistryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeviceRegistryRequest(ref request, ref callSettings);
            return _callDeleteDeviceRegistry.Async(request, callSettings);
        }

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistries(ListDeviceRegistriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceRegistriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeviceRegistriesRequest, ListDeviceRegistriesResponse, DeviceRegistry>(_callListDeviceRegistries, request, callSettings);
        }

        /// <summary>
        /// Lists device registries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceRegistry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> ListDeviceRegistriesAsync(ListDeviceRegistriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceRegistriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeviceRegistriesRequest, ListDeviceRegistriesResponse, DeviceRegistry>(_callListDeviceRegistries, request, callSettings);
        }

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Device CreateDevice(CreateDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeviceRequest(ref request, ref callSettings);
            return _callCreateDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a device in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Device> CreateDeviceAsync(CreateDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeviceRequest(ref request, ref callSettings);
            return _callCreateDevice.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Device GetDevice(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceRequest(ref request, ref callSettings);
            return _callGetDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Device> GetDeviceAsync(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceRequest(ref request, ref callSettings);
            return _callGetDevice.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Device UpdateDevice(UpdateDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeviceRequest(ref request, ref callSettings);
            return _callUpdateDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Device> UpdateDeviceAsync(UpdateDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeviceRequest(ref request, ref callSettings);
            return _callUpdateDevice.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDevice(DeleteDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeviceRequest(ref request, ref callSettings);
            _callDeleteDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDeviceAsync(DeleteDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeviceRequest(ref request, ref callSettings);
            return _callDeleteDevice.Async(request, callSettings);
        }

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Device"/> resources.</returns>
        public override gax::PagedEnumerable<ListDevicesResponse, Device> ListDevices(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDevicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDevicesRequest, ListDevicesResponse, Device>(_callListDevices, request, callSettings);
        }

        /// <summary>
        /// List devices in a device registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Device"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDevicesResponse, Device> ListDevicesAsync(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDevicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDevicesRequest, ListDevicesResponse, Device>(_callListDevices, request, callSettings);
        }

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceConfig ModifyCloudToDeviceConfig(ModifyCloudToDeviceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyCloudToDeviceConfigRequest(ref request, ref callSettings);
            return _callModifyCloudToDeviceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies the configuration for the device, which is eventually sent from
        /// the Cloud IoT Core servers. Returns the modified configuration version and
        /// its metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceConfig> ModifyCloudToDeviceConfigAsync(ModifyCloudToDeviceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyCloudToDeviceConfigRequest(ref request, ref callSettings);
            return _callModifyCloudToDeviceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListDeviceConfigVersionsResponse ListDeviceConfigVersions(ListDeviceConfigVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceConfigVersionsRequest(ref request, ref callSettings);
            return _callListDeviceConfigVersions.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the last few versions of the device configuration in descending
        /// order (i.e.: newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListDeviceConfigVersionsResponse> ListDeviceConfigVersionsAsync(ListDeviceConfigVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceConfigVersionsRequest(ref request, ref callSettings);
            return _callListDeviceConfigVersions.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListDeviceStatesResponse ListDeviceStates(ListDeviceStatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceStatesRequest(ref request, ref callSettings);
            return _callListDeviceStates.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the last few versions of the device state in descending order (i.e.:
        /// newest first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListDeviceStatesResponse> ListDeviceStatesAsync(ListDeviceStatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceStatesRequest(ref request, ref callSettings);
            return _callListDeviceStates.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
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
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
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
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
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
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
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
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SendCommandToDeviceResponse SendCommandToDevice(SendCommandToDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendCommandToDeviceRequest(ref request, ref callSettings);
            return _callSendCommandToDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends a command to the specified device. In order for a device to be able
        /// to receive commands, it must:
        /// 1) be connected to Cloud IoT Core using the MQTT protocol, and
        /// 2) be subscribed to the group of MQTT topics specified by
        /// /devices/{device-id}/commands/#. This subscription will receive commands
        /// at the top-level topic /devices/{device-id}/commands as well as commands
        /// for subfolders, like /devices/{device-id}/commands/subfolder.
        /// Note that subscribing to specific subfolders is not supported.
        /// If the command could not be delivered to the device, this method will
        /// return an error; in particular, if the device is not subscribed, this
        /// method will return FAILED_PRECONDITION. Otherwise, this method will
        /// return OK. If the subscription is QoS 1, at least once delivery will be
        /// guaranteed; for QoS 0, no acknowledgment will be expected from the device.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SendCommandToDeviceResponse> SendCommandToDeviceAsync(SendCommandToDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendCommandToDeviceRequest(ref request, ref callSettings);
            return _callSendCommandToDevice.Async(request, callSettings);
        }

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BindDeviceToGatewayResponse BindDeviceToGateway(BindDeviceToGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BindDeviceToGatewayRequest(ref request, ref callSettings);
            return _callBindDeviceToGateway.Sync(request, callSettings);
        }

        /// <summary>
        /// Associates the device with the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BindDeviceToGatewayResponse> BindDeviceToGatewayAsync(BindDeviceToGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BindDeviceToGatewayRequest(ref request, ref callSettings);
            return _callBindDeviceToGateway.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnbindDeviceFromGatewayResponse UnbindDeviceFromGateway(UnbindDeviceFromGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnbindDeviceFromGatewayRequest(ref request, ref callSettings);
            return _callUnbindDeviceFromGateway.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the association between the device and the gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnbindDeviceFromGatewayResponse> UnbindDeviceFromGatewayAsync(UnbindDeviceFromGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnbindDeviceFromGatewayRequest(ref request, ref callSettings);
            return _callUnbindDeviceFromGateway.Async(request, callSettings);
        }
    }

    public partial class ListDeviceRegistriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDevicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeviceRegistriesResponse : gaxgrpc::IPageResponse<DeviceRegistry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeviceRegistry> GetEnumerator() => DeviceRegistries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDevicesResponse : gaxgrpc::IPageResponse<Device>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Device> GetEnumerator() => Devices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
