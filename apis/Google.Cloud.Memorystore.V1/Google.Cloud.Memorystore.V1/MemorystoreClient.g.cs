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

namespace Google.Cloud.Memorystore.V1
{
    /// <summary>Settings for <see cref="MemorystoreClient"/> instances.</summary>
    public sealed partial class MemorystoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MemorystoreSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MemorystoreSettings"/>.</returns>
        public static MemorystoreSettings GetDefault() => new MemorystoreSettings();

        /// <summary>Constructs a new <see cref="MemorystoreSettings"/> object with default settings.</summary>
        public MemorystoreSettings()
        {
        }

        private MemorystoreSettings(MemorystoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            GetCertificateAuthoritySettings = existing.GetCertificateAuthoritySettings;
            RescheduleMaintenanceSettings = existing.RescheduleMaintenanceSettings;
            RescheduleMaintenanceOperationsSettings = existing.RescheduleMaintenanceOperationsSettings.Clone();
            ListBackupCollectionsSettings = existing.ListBackupCollectionsSettings;
            GetBackupCollectionSettings = existing.GetBackupCollectionSettings;
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            ExportBackupSettings = existing.ExportBackupSettings;
            ExportBackupOperationsSettings = existing.ExportBackupOperationsSettings.Clone();
            BackupInstanceSettings = existing.BackupInstanceSettings;
            BackupInstanceOperationsSettings = existing.BackupInstanceOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MemorystoreSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListInstances</c> and <c>MemorystoreClient.ListInstancesAsync</c>.
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
        /// <c>MemorystoreClient.GetInstance</c> and <c>MemorystoreClient.GetInstanceAsync</c>.
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
        /// <c>MemorystoreClient.CreateInstance</c> and <c>MemorystoreClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.CreateInstance</c> and
        /// <c>MemorystoreClient.CreateInstanceAsync</c>.
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
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.UpdateInstance</c> and <c>MemorystoreClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.UpdateInstance</c> and
        /// <c>MemorystoreClient.UpdateInstanceAsync</c>.
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
        public lro::OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.DeleteInstance</c> and <c>MemorystoreClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteInstance</c> and
        /// <c>MemorystoreClient.DeleteInstanceAsync</c>.
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
        public lro::OperationsSettings DeleteInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetCertificateAuthority</c> and <c>MemorystoreClient.GetCertificateAuthorityAsync</c>.
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
        public gaxgrpc::CallSettings GetCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.RescheduleMaintenance</c> and <c>MemorystoreClient.RescheduleMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RescheduleMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.RescheduleMaintenance</c> and
        /// <c>MemorystoreClient.RescheduleMaintenanceAsync</c>.
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
        public lro::OperationsSettings RescheduleMaintenanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListBackupCollections</c> and <c>MemorystoreClient.ListBackupCollectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupCollectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetBackupCollection</c> and <c>MemorystoreClient.GetBackupCollectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupCollectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListBackups</c> and <c>MemorystoreClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>MemorystoreClient.GetBackup</c>
        ///  and <c>MemorystoreClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.DeleteBackup</c> and <c>MemorystoreClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteBackup</c> and
        /// <c>MemorystoreClient.DeleteBackupAsync</c>.
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
        public lro::OperationsSettings DeleteBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ExportBackup</c> and <c>MemorystoreClient.ExportBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.ExportBackup</c> and
        /// <c>MemorystoreClient.ExportBackupAsync</c>.
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
        public lro::OperationsSettings ExportBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.BackupInstance</c> and <c>MemorystoreClient.BackupInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BackupInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.BackupInstance</c> and
        /// <c>MemorystoreClient.BackupInstanceAsync</c>.
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
        public lro::OperationsSettings BackupInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MemorystoreSettings"/> object.</returns>
        public MemorystoreSettings Clone() => new MemorystoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MemorystoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MemorystoreClientBuilder : gaxgrpc::ClientBuilderBase<MemorystoreClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MemorystoreSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MemorystoreClientBuilder() : base(MemorystoreClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MemorystoreClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MemorystoreClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MemorystoreClient Build()
        {
            MemorystoreClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MemorystoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MemorystoreClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MemorystoreClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MemorystoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MemorystoreClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MemorystoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MemorystoreClient.ChannelPool;
    }

    /// <summary>Memorystore client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class MemorystoreClient
    {
        /// <summary>
        /// The default endpoint for the Memorystore service, which is a host of "memorystore.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "memorystore.googleapis.com:443";

        /// <summary>The default Memorystore scopes.</summary>
        /// <remarks>
        /// The default Memorystore scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Memorystore.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MemorystoreClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MemorystoreClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MemorystoreClient"/>.</returns>
        public static stt::Task<MemorystoreClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MemorystoreClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MemorystoreClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MemorystoreClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MemorystoreClient"/>.</returns>
        public static MemorystoreClient Create() => new MemorystoreClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MemorystoreClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MemorystoreSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MemorystoreClient"/>.</returns>
        internal static MemorystoreClient Create(grpccore::CallInvoker callInvoker, MemorystoreSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Memorystore.MemorystoreClient grpcClient = new Memorystore.MemorystoreClient(callInvoker);
            return new MemorystoreClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Memorystore client</summary>
        public virtual Memorystore.MemorystoreClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

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
        /// Required. The parent to list instances from.
        /// Format: projects/{project}/locations/{location}
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
        /// Required. The parent to list instances from.
        /// Format: projects/{project}/locations/{location}
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
        /// Required. The parent to list instances from.
        /// Format: projects/{project}/locations/{location}
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
        /// Required. The parent to list instances from.
        /// Format: projects/{project}/locations/{location}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated on the instance. At least one
        /// field must be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                UpdateMask = updateMask,
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated on the instance. At least one
        /// field must be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                UpdateMask = updateMask,
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated on the instance. At least one
        /// field must be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public virtual lro::OperationsClient DeleteInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public virtual lro::OperationsClient RescheduleMaintenanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RescheduleMaintenance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceRescheduleMaintenance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RescheduleMaintenance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceRescheduleMaintenanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollections(request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollections(request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupCollection GetBackupCollection(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(GetBackupCollectionRequest request, st::CancellationToken cancellationToken) =>
            GetBackupCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupCollection GetBackupCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollection(new GetBackupCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollectionAsync(new GetBackupCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupCollection GetBackupCollection(BackupCollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollection(new GetBackupCollectionRequest
            {
                BackupCollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(BackupCollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollectionAsync(new GetBackupCollectionRequest
            {
                BackupCollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(BackupCollectionName name, st::CancellationToken cancellationToken) =>
            GetBackupCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(BackupCollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(BackupCollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public virtual lro::OperationsClient DeleteBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> ExportBackup(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> ExportBackupAsync(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> ExportBackupAsync(ExportBackupRequest request, st::CancellationToken cancellationToken) =>
            ExportBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportBackup</c>.</summary>
        public virtual lro::OperationsClient ExportBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> PollOnceExportBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> PollOnceExportBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportBackupOperationsClient, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> BackupInstance(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(BackupInstanceRequest request, st::CancellationToken cancellationToken) =>
            BackupInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BackupInstance</c>.</summary>
        public virtual lro::OperationsClient BackupInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BackupInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceBackupInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BackupInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BackupInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceBackupInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BackupInstanceOperationsClient, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> BackupInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstance(new BackupInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstanceAsync(new BackupInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            BackupInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> BackupInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstance(new BackupInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstanceAsync(new BackupInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            BackupInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Memorystore client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class MemorystoreClientImpl : MemorystoreClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<GetCertificateAuthorityRequest, CertificateAuthority> _callGetCertificateAuthority;

        private readonly gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> _callRescheduleMaintenance;

        private readonly gaxgrpc::ApiCall<ListBackupCollectionsRequest, ListBackupCollectionsResponse> _callListBackupCollections;

        private readonly gaxgrpc::ApiCall<GetBackupCollectionRequest, BackupCollection> _callGetBackupCollection;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<ExportBackupRequest, lro::Operation> _callExportBackup;

        private readonly gaxgrpc::ApiCall<BackupInstanceRequest, lro::Operation> _callBackupInstance;

        /// <summary>
        /// Constructs a client wrapper for the Memorystore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MemorystoreSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MemorystoreClientImpl(Memorystore.MemorystoreClient grpcClient, MemorystoreSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MemorystoreSettings effectiveSettings = settings ?? MemorystoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            RescheduleMaintenanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RescheduleMaintenanceOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            ExportBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportBackupOperationsSettings, logger);
            BackupInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BackupInstanceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callGetCertificateAuthority = clientHelper.BuildApiCall<GetCertificateAuthorityRequest, CertificateAuthority>("GetCertificateAuthority", grpcClient.GetCertificateAuthorityAsync, grpcClient.GetCertificateAuthority, effectiveSettings.GetCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateAuthority);
            Modify_GetCertificateAuthorityApiCall(ref _callGetCertificateAuthority);
            _callRescheduleMaintenance = clientHelper.BuildApiCall<RescheduleMaintenanceRequest, lro::Operation>("RescheduleMaintenance", grpcClient.RescheduleMaintenanceAsync, grpcClient.RescheduleMaintenance, effectiveSettings.RescheduleMaintenanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRescheduleMaintenance);
            Modify_RescheduleMaintenanceApiCall(ref _callRescheduleMaintenance);
            _callListBackupCollections = clientHelper.BuildApiCall<ListBackupCollectionsRequest, ListBackupCollectionsResponse>("ListBackupCollections", grpcClient.ListBackupCollectionsAsync, grpcClient.ListBackupCollections, effectiveSettings.ListBackupCollectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupCollections);
            Modify_ListBackupCollectionsApiCall(ref _callListBackupCollections);
            _callGetBackupCollection = clientHelper.BuildApiCall<GetBackupCollectionRequest, BackupCollection>("GetBackupCollection", grpcClient.GetBackupCollectionAsync, grpcClient.GetBackupCollection, effectiveSettings.GetBackupCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupCollection);
            Modify_GetBackupCollectionApiCall(ref _callGetBackupCollection);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, lro::Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callExportBackup = clientHelper.BuildApiCall<ExportBackupRequest, lro::Operation>("ExportBackup", grpcClient.ExportBackupAsync, grpcClient.ExportBackup, effectiveSettings.ExportBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportBackup);
            Modify_ExportBackupApiCall(ref _callExportBackup);
            _callBackupInstance = clientHelper.BuildApiCall<BackupInstanceRequest, lro::Operation>("BackupInstance", grpcClient.BackupInstanceAsync, grpcClient.BackupInstance, effectiveSettings.BackupInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBackupInstance);
            Modify_BackupInstanceApiCall(ref _callBackupInstance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_GetCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<GetCertificateAuthorityRequest, CertificateAuthority> call);

        partial void Modify_RescheduleMaintenanceApiCall(ref gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> call);

        partial void Modify_ListBackupCollectionsApiCall(ref gaxgrpc::ApiCall<ListBackupCollectionsRequest, ListBackupCollectionsResponse> call);

        partial void Modify_GetBackupCollectionApiCall(ref gaxgrpc::ApiCall<GetBackupCollectionRequest, BackupCollection> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_ExportBackupApiCall(ref gaxgrpc::ApiCall<ExportBackupRequest, lro::Operation> call);

        partial void Modify_BackupInstanceApiCall(ref gaxgrpc::ApiCall<BackupInstanceRequest, lro::Operation> call);

        partial void OnConstruction(Memorystore.MemorystoreClient grpcClient, MemorystoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Memorystore client</summary>
        public override Memorystore.MemorystoreClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateAuthorityRequest(ref GetCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RescheduleMaintenanceRequest(ref RescheduleMaintenanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupCollectionsRequest(ref ListBackupCollectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupCollectionRequest(ref GetBackupCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportBackupRequest(ref ExportBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BackupInstanceRequest(ref BackupInstanceRequest request, ref gaxgrpc::CallSettings settings);

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

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetCertificateAuthority.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetCertificateAuthority.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public override lro::OperationsClient RescheduleMaintenanceOperationsClient { get; }

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callRescheduleMaintenance.Sync(request, callSettings), RescheduleMaintenanceOperationsClient);
        }

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callRescheduleMaintenance.Async(request, callSettings).ConfigureAwait(false), RescheduleMaintenanceOperationsClient);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupCollectionsRequest, ListBackupCollectionsResponse, BackupCollection>(_callListBackupCollections, request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupCollectionsRequest, ListBackupCollectionsResponse, BackupCollection>(_callListBackupCollections, request, callSettings);
        }

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupCollection GetBackupCollection(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupCollectionRequest(ref request, ref callSettings);
            return _callGetBackupCollection.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupCollection> GetBackupCollectionAsync(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupCollectionRequest(ref request, ref callSettings);
            return _callGetBackupCollection.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public override lro::OperationsClient DeleteBackupOperationsClient { get; }

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackup.Sync(request, callSettings), DeleteBackupOperationsClient);
        }

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackup.Async(request, callSettings).ConfigureAwait(false), DeleteBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportBackup</c>.</summary>
        public override lro::OperationsClient ExportBackupOperationsClient { get; }

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, OperationMetadata> ExportBackup(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(_callExportBackup.Sync(request, callSettings), ExportBackupOperationsClient);
        }

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> ExportBackupAsync(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callExportBackup.Async(request, callSettings).ConfigureAwait(false), ExportBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BackupInstance</c>.</summary>
        public override lro::OperationsClient BackupInstanceOperationsClient { get; }

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> BackupInstance(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BackupInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callBackupInstance.Sync(request, callSettings), BackupInstanceOperationsClient);
        }

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BackupInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callBackupInstance.Async(request, callSettings).ConfigureAwait(false), BackupInstanceOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupCollectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupCollectionsResponse : gaxgrpc::IPageResponse<BackupCollection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupCollection> GetEnumerator() => BackupCollections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Memorystore
    {
        public partial class MemorystoreClient
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

    public static partial class Memorystore
    {
        public partial class MemorystoreClient
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
