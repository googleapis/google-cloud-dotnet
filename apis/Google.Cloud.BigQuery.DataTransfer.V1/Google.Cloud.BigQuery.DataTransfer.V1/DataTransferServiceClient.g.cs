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

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>Settings for <see cref="DataTransferServiceClient"/> instances.</summary>
    public sealed partial class DataTransferServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataTransferServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataTransferServiceSettings"/>.</returns>
        public static DataTransferServiceSettings GetDefault() => new DataTransferServiceSettings();

        /// <summary>Constructs a new <see cref="DataTransferServiceSettings"/> object with default settings.</summary>
        public DataTransferServiceSettings()
        {
        }

        private DataTransferServiceSettings(DataTransferServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDataSourceSettings = existing.GetDataSourceSettings;
            ListDataSourcesSettings = existing.ListDataSourcesSettings;
            CreateTransferConfigSettings = existing.CreateTransferConfigSettings;
            UpdateTransferConfigSettings = existing.UpdateTransferConfigSettings;
            DeleteTransferConfigSettings = existing.DeleteTransferConfigSettings;
            GetTransferConfigSettings = existing.GetTransferConfigSettings;
            ListTransferConfigsSettings = existing.ListTransferConfigsSettings;
            ScheduleTransferRunsSettings = existing.ScheduleTransferRunsSettings;
            StartManualTransferRunsSettings = existing.StartManualTransferRunsSettings;
            GetTransferRunSettings = existing.GetTransferRunSettings;
            DeleteTransferRunSettings = existing.DeleteTransferRunSettings;
            ListTransferRunsSettings = existing.ListTransferRunsSettings;
            ListTransferLogsSettings = existing.ListTransferLogsSettings;
            CheckValidCredsSettings = existing.CheckValidCredsSettings;
            EnrollDataSourcesSettings = existing.EnrollDataSourcesSettings;
            UnenrollDataSourcesSettings = existing.UnenrollDataSourcesSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataTransferServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetDataSource</c> and <c>DataTransferServiceClient.GetDataSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListDataSources</c> and <c>DataTransferServiceClient.ListDataSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataSourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CreateTransferConfig</c> and
        /// <c>DataTransferServiceClient.CreateTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.UpdateTransferConfig</c> and
        /// <c>DataTransferServiceClient.UpdateTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteTransferConfig</c> and
        /// <c>DataTransferServiceClient.DeleteTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTransferConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetTransferConfig</c> and <c>DataTransferServiceClient.GetTransferConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTransferConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferConfigs</c> and
        /// <c>DataTransferServiceClient.ListTransferConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ScheduleTransferRuns</c> and
        /// <c>DataTransferServiceClient.ScheduleTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ScheduleTransferRunsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.StartManualTransferRuns</c> and
        /// <c>DataTransferServiceClient.StartManualTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartManualTransferRunsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetTransferRun</c> and <c>DataTransferServiceClient.GetTransferRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTransferRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteTransferRun</c> and <c>DataTransferServiceClient.DeleteTransferRunAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTransferRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferRuns</c> and <c>DataTransferServiceClient.ListTransferRunsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferLogs</c> and <c>DataTransferServiceClient.ListTransferLogsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferLogsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CheckValidCreds</c> and <c>DataTransferServiceClient.CheckValidCredsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckValidCredsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.EnrollDataSources</c> and <c>DataTransferServiceClient.EnrollDataSourcesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnrollDataSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.UnenrollDataSources</c> and
        /// <c>DataTransferServiceClient.UnenrollDataSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UnenrollDataSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataTransferServiceSettings"/> object.</returns>
        public DataTransferServiceSettings Clone() => new DataTransferServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataTransferServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataTransferServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataTransferServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataTransferServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataTransferServiceClientBuilder() : base(DataTransferServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataTransferServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataTransferServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataTransferServiceClient Build()
        {
            DataTransferServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataTransferServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataTransferServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataTransferServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataTransferServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataTransferServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataTransferServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataTransferServiceClient.ChannelPool;
    }

    /// <summary>DataTransferService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This API allows users to manage their data transfers into BigQuery.
    /// </remarks>
    public abstract partial class DataTransferServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataTransferService service, which is a host of
        /// "bigquerydatatransfer.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigquerydatatransfer.googleapis.com:443";

        /// <summary>The default DataTransferService scopes.</summary>
        /// <remarks>
        /// The default DataTransferService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataTransferService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataTransferServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataTransferServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataTransferServiceClient"/>.</returns>
        public static stt::Task<DataTransferServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataTransferServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataTransferServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataTransferServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create() => new DataTransferServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataTransferServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        internal static DataTransferServiceClient Create(grpccore::CallInvoker callInvoker, DataTransferServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataTransferService.DataTransferServiceClient grpcClient = new DataTransferService.DataTransferServiceClient(callInvoker);
            return new DataTransferServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataTransferService client</summary>
        public virtual DataTransferService.DataTransferServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSource(new GetDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSourceAsync(new GetDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSource(new GetDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSourceAsync(new GetDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(DataSourceName name, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which data sources should be
        /// returned. Must be in the form: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which data sources should be
        /// returned. Must be in the form: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which data sources should be
        /// returned. Must be in the form: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which data sources should be
        /// returned. Must be in the form: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which data sources should be
        /// returned. Must be in the form: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which data sources should be
        /// returned. Must be in the form: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig CreateTransferConfig(CreateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(CreateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(CreateTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig CreateTransferConfig(string parent, TransferConfig transferConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransferConfig(new CreateTransferConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(string parent, TransferConfig transferConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransferConfigAsync(new CreateTransferConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(string parent, TransferConfig transferConfig, st::CancellationToken cancellationToken) =>
            CreateTransferConfigAsync(parent, transferConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig CreateTransferConfig(gagr::ProjectName parent, TransferConfig transferConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransferConfig(new CreateTransferConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(gagr::ProjectName parent, TransferConfig transferConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransferConfigAsync(new CreateTransferConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(gagr::ProjectName parent, TransferConfig transferConfig, st::CancellationToken cancellationToken) =>
            CreateTransferConfigAsync(parent, transferConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig CreateTransferConfig(gagr::LocationName parent, TransferConfig transferConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransferConfig(new CreateTransferConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(gagr::LocationName parent, TransferConfig transferConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransferConfigAsync(new CreateTransferConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id where the transfer configuration should
        /// be created. Must be in the format
        /// projects/{project_id}/locations/{location_id} or projects/{project_id}. If
        /// specified location and location of the destination bigquery dataset do not
        /// match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(gagr::LocationName parent, TransferConfig transferConfig, st::CancellationToken cancellationToken) =>
            CreateTransferConfigAsync(parent, transferConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig UpdateTransferConfig(UpdateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> UpdateTransferConfigAsync(UpdateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> UpdateTransferConfigAsync(UpdateTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="updateMask">
        /// Required. Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig UpdateTransferConfig(TransferConfig transferConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTransferConfig(new UpdateTransferConfigRequest
            {
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="updateMask">
        /// Required. Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> UpdateTransferConfigAsync(TransferConfig transferConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTransferConfigAsync(new UpdateTransferConfigRequest
            {
                TransferConfig = gax::GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="transferConfig">
        /// Required. Data transfer configuration to create.
        /// </param>
        /// <param name="updateMask">
        /// Required. Required list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> UpdateTransferConfigAsync(TransferConfig transferConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTransferConfigAsync(transferConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferConfig(DeleteTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferConfigAsync(DeleteTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferConfigAsync(DeleteTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferConfig(new DeleteTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferConfigAsync(new DeleteTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferConfig(TransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferConfig(new DeleteTransferConfigRequest
            {
                TransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferConfigAsync(TransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferConfigAsync(new DeleteTransferConfigRequest
            {
                TransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferConfigAsync(TransferConfigName name, st::CancellationToken cancellationToken) =>
            DeleteTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig GetTransferConfig(GetTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(GetTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(GetTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            GetTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig GetTransferConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferConfig(new GetTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferConfigAsync(new GetTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferConfig GetTransferConfig(TransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferConfig(new GetTransferConfigRequest
            {
                TransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(TransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferConfigAsync(new GetTransferConfigRequest
            {
                TransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(TransferConfigName name, st::CancellationToken cancellationToken) =>
            GetTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(ListTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(ListTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which transfer configs
        /// should be returned: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
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
            return ListTransferConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which transfer configs
        /// should be returned: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
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
            return ListTransferConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which transfer configs
        /// should be returned: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
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
            return ListTransferConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which transfer configs
        /// should be returned: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
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
            return ListTransferConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which transfer configs
        /// should be returned: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
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
            return ListTransferConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The BigQuery project id for which transfer configs
        /// should be returned: `projects/{project_id}` or
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
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
            return ListTransferConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ScheduleTransferRunsResponse ScheduleTransferRuns(ScheduleTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(ScheduleTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(ScheduleTransferRunsRequest request, st::CancellationToken cancellationToken) =>
            ScheduleTransferRunsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Required. Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// Required. End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ScheduleTransferRunsResponse ScheduleTransferRuns(string parent, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleTransferRuns(new ScheduleTransferRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Required. Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// Required. End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(string parent, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleTransferRunsAsync(new ScheduleTransferRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Required. Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// Required. End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(string parent, wkt::Timestamp startTime, wkt::Timestamp endTime, st::CancellationToken cancellationToken) =>
            ScheduleTransferRunsAsync(parent, startTime, endTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Required. Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// Required. End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual ScheduleTransferRunsResponse ScheduleTransferRuns(TransferConfigName parent, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleTransferRuns(new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Required. Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// Required. End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(TransferConfigName parent, wkt::Timestamp startTime, wkt::Timestamp endTime, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleTransferRunsAsync(new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                EndTime = gax::GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
            }, callSettings);

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Required. Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// Required. End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(TransferConfigName parent, wkt::Timestamp startTime, wkt::Timestamp endTime, st::CancellationToken cancellationToken) =>
            ScheduleTransferRunsAsync(parent, startTime, endTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartManualTransferRunsResponse StartManualTransferRuns(StartManualTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartManualTransferRunsResponse> StartManualTransferRunsAsync(StartManualTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartManualTransferRunsResponse> StartManualTransferRunsAsync(StartManualTransferRunsRequest request, st::CancellationToken cancellationToken) =>
            StartManualTransferRunsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferRun GetTransferRun(GetTransferRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(GetTransferRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(GetTransferRunRequest request, st::CancellationToken cancellationToken) =>
            GetTransferRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferRun GetTransferRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferRun(new GetTransferRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferRunAsync(new GetTransferRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetTransferRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferRun GetTransferRun(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferRun(new GetTransferRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransferRunAsync(new GetTransferRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(RunName name, st::CancellationToken cancellationToken) =>
            GetTransferRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferRun(DeleteTransferRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferRunAsync(DeleteTransferRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferRunAsync(DeleteTransferRunRequest request, st::CancellationToken cancellationToken) =>
            DeleteTransferRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferRun(new DeleteTransferRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferRunAsync(new DeleteTransferRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferRunAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTransferRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferRun(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferRun(new DeleteTransferRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferRunAsync(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransferRunAsync(new DeleteTransferRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// Required. The field will contain name of the resource requested, for
        /// example: `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferRunAsync(RunName name, st::CancellationToken cancellationToken) =>
            DeleteTransferRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(ListTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(ListTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of transfer configuration for which transfer runs should be
        /// retrieved. Format of transfer configuration resource name is:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
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
        /// <returns>A pageable sequence of <see cref="TransferRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferRunsRequest request = new ListTransferRunsRequest
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
            return ListTransferRuns(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of transfer configuration for which transfer runs should be
        /// retrieved. Format of transfer configuration resource name is:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferRunsRequest request = new ListTransferRunsRequest
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
            return ListTransferRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of transfer configuration for which transfer runs should be
        /// retrieved. Format of transfer configuration resource name is:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
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
        /// <returns>A pageable sequence of <see cref="TransferRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(TransferConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferRunsRequest request = new ListTransferRunsRequest
            {
                ParentAsTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTransferRuns(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of transfer configuration for which transfer runs should be
        /// retrieved. Format of transfer configuration resource name is:
        /// `projects/{project_id}/transferConfigs/{config_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(TransferConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferRunsRequest request = new ListTransferRunsRequest
            {
                ParentAsTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTransferRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferMessage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(ListTransferLogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(ListTransferLogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer run name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
        /// <returns>A pageable sequence of <see cref="TransferMessage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferLogsRequest request = new ListTransferLogsRequest
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
            return ListTransferLogs(request, callSettings);
        }

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer run name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferLogsRequest request = new ListTransferLogsRequest
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
            return ListTransferLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer run name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
        /// <returns>A pageable sequence of <see cref="TransferMessage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(RunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferLogsRequest request = new ListTransferLogsRequest
            {
                ParentAsRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTransferLogs(request, callSettings);
        }

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="parent">
        /// Required. Transfer run name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}` or
        /// `projects/{project_id}/locations/{location_id}/transferConfigs/{config_id}/runs/{run_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(RunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransferLogsRequest request = new ListTransferLogsRequest
            {
                ParentAsRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTransferLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckValidCredsResponse CheckValidCreds(CheckValidCredsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(CheckValidCredsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(CheckValidCredsRequest request, st::CancellationToken cancellationToken) =>
            CheckValidCredsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="name">
        /// Required. The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckValidCredsResponse CheckValidCreds(string name, gaxgrpc::CallSettings callSettings = null) =>
            CheckValidCreds(new CheckValidCredsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="name">
        /// Required. The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CheckValidCredsAsync(new CheckValidCredsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="name">
        /// Required. The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(string name, st::CancellationToken cancellationToken) =>
            CheckValidCredsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="name">
        /// Required. The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckValidCredsResponse CheckValidCreds(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            CheckValidCreds(new CheckValidCredsRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="name">
        /// Required. The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            CheckValidCredsAsync(new CheckValidCredsRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="name">
        /// Required. The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}` or
        /// `projects/{project_id}/locations/{location_id}/dataSources/{data_source_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(DataSourceName name, st::CancellationToken cancellationToken) =>
            CheckValidCredsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer
        /// configurations for these data sources. They will also appear in the
        /// ListDataSources RPC and as such, will appear in the
        /// [BigQuery UI](https://console.cloud.google.com/bigquery), and the documents
        /// can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and
        /// [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EnrollDataSources(EnrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer
        /// configurations for these data sources. They will also appear in the
        /// ListDataSources RPC and as such, will appear in the
        /// [BigQuery UI](https://console.cloud.google.com/bigquery), and the documents
        /// can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and
        /// [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnrollDataSourcesAsync(EnrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer
        /// configurations for these data sources. They will also appear in the
        /// ListDataSources RPC and as such, will appear in the
        /// [BigQuery UI](https://console.cloud.google.com/bigquery), and the documents
        /// can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and
        /// [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnrollDataSourcesAsync(EnrollDataSourcesRequest request, st::CancellationToken cancellationToken) =>
            EnrollDataSourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unenroll data sources in a user project. This allows users to remove
        /// transfer configurations for these data sources. They will no longer appear
        /// in the ListDataSources RPC and will also no longer appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery). Data transfers
        /// configurations of unenrolled data sources will not be scheduled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void UnenrollDataSources(UnenrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unenroll data sources in a user project. This allows users to remove
        /// transfer configurations for these data sources. They will no longer appear
        /// in the ListDataSources RPC and will also no longer appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery). Data transfers
        /// configurations of unenrolled data sources will not be scheduled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UnenrollDataSourcesAsync(UnenrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unenroll data sources in a user project. This allows users to remove
        /// transfer configurations for these data sources. They will no longer appear
        /// in the ListDataSources RPC and will also no longer appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery). Data transfers
        /// configurations of unenrolled data sources will not be scheduled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UnenrollDataSourcesAsync(UnenrollDataSourcesRequest request, st::CancellationToken cancellationToken) =>
            UnenrollDataSourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataTransferService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This API allows users to manage their data transfers into BigQuery.
    /// </remarks>
    public sealed partial class DataTransferServiceClientImpl : DataTransferServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> _callGetDataSource;

        private readonly gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> _callListDataSources;

        private readonly gaxgrpc::ApiCall<CreateTransferConfigRequest, TransferConfig> _callCreateTransferConfig;

        private readonly gaxgrpc::ApiCall<UpdateTransferConfigRequest, TransferConfig> _callUpdateTransferConfig;

        private readonly gaxgrpc::ApiCall<DeleteTransferConfigRequest, wkt::Empty> _callDeleteTransferConfig;

        private readonly gaxgrpc::ApiCall<GetTransferConfigRequest, TransferConfig> _callGetTransferConfig;

        private readonly gaxgrpc::ApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse> _callListTransferConfigs;

        private readonly gaxgrpc::ApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse> _callScheduleTransferRuns;

        private readonly gaxgrpc::ApiCall<StartManualTransferRunsRequest, StartManualTransferRunsResponse> _callStartManualTransferRuns;

        private readonly gaxgrpc::ApiCall<GetTransferRunRequest, TransferRun> _callGetTransferRun;

        private readonly gaxgrpc::ApiCall<DeleteTransferRunRequest, wkt::Empty> _callDeleteTransferRun;

        private readonly gaxgrpc::ApiCall<ListTransferRunsRequest, ListTransferRunsResponse> _callListTransferRuns;

        private readonly gaxgrpc::ApiCall<ListTransferLogsRequest, ListTransferLogsResponse> _callListTransferLogs;

        private readonly gaxgrpc::ApiCall<CheckValidCredsRequest, CheckValidCredsResponse> _callCheckValidCreds;

        private readonly gaxgrpc::ApiCall<EnrollDataSourcesRequest, wkt::Empty> _callEnrollDataSources;

        private readonly gaxgrpc::ApiCall<UnenrollDataSourcesRequest, wkt::Empty> _callUnenrollDataSources;

        /// <summary>
        /// Constructs a client wrapper for the DataTransferService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataTransferServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataTransferServiceClientImpl(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataTransferServiceSettings effectiveSettings = settings ?? DataTransferServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetDataSource = clientHelper.BuildApiCall<GetDataSourceRequest, DataSource>("GetDataSource", grpcClient.GetDataSourceAsync, grpcClient.GetDataSource, effectiveSettings.GetDataSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataSource);
            Modify_GetDataSourceApiCall(ref _callGetDataSource);
            _callListDataSources = clientHelper.BuildApiCall<ListDataSourcesRequest, ListDataSourcesResponse>("ListDataSources", grpcClient.ListDataSourcesAsync, grpcClient.ListDataSources, effectiveSettings.ListDataSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataSources);
            Modify_ListDataSourcesApiCall(ref _callListDataSources);
            _callCreateTransferConfig = clientHelper.BuildApiCall<CreateTransferConfigRequest, TransferConfig>("CreateTransferConfig", grpcClient.CreateTransferConfigAsync, grpcClient.CreateTransferConfig, effectiveSettings.CreateTransferConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTransferConfig);
            Modify_CreateTransferConfigApiCall(ref _callCreateTransferConfig);
            _callUpdateTransferConfig = clientHelper.BuildApiCall<UpdateTransferConfigRequest, TransferConfig>("UpdateTransferConfig", grpcClient.UpdateTransferConfigAsync, grpcClient.UpdateTransferConfig, effectiveSettings.UpdateTransferConfigSettings).WithGoogleRequestParam("transfer_config.name", request => request.TransferConfig?.Name);
            Modify_ApiCall(ref _callUpdateTransferConfig);
            Modify_UpdateTransferConfigApiCall(ref _callUpdateTransferConfig);
            _callDeleteTransferConfig = clientHelper.BuildApiCall<DeleteTransferConfigRequest, wkt::Empty>("DeleteTransferConfig", grpcClient.DeleteTransferConfigAsync, grpcClient.DeleteTransferConfig, effectiveSettings.DeleteTransferConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTransferConfig);
            Modify_DeleteTransferConfigApiCall(ref _callDeleteTransferConfig);
            _callGetTransferConfig = clientHelper.BuildApiCall<GetTransferConfigRequest, TransferConfig>("GetTransferConfig", grpcClient.GetTransferConfigAsync, grpcClient.GetTransferConfig, effectiveSettings.GetTransferConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTransferConfig);
            Modify_GetTransferConfigApiCall(ref _callGetTransferConfig);
            _callListTransferConfigs = clientHelper.BuildApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse>("ListTransferConfigs", grpcClient.ListTransferConfigsAsync, grpcClient.ListTransferConfigs, effectiveSettings.ListTransferConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferConfigs);
            Modify_ListTransferConfigsApiCall(ref _callListTransferConfigs);
#pragma warning disable CS0612
            _callScheduleTransferRuns = clientHelper.BuildApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>("ScheduleTransferRuns", grpcClient.ScheduleTransferRunsAsync, grpcClient.ScheduleTransferRuns, effectiveSettings.ScheduleTransferRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callScheduleTransferRuns);
            Modify_ScheduleTransferRunsApiCall(ref _callScheduleTransferRuns);
            _callStartManualTransferRuns = clientHelper.BuildApiCall<StartManualTransferRunsRequest, StartManualTransferRunsResponse>("StartManualTransferRuns", grpcClient.StartManualTransferRunsAsync, grpcClient.StartManualTransferRuns, effectiveSettings.StartManualTransferRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callStartManualTransferRuns);
            Modify_StartManualTransferRunsApiCall(ref _callStartManualTransferRuns);
            _callGetTransferRun = clientHelper.BuildApiCall<GetTransferRunRequest, TransferRun>("GetTransferRun", grpcClient.GetTransferRunAsync, grpcClient.GetTransferRun, effectiveSettings.GetTransferRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTransferRun);
            Modify_GetTransferRunApiCall(ref _callGetTransferRun);
            _callDeleteTransferRun = clientHelper.BuildApiCall<DeleteTransferRunRequest, wkt::Empty>("DeleteTransferRun", grpcClient.DeleteTransferRunAsync, grpcClient.DeleteTransferRun, effectiveSettings.DeleteTransferRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTransferRun);
            Modify_DeleteTransferRunApiCall(ref _callDeleteTransferRun);
            _callListTransferRuns = clientHelper.BuildApiCall<ListTransferRunsRequest, ListTransferRunsResponse>("ListTransferRuns", grpcClient.ListTransferRunsAsync, grpcClient.ListTransferRuns, effectiveSettings.ListTransferRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferRuns);
            Modify_ListTransferRunsApiCall(ref _callListTransferRuns);
            _callListTransferLogs = clientHelper.BuildApiCall<ListTransferLogsRequest, ListTransferLogsResponse>("ListTransferLogs", grpcClient.ListTransferLogsAsync, grpcClient.ListTransferLogs, effectiveSettings.ListTransferLogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferLogs);
            Modify_ListTransferLogsApiCall(ref _callListTransferLogs);
            _callCheckValidCreds = clientHelper.BuildApiCall<CheckValidCredsRequest, CheckValidCredsResponse>("CheckValidCreds", grpcClient.CheckValidCredsAsync, grpcClient.CheckValidCreds, effectiveSettings.CheckValidCredsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCheckValidCreds);
            Modify_CheckValidCredsApiCall(ref _callCheckValidCreds);
            _callEnrollDataSources = clientHelper.BuildApiCall<EnrollDataSourcesRequest, wkt::Empty>("EnrollDataSources", grpcClient.EnrollDataSourcesAsync, grpcClient.EnrollDataSources, effectiveSettings.EnrollDataSourcesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnrollDataSources);
            Modify_EnrollDataSourcesApiCall(ref _callEnrollDataSources);
            _callUnenrollDataSources = clientHelper.BuildApiCall<UnenrollDataSourcesRequest, wkt::Empty>("UnenrollDataSources", grpcClient.UnenrollDataSourcesAsync, grpcClient.UnenrollDataSources, effectiveSettings.UnenrollDataSourcesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUnenrollDataSources);
            Modify_UnenrollDataSourcesApiCall(ref _callUnenrollDataSources);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDataSourceApiCall(ref gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> call);

        partial void Modify_ListDataSourcesApiCall(ref gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> call);

        partial void Modify_CreateTransferConfigApiCall(ref gaxgrpc::ApiCall<CreateTransferConfigRequest, TransferConfig> call);

        partial void Modify_UpdateTransferConfigApiCall(ref gaxgrpc::ApiCall<UpdateTransferConfigRequest, TransferConfig> call);

        partial void Modify_DeleteTransferConfigApiCall(ref gaxgrpc::ApiCall<DeleteTransferConfigRequest, wkt::Empty> call);

        partial void Modify_GetTransferConfigApiCall(ref gaxgrpc::ApiCall<GetTransferConfigRequest, TransferConfig> call);

        partial void Modify_ListTransferConfigsApiCall(ref gaxgrpc::ApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse> call);

        partial void Modify_ScheduleTransferRunsApiCall(ref gaxgrpc::ApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse> call);

        partial void Modify_StartManualTransferRunsApiCall(ref gaxgrpc::ApiCall<StartManualTransferRunsRequest, StartManualTransferRunsResponse> call);

        partial void Modify_GetTransferRunApiCall(ref gaxgrpc::ApiCall<GetTransferRunRequest, TransferRun> call);

        partial void Modify_DeleteTransferRunApiCall(ref gaxgrpc::ApiCall<DeleteTransferRunRequest, wkt::Empty> call);

        partial void Modify_ListTransferRunsApiCall(ref gaxgrpc::ApiCall<ListTransferRunsRequest, ListTransferRunsResponse> call);

        partial void Modify_ListTransferLogsApiCall(ref gaxgrpc::ApiCall<ListTransferLogsRequest, ListTransferLogsResponse> call);

        partial void Modify_CheckValidCredsApiCall(ref gaxgrpc::ApiCall<CheckValidCredsRequest, CheckValidCredsResponse> call);

        partial void Modify_EnrollDataSourcesApiCall(ref gaxgrpc::ApiCall<EnrollDataSourcesRequest, wkt::Empty> call);

        partial void Modify_UnenrollDataSourcesApiCall(ref gaxgrpc::ApiCall<UnenrollDataSourcesRequest, wkt::Empty> call);

        partial void OnConstruction(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataTransferService client</summary>
        public override DataTransferService.DataTransferServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetDataSourceRequest(ref GetDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataSourcesRequest(ref ListDataSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTransferConfigRequest(ref CreateTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTransferConfigRequest(ref UpdateTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTransferConfigRequest(ref DeleteTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTransferConfigRequest(ref GetTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransferConfigsRequest(ref ListTransferConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ScheduleTransferRunsRequest(ref ScheduleTransferRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartManualTransferRunsRequest(ref StartManualTransferRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTransferRunRequest(ref GetTransferRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTransferRunRequest(ref DeleteTransferRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransferRunsRequest(ref ListTransferRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransferLogsRequest(ref ListTransferLogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckValidCredsRequest(ref CheckValidCredsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnrollDataSourcesRequest(ref EnrollDataSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnenrollDataSourcesRequest(ref UnenrollDataSourcesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSource GetDataSource(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferConfig CreateTransferConfig(CreateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransferConfigRequest(ref request, ref callSettings);
            return _callCreateTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferConfig> CreateTransferConfigAsync(CreateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransferConfigRequest(ref request, ref callSettings);
            return _callCreateTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferConfig UpdateTransferConfig(UpdateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferConfigRequest(ref request, ref callSettings);
            return _callUpdateTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferConfig> UpdateTransferConfigAsync(UpdateTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferConfigRequest(ref request, ref callSettings);
            return _callUpdateTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTransferConfig(DeleteTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferConfigRequest(ref request, ref callSettings);
            _callDeleteTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data transfer configuration, including any associated transfer
        /// runs and logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTransferConfigAsync(DeleteTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferConfigRequest(ref request, ref callSettings);
            return _callDeleteTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferConfig GetTransferConfig(GetTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferConfigRequest(ref request, ref callSettings);
            return _callGetTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferConfig> GetTransferConfigAsync(GetTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferConfigRequest(ref request, ref callSettings);
            return _callGetTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(ListTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransferConfigsRequest, ListTransferConfigsResponse, TransferConfig>(_callListTransferConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns information about all transfer configs owned by a project in the
        /// specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(ListTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransferConfigsRequest, ListTransferConfigsResponse, TransferConfig>(_callListTransferConfigs, request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override ScheduleTransferRunsResponse ScheduleTransferRuns(ScheduleTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleTransferRunsRequest(ref request, ref callSettings);
            return _callScheduleTransferRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(ScheduleTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleTransferRunsRequest(ref request, ref callSettings);
            return _callScheduleTransferRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartManualTransferRunsResponse StartManualTransferRuns(StartManualTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartManualTransferRunsRequest(ref request, ref callSettings);
            return _callStartManualTransferRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartManualTransferRunsResponse> StartManualTransferRunsAsync(StartManualTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartManualTransferRunsRequest(ref request, ref callSettings);
            return _callStartManualTransferRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferRun GetTransferRun(GetTransferRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferRunRequest(ref request, ref callSettings);
            return _callGetTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferRun> GetTransferRunAsync(GetTransferRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferRunRequest(ref request, ref callSettings);
            return _callGetTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTransferRun(DeleteTransferRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferRunRequest(ref request, ref callSettings);
            _callDeleteTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTransferRunAsync(DeleteTransferRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferRunRequest(ref request, ref callSettings);
            return _callDeleteTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(ListTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransferRunsRequest, ListTransferRunsResponse, TransferRun>(_callListTransferRuns, request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed transfer runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(ListTransferRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransferRunsRequest, ListTransferRunsResponse, TransferRun>(_callListTransferRuns, request, callSettings);
        }

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferMessage"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(ListTransferLogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferLogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransferLogsRequest, ListTransferLogsResponse, TransferMessage>(_callListTransferLogs, request, callSettings);
        }

        /// <summary>
        /// Returns log messages for the transfer run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(ListTransferLogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferLogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransferLogsRequest, ListTransferLogsResponse, TransferMessage>(_callListTransferLogs, request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckValidCredsResponse CheckValidCreds(CheckValidCredsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckValidCredsRequest(ref request, ref callSettings);
            return _callCheckValidCreds.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(CheckValidCredsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckValidCredsRequest(ref request, ref callSettings);
            return _callCheckValidCreds.Async(request, callSettings);
        }

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer
        /// configurations for these data sources. They will also appear in the
        /// ListDataSources RPC and as such, will appear in the
        /// [BigQuery UI](https://console.cloud.google.com/bigquery), and the documents
        /// can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and
        /// [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void EnrollDataSources(EnrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnrollDataSourcesRequest(ref request, ref callSettings);
            _callEnrollDataSources.Sync(request, callSettings);
        }

        /// <summary>
        /// Enroll data sources in a user project. This allows users to create transfer
        /// configurations for these data sources. They will also appear in the
        /// ListDataSources RPC and as such, will appear in the
        /// [BigQuery UI](https://console.cloud.google.com/bigquery), and the documents
        /// can be found in the public guide for
        /// [BigQuery Web UI](https://cloud.google.com/bigquery/bigquery-web-ui) and
        /// [Data Transfer
        /// Service](https://cloud.google.com/bigquery/docs/working-with-transfers).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task EnrollDataSourcesAsync(EnrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnrollDataSourcesRequest(ref request, ref callSettings);
            return _callEnrollDataSources.Async(request, callSettings);
        }

        /// <summary>
        /// Unenroll data sources in a user project. This allows users to remove
        /// transfer configurations for these data sources. They will no longer appear
        /// in the ListDataSources RPC and will also no longer appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery). Data transfers
        /// configurations of unenrolled data sources will not be scheduled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void UnenrollDataSources(UnenrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnenrollDataSourcesRequest(ref request, ref callSettings);
            _callUnenrollDataSources.Sync(request, callSettings);
        }

        /// <summary>
        /// Unenroll data sources in a user project. This allows users to remove
        /// transfer configurations for these data sources. They will no longer appear
        /// in the ListDataSources RPC and will also no longer appear in the [BigQuery
        /// UI](https://console.cloud.google.com/bigquery). Data transfers
        /// configurations of unenrolled data sources will not be scheduled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task UnenrollDataSourcesAsync(UnenrollDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnenrollDataSourcesRequest(ref request, ref callSettings);
            return _callUnenrollDataSources.Async(request, callSettings);
        }
    }

    public partial class ListDataSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransferConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransferRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransferLogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataSourcesResponse : gaxgrpc::IPageResponse<DataSource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataSource> GetEnumerator() => DataSources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferConfigsResponse : gaxgrpc::IPageResponse<TransferConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransferConfig> GetEnumerator() => TransferConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferRunsResponse : gaxgrpc::IPageResponse<TransferRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransferRun> GetEnumerator() => TransferRuns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferLogsResponse : gaxgrpc::IPageResponse<TransferMessage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransferMessage> GetEnumerator() => TransferMessages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataTransferService
    {
        public partial class DataTransferServiceClient
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
