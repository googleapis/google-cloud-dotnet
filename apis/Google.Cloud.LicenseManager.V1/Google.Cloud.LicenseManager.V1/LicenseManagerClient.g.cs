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

namespace Google.Cloud.LicenseManager.V1
{
    /// <summary>Settings for <see cref="LicenseManagerClient"/> instances.</summary>
    public sealed partial class LicenseManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LicenseManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LicenseManagerSettings"/>.</returns>
        public static LicenseManagerSettings GetDefault() => new LicenseManagerSettings();

        /// <summary>Constructs a new <see cref="LicenseManagerSettings"/> object with default settings.</summary>
        public LicenseManagerSettings()
        {
        }

        private LicenseManagerSettings(LicenseManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConfigurationsSettings = existing.ListConfigurationsSettings;
            GetConfigurationSettings = existing.GetConfigurationSettings;
            CreateConfigurationSettings = existing.CreateConfigurationSettings;
            CreateConfigurationOperationsSettings = existing.CreateConfigurationOperationsSettings.Clone();
            UpdateConfigurationSettings = existing.UpdateConfigurationSettings;
            UpdateConfigurationOperationsSettings = existing.UpdateConfigurationOperationsSettings.Clone();
            DeleteConfigurationSettings = existing.DeleteConfigurationSettings;
            DeleteConfigurationOperationsSettings = existing.DeleteConfigurationOperationsSettings.Clone();
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            DeactivateConfigurationSettings = existing.DeactivateConfigurationSettings;
            DeactivateConfigurationOperationsSettings = existing.DeactivateConfigurationOperationsSettings.Clone();
            ReactivateConfigurationSettings = existing.ReactivateConfigurationSettings;
            ReactivateConfigurationOperationsSettings = existing.ReactivateConfigurationOperationsSettings.Clone();
            QueryConfigurationLicenseUsageSettings = existing.QueryConfigurationLicenseUsageSettings;
            AggregateUsageSettings = existing.AggregateUsageSettings;
            ListProductsSettings = existing.ListProductsSettings;
            GetProductSettings = existing.GetProductSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LicenseManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.ListConfigurations</c> and <c>LicenseManagerClient.ListConfigurationsAsync</c>.
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
        public gaxgrpc::CallSettings ListConfigurationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.GetConfiguration</c> and <c>LicenseManagerClient.GetConfigurationAsync</c>.
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
        public gaxgrpc::CallSettings GetConfigurationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.CreateConfiguration</c> and <c>LicenseManagerClient.CreateConfigurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConfigurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LicenseManagerClient.CreateConfiguration</c> and
        /// <c>LicenseManagerClient.CreateConfigurationAsync</c>.
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
        public lro::OperationsSettings CreateConfigurationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.UpdateConfiguration</c> and <c>LicenseManagerClient.UpdateConfigurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConfigurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LicenseManagerClient.UpdateConfiguration</c> and
        /// <c>LicenseManagerClient.UpdateConfigurationAsync</c>.
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
        public lro::OperationsSettings UpdateConfigurationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.DeleteConfiguration</c> and <c>LicenseManagerClient.DeleteConfigurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConfigurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LicenseManagerClient.DeleteConfiguration</c> and
        /// <c>LicenseManagerClient.DeleteConfigurationAsync</c>.
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
        public lro::OperationsSettings DeleteConfigurationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.ListInstances</c> and <c>LicenseManagerClient.ListInstancesAsync</c>.
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
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.GetInstance</c> and <c>LicenseManagerClient.GetInstanceAsync</c>.
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
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.DeactivateConfiguration</c> and <c>LicenseManagerClient.DeactivateConfigurationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeactivateConfigurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>LicenseManagerClient.DeactivateConfiguration</c> and
        /// <c>LicenseManagerClient.DeactivateConfigurationAsync</c>.
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
        public lro::OperationsSettings DeactivateConfigurationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.ReactivateConfiguration</c> and <c>LicenseManagerClient.ReactivateConfigurationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReactivateConfigurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>LicenseManagerClient.ReactivateConfiguration</c> and
        /// <c>LicenseManagerClient.ReactivateConfigurationAsync</c>.
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
        public lro::OperationsSettings ReactivateConfigurationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.QueryConfigurationLicenseUsage</c> and
        /// <c>LicenseManagerClient.QueryConfigurationLicenseUsageAsync</c>.
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
        public gaxgrpc::CallSettings QueryConfigurationLicenseUsageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.AggregateUsage</c> and <c>LicenseManagerClient.AggregateUsageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregateUsageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.ListProducts</c> and <c>LicenseManagerClient.ListProductsAsync</c>.
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
        public gaxgrpc::CallSettings ListProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagerClient.GetProduct</c> and <c>LicenseManagerClient.GetProductAsync</c>.
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
        public gaxgrpc::CallSettings GetProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LicenseManagerSettings"/> object.</returns>
        public LicenseManagerSettings Clone() => new LicenseManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LicenseManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LicenseManagerClientBuilder : gaxgrpc::ClientBuilderBase<LicenseManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LicenseManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LicenseManagerClientBuilder() : base(LicenseManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LicenseManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LicenseManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LicenseManagerClient Build()
        {
            LicenseManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LicenseManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LicenseManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LicenseManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LicenseManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LicenseManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LicenseManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LicenseManagerClient.ChannelPool;
    }

    /// <summary>LicenseManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class LicenseManagerClient
    {
        /// <summary>
        /// The default endpoint for the LicenseManager service, which is a host of "licensemanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "licensemanager.googleapis.com:443";

        /// <summary>The default LicenseManager scopes.</summary>
        /// <remarks>
        /// The default LicenseManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LicenseManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LicenseManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LicenseManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LicenseManagerClient"/>.</returns>
        public static stt::Task<LicenseManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LicenseManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LicenseManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LicenseManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LicenseManagerClient"/>.</returns>
        public static LicenseManagerClient Create() => new LicenseManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LicenseManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LicenseManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LicenseManagerClient"/>.</returns>
        internal static LicenseManagerClient Create(grpccore::CallInvoker callInvoker, LicenseManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LicenseManager.LicenseManagerClient grpcClient = new LicenseManager.LicenseManagerClient(callInvoker);
            return new LicenseManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LicenseManager client</summary>
        public virtual LicenseManager.LicenseManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Configuration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConfigurationsResponse, Configuration> ListConfigurations(ListConfigurationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Configuration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> ListConfigurationsAsync(ListConfigurationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListConfigurationsRequest
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
        /// <returns>A pageable sequence of <see cref="Configuration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConfigurationsResponse, Configuration> ListConfigurations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConfigurationsRequest request = new ListConfigurationsRequest
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
            return ListConfigurations(request, callSettings);
        }

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListConfigurationsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Configuration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> ListConfigurationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConfigurationsRequest request = new ListConfigurationsRequest
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
            return ListConfigurationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListConfigurationsRequest
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
        /// <returns>A pageable sequence of <see cref="Configuration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConfigurationsResponse, Configuration> ListConfigurations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConfigurationsRequest request = new ListConfigurationsRequest
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
            return ListConfigurations(request, callSettings);
        }

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListConfigurationsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Configuration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> ListConfigurationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConfigurationsRequest request = new ListConfigurationsRequest
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
            return ListConfigurationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Configuration GetConfiguration(GetConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Configuration> GetConfigurationAsync(GetConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Configuration> GetConfigurationAsync(GetConfigurationRequest request, st::CancellationToken cancellationToken) =>
            GetConfigurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Configuration GetConfiguration(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfiguration(new GetConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Configuration> GetConfigurationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigurationAsync(new GetConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Configuration> GetConfigurationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Configuration GetConfiguration(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfiguration(new GetConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Configuration> GetConfigurationAsync(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigurationAsync(new GetConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Configuration> GetConfigurationAsync(ConfigurationName name, st::CancellationToken cancellationToken) =>
            GetConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> CreateConfiguration(CreateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(CreateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(CreateConfigurationRequest request, st::CancellationToken cancellationToken) =>
            CreateConfigurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConfiguration</c>.</summary>
        public virtual lro::OperationsClient CreateConfigurationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateConfiguration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> PollOnceCreateConfiguration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> PollOnceCreateConfigurationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="configuration">
        /// Required. The resource being created
        /// </param>
        /// <param name="configurationId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> CreateConfiguration(string parent, Configuration configuration, string configurationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConfiguration(new CreateConfigurationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConfigurationId = gax::GaxPreconditions.CheckNotNullOrEmpty(configurationId, nameof(configurationId)),
                Configuration = gax::GaxPreconditions.CheckNotNull(configuration, nameof(configuration)),
            }, callSettings);

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="configuration">
        /// Required. The resource being created
        /// </param>
        /// <param name="configurationId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(string parent, Configuration configuration, string configurationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConfigurationAsync(new CreateConfigurationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConfigurationId = gax::GaxPreconditions.CheckNotNullOrEmpty(configurationId, nameof(configurationId)),
                Configuration = gax::GaxPreconditions.CheckNotNull(configuration, nameof(configuration)),
            }, callSettings);

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="configuration">
        /// Required. The resource being created
        /// </param>
        /// <param name="configurationId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(string parent, Configuration configuration, string configurationId, st::CancellationToken cancellationToken) =>
            CreateConfigurationAsync(parent, configuration, configurationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="configuration">
        /// Required. The resource being created
        /// </param>
        /// <param name="configurationId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> CreateConfiguration(gagr::LocationName parent, Configuration configuration, string configurationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConfiguration(new CreateConfigurationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigurationId = gax::GaxPreconditions.CheckNotNullOrEmpty(configurationId, nameof(configurationId)),
                Configuration = gax::GaxPreconditions.CheckNotNull(configuration, nameof(configuration)),
            }, callSettings);

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="configuration">
        /// Required. The resource being created
        /// </param>
        /// <param name="configurationId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(gagr::LocationName parent, Configuration configuration, string configurationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConfigurationAsync(new CreateConfigurationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigurationId = gax::GaxPreconditions.CheckNotNullOrEmpty(configurationId, nameof(configurationId)),
                Configuration = gax::GaxPreconditions.CheckNotNull(configuration, nameof(configuration)),
            }, callSettings);

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="configuration">
        /// Required. The resource being created
        /// </param>
        /// <param name="configurationId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(gagr::LocationName parent, Configuration configuration, string configurationId, st::CancellationToken cancellationToken) =>
            CreateConfigurationAsync(parent, configuration, configurationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> UpdateConfiguration(UpdateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> UpdateConfigurationAsync(UpdateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> UpdateConfigurationAsync(UpdateConfigurationRequest request, st::CancellationToken cancellationToken) =>
            UpdateConfigurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConfiguration</c>.</summary>
        public virtual lro::OperationsClient UpdateConfigurationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateConfiguration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> PollOnceUpdateConfiguration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> PollOnceUpdateConfigurationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="configuration">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Configuration resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> UpdateConfiguration(Configuration configuration, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfiguration(new UpdateConfigurationRequest
            {
                UpdateMask = updateMask,
                Configuration = gax::GaxPreconditions.CheckNotNull(configuration, nameof(configuration)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="configuration">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Configuration resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> UpdateConfigurationAsync(Configuration configuration, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfigurationAsync(new UpdateConfigurationRequest
            {
                UpdateMask = updateMask,
                Configuration = gax::GaxPreconditions.CheckNotNull(configuration, nameof(configuration)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="configuration">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Configuration resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> UpdateConfigurationAsync(Configuration configuration, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConfigurationAsync(configuration, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConfiguration(DeleteConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(DeleteConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(DeleteConfigurationRequest request, st::CancellationToken cancellationToken) =>
            DeleteConfigurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConfiguration</c>.</summary>
        public virtual lro::OperationsClient DeleteConfigurationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteConfiguration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConfiguration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConfigurationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConfiguration(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConfiguration(new DeleteConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConfigurationAsync(new DeleteConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConfiguration(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConfiguration(new DeleteConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConfigurationAsync(new DeleteConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(ConfigurationName name, st::CancellationToken cancellationToken) =>
            DeleteConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> DeactivateConfiguration(DeactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(DeactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(DeactivateConfigurationRequest request, st::CancellationToken cancellationToken) =>
            DeactivateConfigurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeactivateConfiguration</c>.</summary>
        public virtual lro::OperationsClient DeactivateConfigurationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeactivateConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> PollOnceDeactivateConfiguration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeactivateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeactivateConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> PollOnceDeactivateConfigurationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeactivateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> DeactivateConfiguration(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeactivateConfiguration(new DeactivateConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeactivateConfigurationAsync(new DeactivateConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(string name, st::CancellationToken cancellationToken) =>
            DeactivateConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> DeactivateConfiguration(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeactivateConfiguration(new DeactivateConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeactivateConfigurationAsync(new DeactivateConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(ConfigurationName name, st::CancellationToken cancellationToken) =>
            DeactivateConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> ReactivateConfiguration(ReactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(ReactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(ReactivateConfigurationRequest request, st::CancellationToken cancellationToken) =>
            ReactivateConfigurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReactivateConfiguration</c>.</summary>
        public virtual lro::OperationsClient ReactivateConfigurationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReactivateConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> PollOnceReactivateConfiguration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReactivateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReactivateConfiguration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> PollOnceReactivateConfigurationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Configuration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReactivateConfigurationOperationsClient, callSettings);

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> ReactivateConfiguration(string name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateConfiguration(new ReactivateConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateConfigurationAsync(new ReactivateConfigurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(string name, st::CancellationToken cancellationToken) =>
            ReactivateConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Configuration, OperationMetadata> ReactivateConfiguration(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateConfiguration(new ReactivateConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(ConfigurationName name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateConfigurationAsync(new ReactivateConfigurationRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(ConfigurationName name, st::CancellationToken cancellationToken) =>
            ReactivateConfigurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryConfigurationLicenseUsageResponse QueryConfigurationLicenseUsage(QueryConfigurationLicenseUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(QueryConfigurationLicenseUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(QueryConfigurationLicenseUsageRequest request, st::CancellationToken cancellationToken) =>
            QueryConfigurationLicenseUsageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The resource path of the Configuration.
        /// </param>
        /// <param name="startTime">
        /// Required. The start time for retrieving the usage. If not specified, we
        /// will use the first day of the current billing period.
        /// </param>
        /// <param name="endTime">
        /// Required. The end time for retrieving the usage. If not specified, we will
        /// use the last day of the current billing period.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryConfigurationLicenseUsageResponse QueryConfigurationLicenseUsage(string name, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            QueryConfigurationLicenseUsage(new QueryConfigurationLicenseUsageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The resource path of the Configuration.
        /// </param>
        /// <param name="startTime">
        /// Required. The start time for retrieving the usage. If not specified, we
        /// will use the first day of the current billing period.
        /// </param>
        /// <param name="endTime">
        /// Required. The end time for retrieving the usage. If not specified, we will
        /// use the last day of the current billing period.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(string name, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            QueryConfigurationLicenseUsageAsync(new QueryConfigurationLicenseUsageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The resource path of the Configuration.
        /// </param>
        /// <param name="startTime">
        /// Required. The start time for retrieving the usage. If not specified, we
        /// will use the first day of the current billing period.
        /// </param>
        /// <param name="endTime">
        /// Required. The end time for retrieving the usage. If not specified, we will
        /// use the last day of the current billing period.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(string name, wkt::Timestamp startTime, wkt::Timestamp endTime, st::CancellationToken cancellationToken) =>
            QueryConfigurationLicenseUsageAsync(name, startTime, endTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The resource path of the Configuration.
        /// </param>
        /// <param name="startTime">
        /// Required. The start time for retrieving the usage. If not specified, we
        /// will use the first day of the current billing period.
        /// </param>
        /// <param name="endTime">
        /// Required. The end time for retrieving the usage. If not specified, we will
        /// use the last day of the current billing period.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryConfigurationLicenseUsageResponse QueryConfigurationLicenseUsage(ConfigurationName name, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            QueryConfigurationLicenseUsage(new QueryConfigurationLicenseUsageRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The resource path of the Configuration.
        /// </param>
        /// <param name="startTime">
        /// Required. The start time for retrieving the usage. If not specified, we
        /// will use the first day of the current billing period.
        /// </param>
        /// <param name="endTime">
        /// Required. The end time for retrieving the usage. If not specified, we will
        /// use the last day of the current billing period.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(ConfigurationName name, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            QueryConfigurationLicenseUsageAsync(new QueryConfigurationLicenseUsageRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The resource path of the Configuration.
        /// </param>
        /// <param name="startTime">
        /// Required. The start time for retrieving the usage. If not specified, we
        /// will use the first day of the current billing period.
        /// </param>
        /// <param name="endTime">
        /// Required. The end time for retrieving the usage. If not specified, we will
        /// use the last day of the current billing period.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(ConfigurationName name, wkt::Timestamp startTime, wkt::Timestamp endTime, st::CancellationToken cancellationToken) =>
            QueryConfigurationLicenseUsageAsync(name, startTime, endTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Usage"/> resources.</returns>
        public virtual gax::PagedEnumerable<AggregateUsageResponse, Usage> AggregateUsage(AggregateUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Usage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<AggregateUsageResponse, Usage> AggregateUsageAsync(AggregateUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Parent value for AggregateUsageRequest
        /// </param>
        /// <param name="startTime">
        /// Required. Licenses are purchased per month - so usage track needs start
        /// time of a month.
        /// </param>
        /// <param name="endTime">
        /// Required. Usage track is always for a month. This parameter is for the end
        /// time of the month.
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
        /// <returns>A pageable sequence of <see cref="Usage"/> resources.</returns>
        public virtual gax::PagedEnumerable<AggregateUsageResponse, Usage> AggregateUsage(string name, wkt::Timestamp startTime, wkt::Timestamp endTime, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateUsageRequest request = new AggregateUsageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregateUsage(request, callSettings);
        }

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Parent value for AggregateUsageRequest
        /// </param>
        /// <param name="startTime">
        /// Required. Licenses are purchased per month - so usage track needs start
        /// time of a month.
        /// </param>
        /// <param name="endTime">
        /// Required. Usage track is always for a month. This parameter is for the end
        /// time of the month.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Usage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<AggregateUsageResponse, Usage> AggregateUsageAsync(string name, wkt::Timestamp startTime, wkt::Timestamp endTime, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateUsageRequest request = new AggregateUsageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregateUsageAsync(request, callSettings);
        }

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Parent value for AggregateUsageRequest
        /// </param>
        /// <param name="startTime">
        /// Required. Licenses are purchased per month - so usage track needs start
        /// time of a month.
        /// </param>
        /// <param name="endTime">
        /// Required. Usage track is always for a month. This parameter is for the end
        /// time of the month.
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
        /// <returns>A pageable sequence of <see cref="Usage"/> resources.</returns>
        public virtual gax::PagedEnumerable<AggregateUsageResponse, Usage> AggregateUsage(ConfigurationName name, wkt::Timestamp startTime, wkt::Timestamp endTime, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateUsageRequest request = new AggregateUsageRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregateUsage(request, callSettings);
        }

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Parent value for AggregateUsageRequest
        /// </param>
        /// <param name="startTime">
        /// Required. Licenses are purchased per month - so usage track needs start
        /// time of a month.
        /// </param>
        /// <param name="endTime">
        /// Required. Usage track is always for a month. This parameter is for the end
        /// time of the month.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Usage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<AggregateUsageResponse, Usage> AggregateUsageAsync(ConfigurationName name, wkt::Timestamp startTime, wkt::Timestamp endTime, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateUsageRequest request = new AggregateUsageRequest
            {
                ConfigurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregateUsageAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProductsRequest
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProducts(request, callSettings);
        }

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProductsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProductsRequest
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProducts(request, callSettings);
        }

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProductsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, st::CancellationToken cancellationToken) =>
            GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LicenseManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class LicenseManagerClientImpl : LicenseManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListConfigurationsRequest, ListConfigurationsResponse> _callListConfigurations;

        private readonly gaxgrpc::ApiCall<GetConfigurationRequest, Configuration> _callGetConfiguration;

        private readonly gaxgrpc::ApiCall<CreateConfigurationRequest, lro::Operation> _callCreateConfiguration;

        private readonly gaxgrpc::ApiCall<UpdateConfigurationRequest, lro::Operation> _callUpdateConfiguration;

        private readonly gaxgrpc::ApiCall<DeleteConfigurationRequest, lro::Operation> _callDeleteConfiguration;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<DeactivateConfigurationRequest, lro::Operation> _callDeactivateConfiguration;

        private readonly gaxgrpc::ApiCall<ReactivateConfigurationRequest, lro::Operation> _callReactivateConfiguration;

        private readonly gaxgrpc::ApiCall<QueryConfigurationLicenseUsageRequest, QueryConfigurationLicenseUsageResponse> _callQueryConfigurationLicenseUsage;

        private readonly gaxgrpc::ApiCall<AggregateUsageRequest, AggregateUsageResponse> _callAggregateUsage;

        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;

        private readonly gaxgrpc::ApiCall<GetProductRequest, Product> _callGetProduct;

        /// <summary>
        /// Constructs a client wrapper for the LicenseManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LicenseManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LicenseManagerClientImpl(LicenseManager.LicenseManagerClient grpcClient, LicenseManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LicenseManagerSettings effectiveSettings = settings ?? LicenseManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConfigurationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConfigurationOperationsSettings, logger);
            UpdateConfigurationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConfigurationOperationsSettings, logger);
            DeleteConfigurationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConfigurationOperationsSettings, logger);
            DeactivateConfigurationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeactivateConfigurationOperationsSettings, logger);
            ReactivateConfigurationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReactivateConfigurationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListConfigurations = clientHelper.BuildApiCall<ListConfigurationsRequest, ListConfigurationsResponse>("ListConfigurations", grpcClient.ListConfigurationsAsync, grpcClient.ListConfigurations, effectiveSettings.ListConfigurationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConfigurations);
            Modify_ListConfigurationsApiCall(ref _callListConfigurations);
            _callGetConfiguration = clientHelper.BuildApiCall<GetConfigurationRequest, Configuration>("GetConfiguration", grpcClient.GetConfigurationAsync, grpcClient.GetConfiguration, effectiveSettings.GetConfigurationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConfiguration);
            Modify_GetConfigurationApiCall(ref _callGetConfiguration);
            _callCreateConfiguration = clientHelper.BuildApiCall<CreateConfigurationRequest, lro::Operation>("CreateConfiguration", grpcClient.CreateConfigurationAsync, grpcClient.CreateConfiguration, effectiveSettings.CreateConfigurationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConfiguration);
            Modify_CreateConfigurationApiCall(ref _callCreateConfiguration);
            _callUpdateConfiguration = clientHelper.BuildApiCall<UpdateConfigurationRequest, lro::Operation>("UpdateConfiguration", grpcClient.UpdateConfigurationAsync, grpcClient.UpdateConfiguration, effectiveSettings.UpdateConfigurationSettings).WithGoogleRequestParam("configuration.name", request => request.Configuration?.Name);
            Modify_ApiCall(ref _callUpdateConfiguration);
            Modify_UpdateConfigurationApiCall(ref _callUpdateConfiguration);
            _callDeleteConfiguration = clientHelper.BuildApiCall<DeleteConfigurationRequest, lro::Operation>("DeleteConfiguration", grpcClient.DeleteConfigurationAsync, grpcClient.DeleteConfiguration, effectiveSettings.DeleteConfigurationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConfiguration);
            Modify_DeleteConfigurationApiCall(ref _callDeleteConfiguration);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callDeactivateConfiguration = clientHelper.BuildApiCall<DeactivateConfigurationRequest, lro::Operation>("DeactivateConfiguration", grpcClient.DeactivateConfigurationAsync, grpcClient.DeactivateConfiguration, effectiveSettings.DeactivateConfigurationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeactivateConfiguration);
            Modify_DeactivateConfigurationApiCall(ref _callDeactivateConfiguration);
            _callReactivateConfiguration = clientHelper.BuildApiCall<ReactivateConfigurationRequest, lro::Operation>("ReactivateConfiguration", grpcClient.ReactivateConfigurationAsync, grpcClient.ReactivateConfiguration, effectiveSettings.ReactivateConfigurationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReactivateConfiguration);
            Modify_ReactivateConfigurationApiCall(ref _callReactivateConfiguration);
            _callQueryConfigurationLicenseUsage = clientHelper.BuildApiCall<QueryConfigurationLicenseUsageRequest, QueryConfigurationLicenseUsageResponse>("QueryConfigurationLicenseUsage", grpcClient.QueryConfigurationLicenseUsageAsync, grpcClient.QueryConfigurationLicenseUsage, effectiveSettings.QueryConfigurationLicenseUsageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryConfigurationLicenseUsage);
            Modify_QueryConfigurationLicenseUsageApiCall(ref _callQueryConfigurationLicenseUsage);
            _callAggregateUsage = clientHelper.BuildApiCall<AggregateUsageRequest, AggregateUsageResponse>("AggregateUsage", grpcClient.AggregateUsageAsync, grpcClient.AggregateUsage, effectiveSettings.AggregateUsageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAggregateUsage);
            Modify_AggregateUsageApiCall(ref _callAggregateUsage);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>("ListProducts", grpcClient.ListProductsAsync, grpcClient.ListProducts, effectiveSettings.ListProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            _callGetProduct = clientHelper.BuildApiCall<GetProductRequest, Product>("GetProduct", grpcClient.GetProductAsync, grpcClient.GetProduct, effectiveSettings.GetProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProduct);
            Modify_GetProductApiCall(ref _callGetProduct);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConfigurationsApiCall(ref gaxgrpc::ApiCall<ListConfigurationsRequest, ListConfigurationsResponse> call);

        partial void Modify_GetConfigurationApiCall(ref gaxgrpc::ApiCall<GetConfigurationRequest, Configuration> call);

        partial void Modify_CreateConfigurationApiCall(ref gaxgrpc::ApiCall<CreateConfigurationRequest, lro::Operation> call);

        partial void Modify_UpdateConfigurationApiCall(ref gaxgrpc::ApiCall<UpdateConfigurationRequest, lro::Operation> call);

        partial void Modify_DeleteConfigurationApiCall(ref gaxgrpc::ApiCall<DeleteConfigurationRequest, lro::Operation> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_DeactivateConfigurationApiCall(ref gaxgrpc::ApiCall<DeactivateConfigurationRequest, lro::Operation> call);

        partial void Modify_ReactivateConfigurationApiCall(ref gaxgrpc::ApiCall<ReactivateConfigurationRequest, lro::Operation> call);

        partial void Modify_QueryConfigurationLicenseUsageApiCall(ref gaxgrpc::ApiCall<QueryConfigurationLicenseUsageRequest, QueryConfigurationLicenseUsageResponse> call);

        partial void Modify_AggregateUsageApiCall(ref gaxgrpc::ApiCall<AggregateUsageRequest, AggregateUsageResponse> call);

        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);

        partial void Modify_GetProductApiCall(ref gaxgrpc::ApiCall<GetProductRequest, Product> call);

        partial void OnConstruction(LicenseManager.LicenseManagerClient grpcClient, LicenseManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LicenseManager client</summary>
        public override LicenseManager.LicenseManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListConfigurationsRequest(ref ListConfigurationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConfigurationRequest(ref GetConfigurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConfigurationRequest(ref CreateConfigurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConfigurationRequest(ref UpdateConfigurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConfigurationRequest(ref DeleteConfigurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeactivateConfigurationRequest(ref DeactivateConfigurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReactivateConfigurationRequest(ref ReactivateConfigurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryConfigurationLicenseUsageRequest(ref QueryConfigurationLicenseUsageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregateUsageRequest(ref AggregateUsageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProductRequest(ref GetProductRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Configuration"/> resources.</returns>
        public override gax::PagedEnumerable<ListConfigurationsResponse, Configuration> ListConfigurations(ListConfigurationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConfigurationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConfigurationsRequest, ListConfigurationsResponse, Configuration>(_callListConfigurations, request, callSettings);
        }

        /// <summary>
        /// Lists Configurations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Configuration"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> ListConfigurationsAsync(ListConfigurationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConfigurationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConfigurationsRequest, ListConfigurationsResponse, Configuration>(_callListConfigurations, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Configuration GetConfiguration(GetConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigurationRequest(ref request, ref callSettings);
            return _callGetConfiguration.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Configuration> GetConfigurationAsync(GetConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigurationRequest(ref request, ref callSettings);
            return _callGetConfiguration.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConfiguration</c>.</summary>
        public override lro::OperationsClient CreateConfigurationOperationsClient { get; }

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Configuration, OperationMetadata> CreateConfiguration(CreateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(_callCreateConfiguration.Sync(request, callSettings), CreateConfigurationOperationsClient);
        }

        /// <summary>
        /// Creates a new Configuration in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Configuration, OperationMetadata>> CreateConfigurationAsync(CreateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(await _callCreateConfiguration.Async(request, callSettings).ConfigureAwait(false), CreateConfigurationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConfiguration</c>.</summary>
        public override lro::OperationsClient UpdateConfigurationOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Configuration, OperationMetadata> UpdateConfiguration(UpdateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(_callUpdateConfiguration.Sync(request, callSettings), UpdateConfigurationOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Configuration, OperationMetadata>> UpdateConfigurationAsync(UpdateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(await _callUpdateConfiguration.Async(request, callSettings).ConfigureAwait(false), UpdateConfigurationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConfiguration</c>.</summary>
        public override lro::OperationsClient DeleteConfigurationOperationsClient { get; }

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConfiguration(DeleteConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConfiguration.Sync(request, callSettings), DeleteConfigurationOperationsClient);
        }

        /// <summary>
        /// Deletes a single Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConfigurationAsync(DeleteConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConfiguration.Async(request, callSettings).ConfigureAwait(false), DeleteConfigurationOperationsClient);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeactivateConfiguration</c>.</summary>
        public override lro::OperationsClient DeactivateConfigurationOperationsClient { get; }

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Configuration, OperationMetadata> DeactivateConfiguration(DeactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeactivateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(_callDeactivateConfiguration.Sync(request, callSettings), DeactivateConfigurationOperationsClient);
        }

        /// <summary>
        /// Deactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Configuration, OperationMetadata>> DeactivateConfigurationAsync(DeactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeactivateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(await _callDeactivateConfiguration.Async(request, callSettings).ConfigureAwait(false), DeactivateConfigurationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReactivateConfiguration</c>.</summary>
        public override lro::OperationsClient ReactivateConfigurationOperationsClient { get; }

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Configuration, OperationMetadata> ReactivateConfiguration(ReactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReactivateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(_callReactivateConfiguration.Sync(request, callSettings), ReactivateConfigurationOperationsClient);
        }

        /// <summary>
        /// Reactivates the given configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Configuration, OperationMetadata>> ReactivateConfigurationAsync(ReactivateConfigurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReactivateConfigurationRequest(ref request, ref callSettings);
            return new lro::Operation<Configuration, OperationMetadata>(await _callReactivateConfiguration.Async(request, callSettings).ConfigureAwait(false), ReactivateConfigurationOperationsClient);
        }

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryConfigurationLicenseUsageResponse QueryConfigurationLicenseUsage(QueryConfigurationLicenseUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryConfigurationLicenseUsageRequest(ref request, ref callSettings);
            return _callQueryConfigurationLicenseUsage.Sync(request, callSettings);
        }

        /// <summary>
        /// License Usage information for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryConfigurationLicenseUsageResponse> QueryConfigurationLicenseUsageAsync(QueryConfigurationLicenseUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryConfigurationLicenseUsageRequest(ref request, ref callSettings);
            return _callQueryConfigurationLicenseUsage.Async(request, callSettings);
        }

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Usage"/> resources.</returns>
        public override gax::PagedEnumerable<AggregateUsageResponse, Usage> AggregateUsage(AggregateUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateUsageRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregateUsageRequest, AggregateUsageResponse, Usage>(_callAggregateUsage, request, callSettings);
        }

        /// <summary>
        /// Aggregates Usage per Instance for a Configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Usage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<AggregateUsageResponse, Usage> AggregateUsageAsync(AggregateUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateUsageRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregateUsageRequest, AggregateUsageResponse, Usage>(_callAggregateUsage, request, callSettings);
        }

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Lists Products in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Async(request, callSettings);
        }
    }

    public partial class ListConfigurationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class AggregateUsageRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConfigurationsResponse : gaxgrpc::IPageResponse<Configuration>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Configuration> GetEnumerator() => Configurations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class AggregateUsageResponse : gaxgrpc::IPageResponse<Usage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Usage> GetEnumerator() => Usages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class LicenseManager
    {
        public partial class LicenseManagerClient
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

    public static partial class LicenseManager
    {
        public partial class LicenseManagerClient
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
