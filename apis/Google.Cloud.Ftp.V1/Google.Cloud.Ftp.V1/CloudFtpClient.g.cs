// Copyright 2026 Google LLC
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

namespace Google.Cloud.Ftp.V1
{
    /// <summary>Settings for <see cref="CloudFtpClient"/> instances.</summary>
    public sealed partial class CloudFtpSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudFtpSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudFtpSettings"/>.</returns>
        public static CloudFtpSettings GetDefault() => new CloudFtpSettings();

        /// <summary>Constructs a new <see cref="CloudFtpSettings"/> object with default settings.</summary>
        public CloudFtpSettings()
        {
        }

        private CloudFtpSettings(CloudFtpSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServersSettings = existing.ListServersSettings;
            GetServerSettings = existing.GetServerSettings;
            CreateServerSettings = existing.CreateServerSettings;
            CreateServerOperationsSettings = existing.CreateServerOperationsSettings.Clone();
            UpdateServerSettings = existing.UpdateServerSettings;
            UpdateServerOperationsSettings = existing.UpdateServerOperationsSettings.Clone();
            DeleteServerSettings = existing.DeleteServerSettings;
            DeleteServerOperationsSettings = existing.DeleteServerOperationsSettings.Clone();
            ListUsersSettings = existing.ListUsersSettings;
            GetUserSettings = existing.GetUserSettings;
            CreateUserSettings = existing.CreateUserSettings;
            CreateUserOperationsSettings = existing.CreateUserOperationsSettings.Clone();
            UpdateUserSettings = existing.UpdateUserSettings;
            UpdateUserOperationsSettings = existing.UpdateUserOperationsSettings.Clone();
            DeleteUserSettings = existing.DeleteUserSettings;
            DeleteUserOperationsSettings = existing.DeleteUserOperationsSettings.Clone();
            StartServerSettings = existing.StartServerSettings;
            StartServerOperationsSettings = existing.StartServerOperationsSettings.Clone();
            StopServerSettings = existing.StopServerSettings;
            StopServerOperationsSettings = existing.StopServerOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudFtpSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.ListServers</c>
        ///  and <c>CloudFtpClient.ListServersAsync</c>.
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
        public gaxgrpc::CallSettings ListServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.GetServer</c>
        ///  and <c>CloudFtpClient.GetServerAsync</c>.
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
        public gaxgrpc::CallSettings GetServerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.CreateServer</c>
        ///  and <c>CloudFtpClient.CreateServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.CreateServer</c> and
        /// <c>CloudFtpClient.CreateServerAsync</c>.
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
        public lro::OperationsSettings CreateServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.UpdateServer</c>
        ///  and <c>CloudFtpClient.UpdateServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.UpdateServer</c> and
        /// <c>CloudFtpClient.UpdateServerAsync</c>.
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
        public lro::OperationsSettings UpdateServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.DeleteServer</c>
        ///  and <c>CloudFtpClient.DeleteServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.DeleteServer</c> and
        /// <c>CloudFtpClient.DeleteServerAsync</c>.
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
        public lro::OperationsSettings DeleteServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.ListUsers</c>
        ///  and <c>CloudFtpClient.ListUsersAsync</c>.
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
        public gaxgrpc::CallSettings ListUsersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.GetUser</c>
        /// and <c>CloudFtpClient.GetUserAsync</c>.
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
        public gaxgrpc::CallSettings GetUserSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.CreateUser</c>
        ///  and <c>CloudFtpClient.CreateUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.CreateUser</c> and
        /// <c>CloudFtpClient.CreateUserAsync</c>.
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
        public lro::OperationsSettings CreateUserOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.UpdateUser</c>
        ///  and <c>CloudFtpClient.UpdateUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.UpdateUser</c> and
        /// <c>CloudFtpClient.UpdateUserAsync</c>.
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
        public lro::OperationsSettings UpdateUserOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.DeleteUser</c>
        ///  and <c>CloudFtpClient.DeleteUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.DeleteUser</c> and
        /// <c>CloudFtpClient.DeleteUserAsync</c>.
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
        public lro::OperationsSettings DeleteUserOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.StartServer</c>
        ///  and <c>CloudFtpClient.StartServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.StartServer</c> and
        /// <c>CloudFtpClient.StartServerAsync</c>.
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
        public lro::OperationsSettings StartServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudFtpClient.StopServer</c>
        ///  and <c>CloudFtpClient.StopServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFtpClient.StopServer</c> and
        /// <c>CloudFtpClient.StopServerAsync</c>.
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
        public lro::OperationsSettings StopServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudFtpSettings"/> object.</returns>
        public CloudFtpSettings Clone() => new CloudFtpSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudFtpClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudFtpClientBuilder : gaxgrpc::ClientBuilderBase<CloudFtpClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudFtpSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudFtpClientBuilder() : base(CloudFtpClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudFtpClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudFtpClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudFtpClient Build()
        {
            CloudFtpClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudFtpClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudFtpClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudFtpClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudFtpClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudFtpClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudFtpClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudFtpClient.ChannelPool;
    }

    /// <summary>CloudFtp client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class CloudFtpClient
    {
        /// <summary>
        /// The default endpoint for the CloudFtp service, which is a host of "ftp.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ftp.googleapis.com:443";

        /// <summary>The default CloudFtp scopes.</summary>
        /// <remarks>
        /// The default CloudFtp scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudFtp.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudFtpClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="CloudFtpClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudFtpClient"/>.</returns>
        public static stt::Task<CloudFtpClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudFtpClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudFtpClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="CloudFtpClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudFtpClient"/>.</returns>
        public static CloudFtpClient Create() => new CloudFtpClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudFtpClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudFtpSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudFtpClient"/>.</returns>
        internal static CloudFtpClient Create(grpccore::CallInvoker callInvoker, CloudFtpSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudFtp.CloudFtpClient grpcClient = new CloudFtp.CloudFtpClient(callInvoker);
            return new CloudFtpClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudFtp client</summary>
        public virtual CloudFtp.CloudFtpClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Server"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServersResponse, Server> ListServers(ListServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Server"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServersResponse, Server> ListServersAsync(ListServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServersRequest
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
        /// <returns>A pageable sequence of <see cref="Server"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServersResponse, Server> ListServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServersRequest request = new ListServersRequest
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
            return ListServers(request, callSettings);
        }

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Server"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServersResponse, Server> ListServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServersRequest request = new ListServersRequest
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
            return ListServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServersRequest
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
        /// <returns>A pageable sequence of <see cref="Server"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServersResponse, Server> ListServers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServersRequest request = new ListServersRequest
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
            return ListServers(request, callSettings);
        }

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Server"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServersResponse, Server> ListServersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServersRequest request = new ListServersRequest
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
            return ListServersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Server GetServer(GetServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Server> GetServerAsync(GetServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Server> GetServerAsync(GetServerRequest request, st::CancellationToken cancellationToken) =>
            GetServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Server GetServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServer(new GetServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Server> GetServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServerAsync(new GetServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Server> GetServerAsync(string name, st::CancellationToken cancellationToken) =>
            GetServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Server GetServer(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServer(new GetServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Server> GetServerAsync(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServerAsync(new GetServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Server> GetServerAsync(ServerName name, st::CancellationToken cancellationToken) =>
            GetServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> CreateServer(CreateServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(CreateServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(CreateServerRequest request, st::CancellationToken cancellationToken) =>
            CreateServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServer</c>.</summary>
        public virtual lro::OperationsClient CreateServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Server, OperationMetadata> PollOnceCreateServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> PollOnceCreateServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServerOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="server">
        /// Required. The resource being created
        /// </param>
        /// <param name="serverId">
        /// Required. A unique ID for the server. Must start with a lowercase letter,
        /// and end with a lowercase letter or number. Can contain lowercase letters,
        /// numbers, and hyphens. Maximum length is 30 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> CreateServer(string parent, Server server, string serverId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServer(new CreateServerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)),
                Server = gax::GaxPreconditions.CheckNotNull(server, nameof(server)),
            }, callSettings);

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="server">
        /// Required. The resource being created
        /// </param>
        /// <param name="serverId">
        /// Required. A unique ID for the server. Must start with a lowercase letter,
        /// and end with a lowercase letter or number. Can contain lowercase letters,
        /// numbers, and hyphens. Maximum length is 30 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(string parent, Server server, string serverId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServerAsync(new CreateServerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)),
                Server = gax::GaxPreconditions.CheckNotNull(server, nameof(server)),
            }, callSettings);

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="server">
        /// Required. The resource being created
        /// </param>
        /// <param name="serverId">
        /// Required. A unique ID for the server. Must start with a lowercase letter,
        /// and end with a lowercase letter or number. Can contain lowercase letters,
        /// numbers, and hyphens. Maximum length is 30 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(string parent, Server server, string serverId, st::CancellationToken cancellationToken) =>
            CreateServerAsync(parent, server, serverId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="server">
        /// Required. The resource being created
        /// </param>
        /// <param name="serverId">
        /// Required. A unique ID for the server. Must start with a lowercase letter,
        /// and end with a lowercase letter or number. Can contain lowercase letters,
        /// numbers, and hyphens. Maximum length is 30 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> CreateServer(gagr::LocationName parent, Server server, string serverId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServer(new CreateServerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)),
                Server = gax::GaxPreconditions.CheckNotNull(server, nameof(server)),
            }, callSettings);

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="server">
        /// Required. The resource being created
        /// </param>
        /// <param name="serverId">
        /// Required. A unique ID for the server. Must start with a lowercase letter,
        /// and end with a lowercase letter or number. Can contain lowercase letters,
        /// numbers, and hyphens. Maximum length is 30 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(gagr::LocationName parent, Server server, string serverId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServerAsync(new CreateServerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)),
                Server = gax::GaxPreconditions.CheckNotNull(server, nameof(server)),
            }, callSettings);

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="server">
        /// Required. The resource being created
        /// </param>
        /// <param name="serverId">
        /// Required. A unique ID for the server. Must start with a lowercase letter,
        /// and end with a lowercase letter or number. Can contain lowercase letters,
        /// numbers, and hyphens. Maximum length is 30 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(gagr::LocationName parent, Server server, string serverId, st::CancellationToken cancellationToken) =>
            CreateServerAsync(parent, server, serverId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> UpdateServer(UpdateServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> UpdateServerAsync(UpdateServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> UpdateServerAsync(UpdateServerRequest request, st::CancellationToken cancellationToken) =>
            UpdateServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServer</c>.</summary>
        public virtual lro::OperationsClient UpdateServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Server, OperationMetadata> PollOnceUpdateServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> PollOnceUpdateServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServerOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="server">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Server resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> UpdateServer(Server server, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServer(new UpdateServerRequest
            {
                UpdateMask = updateMask,
                Server = gax::GaxPreconditions.CheckNotNull(server, nameof(server)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="server">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Server resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> UpdateServerAsync(Server server, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServerAsync(new UpdateServerRequest
            {
                UpdateMask = updateMask,
                Server = gax::GaxPreconditions.CheckNotNull(server, nameof(server)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="server">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Server resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> UpdateServerAsync(Server server, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServerAsync(server, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServer(DeleteServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(DeleteServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(DeleteServerRequest request, st::CancellationToken cancellationToken) =>
            DeleteServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServer</c>.</summary>
        public virtual lro::OperationsClient DeleteServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServerOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServer(new DeleteServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServerAsync(new DeleteServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServer(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServer(new DeleteServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServerAsync(new DeleteServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(ServerName name, st::CancellationToken cancellationToken) =>
            DeleteServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
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
            return ListUsers(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
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
            return ListUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ServerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsServerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsers(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ServerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsServerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, st::CancellationToken cancellationToken) =>
            GetUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<User, OperationMetadata> CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(CreateUserRequest request, st::CancellationToken cancellationToken) =>
            CreateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateUser</c>.</summary>
        public virtual lro::OperationsClient CreateUserOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<User, OperationMetadata> PollOnceCreateUser(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<User, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateUserOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> PollOnceCreateUserAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<User, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateUserOperationsClient, callSettings);

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. A unique user ID for the SFTP user. The user ID must start with a
        /// lowercase letter and can include lowercase letters, numbers, or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<User, OperationMetadata> CreateUser(string parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. A unique user ID for the SFTP user. The user ID must start with a
        /// lowercase letter and can include lowercase letters, numbers, or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(string parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. A unique user ID for the SFTP user. The user ID must start with a
        /// lowercase letter and can include lowercase letters, numbers, or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(string parent, User user, string userId, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, userId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. A unique user ID for the SFTP user. The user ID must start with a
        /// lowercase letter and can include lowercase letters, numbers, or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<User, OperationMetadata> CreateUser(ServerName parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                ParentAsServerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. A unique user ID for the SFTP user. The user ID must start with a
        /// lowercase letter and can include lowercase letters, numbers, or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(ServerName parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                ParentAsServerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. A unique user ID for the SFTP user. The user ID must start with a
        /// lowercase letter and can include lowercase letters, numbers, or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(ServerName parent, User user, string userId, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, userId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<User, OperationMetadata> UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> UpdateUserAsync(UpdateUserRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateUser</c>.</summary>
        public virtual lro::OperationsClient UpdateUserOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<User, OperationMetadata> PollOnceUpdateUser(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<User, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateUserOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> PollOnceUpdateUserAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<User, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateUserOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="user">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// User resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<User, OperationMetadata> UpdateUser(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUser(new UpdateUserRequest
            {
                UpdateMask = updateMask,
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="user">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// User resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> UpdateUserAsync(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserAsync(new UpdateUserRequest
            {
                UpdateMask = updateMask,
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="user">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// User resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<User, OperationMetadata>> UpdateUserAsync(User user, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(user, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUser(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(DeleteUserRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteUser</c>.</summary>
        public virtual lro::OperationsClient DeleteUserOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteUser(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteUserOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteUserAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteUserOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUser(new DeleteUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserAsync(new DeleteUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUser(new DeleteUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserAsync(new DeleteUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> StartServer(StartServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(StartServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(StartServerRequest request, st::CancellationToken cancellationToken) =>
            StartServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartServer</c>.</summary>
        public virtual lro::OperationsClient StartServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Server, OperationMetadata> PollOnceStartServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> PollOnceStartServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartServerOperationsClient, callSettings);

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> StartServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartServer(new StartServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartServerAsync(new StartServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(string name, st::CancellationToken cancellationToken) =>
            StartServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> StartServer(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            StartServer(new StartServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            StartServerAsync(new StartServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(ServerName name, st::CancellationToken cancellationToken) =>
            StartServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> StopServer(StopServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(StopServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(StopServerRequest request, st::CancellationToken cancellationToken) =>
            StopServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopServer</c>.</summary>
        public virtual lro::OperationsClient StopServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Server, OperationMetadata> PollOnceStopServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> PollOnceStopServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Server, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopServerOperationsClient, callSettings);

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> StopServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopServer(new StopServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopServerAsync(new StopServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(string name, st::CancellationToken cancellationToken) =>
            StopServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Server, OperationMetadata> StopServer(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            StopServer(new StopServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(ServerName name, gaxgrpc::CallSettings callSettings = null) =>
            StopServerAsync(new StopServerRequest
            {
                ServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format: `projects/{project}/locations/{location}/servers/{server}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(ServerName name, st::CancellationToken cancellationToken) =>
            StopServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudFtp client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class CloudFtpClientImpl : CloudFtpClient
    {
        private readonly gaxgrpc::ApiCall<ListServersRequest, ListServersResponse> _callListServers;

        private readonly gaxgrpc::ApiCall<GetServerRequest, Server> _callGetServer;

        private readonly gaxgrpc::ApiCall<CreateServerRequest, lro::Operation> _callCreateServer;

        private readonly gaxgrpc::ApiCall<UpdateServerRequest, lro::Operation> _callUpdateServer;

        private readonly gaxgrpc::ApiCall<DeleteServerRequest, lro::Operation> _callDeleteServer;

        private readonly gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> _callListUsers;

        private readonly gaxgrpc::ApiCall<GetUserRequest, User> _callGetUser;

        private readonly gaxgrpc::ApiCall<CreateUserRequest, lro::Operation> _callCreateUser;

        private readonly gaxgrpc::ApiCall<UpdateUserRequest, lro::Operation> _callUpdateUser;

        private readonly gaxgrpc::ApiCall<DeleteUserRequest, lro::Operation> _callDeleteUser;

        private readonly gaxgrpc::ApiCall<StartServerRequest, lro::Operation> _callStartServer;

        private readonly gaxgrpc::ApiCall<StopServerRequest, lro::Operation> _callStopServer;

        /// <summary>
        /// Constructs a client wrapper for the CloudFtp service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudFtpSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudFtpClientImpl(CloudFtp.CloudFtpClient grpcClient, CloudFtpSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudFtpSettings effectiveSettings = settings ?? CloudFtpSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServerOperationsSettings, logger);
            UpdateServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServerOperationsSettings, logger);
            DeleteServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServerOperationsSettings, logger);
            CreateUserOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateUserOperationsSettings, logger);
            UpdateUserOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateUserOperationsSettings, logger);
            DeleteUserOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteUserOperationsSettings, logger);
            StartServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartServerOperationsSettings, logger);
            StopServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopServerOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListServers = clientHelper.BuildApiCall<ListServersRequest, ListServersResponse>("ListServers", grpcClient.ListServersAsync, grpcClient.ListServers, effectiveSettings.ListServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServers);
            Modify_ListServersApiCall(ref _callListServers);
            _callGetServer = clientHelper.BuildApiCall<GetServerRequest, Server>("GetServer", grpcClient.GetServerAsync, grpcClient.GetServer, effectiveSettings.GetServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServer);
            Modify_GetServerApiCall(ref _callGetServer);
            _callCreateServer = clientHelper.BuildApiCall<CreateServerRequest, lro::Operation>("CreateServer", grpcClient.CreateServerAsync, grpcClient.CreateServer, effectiveSettings.CreateServerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServer);
            Modify_CreateServerApiCall(ref _callCreateServer);
            _callUpdateServer = clientHelper.BuildApiCall<UpdateServerRequest, lro::Operation>("UpdateServer", grpcClient.UpdateServerAsync, grpcClient.UpdateServer, effectiveSettings.UpdateServerSettings).WithGoogleRequestParam("server.name", request => request.Server?.Name);
            Modify_ApiCall(ref _callUpdateServer);
            Modify_UpdateServerApiCall(ref _callUpdateServer);
            _callDeleteServer = clientHelper.BuildApiCall<DeleteServerRequest, lro::Operation>("DeleteServer", grpcClient.DeleteServerAsync, grpcClient.DeleteServer, effectiveSettings.DeleteServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServer);
            Modify_DeleteServerApiCall(ref _callDeleteServer);
            _callListUsers = clientHelper.BuildApiCall<ListUsersRequest, ListUsersResponse>("ListUsers", grpcClient.ListUsersAsync, grpcClient.ListUsers, effectiveSettings.ListUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUsers);
            Modify_ListUsersApiCall(ref _callListUsers);
            _callGetUser = clientHelper.BuildApiCall<GetUserRequest, User>("GetUser", grpcClient.GetUserAsync, grpcClient.GetUser, effectiveSettings.GetUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUser);
            Modify_GetUserApiCall(ref _callGetUser);
            _callCreateUser = clientHelper.BuildApiCall<CreateUserRequest, lro::Operation>("CreateUser", grpcClient.CreateUserAsync, grpcClient.CreateUser, effectiveSettings.CreateUserSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUser);
            Modify_CreateUserApiCall(ref _callCreateUser);
            _callUpdateUser = clientHelper.BuildApiCall<UpdateUserRequest, lro::Operation>("UpdateUser", grpcClient.UpdateUserAsync, grpcClient.UpdateUser, effectiveSettings.UpdateUserSettings).WithGoogleRequestParam("user.name", request => request.User?.Name);
            Modify_ApiCall(ref _callUpdateUser);
            Modify_UpdateUserApiCall(ref _callUpdateUser);
            _callDeleteUser = clientHelper.BuildApiCall<DeleteUserRequest, lro::Operation>("DeleteUser", grpcClient.DeleteUserAsync, grpcClient.DeleteUser, effectiveSettings.DeleteUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUser);
            Modify_DeleteUserApiCall(ref _callDeleteUser);
            _callStartServer = clientHelper.BuildApiCall<StartServerRequest, lro::Operation>("StartServer", grpcClient.StartServerAsync, grpcClient.StartServer, effectiveSettings.StartServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartServer);
            Modify_StartServerApiCall(ref _callStartServer);
            _callStopServer = clientHelper.BuildApiCall<StopServerRequest, lro::Operation>("StopServer", grpcClient.StopServerAsync, grpcClient.StopServer, effectiveSettings.StopServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopServer);
            Modify_StopServerApiCall(ref _callStopServer);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServersApiCall(ref gaxgrpc::ApiCall<ListServersRequest, ListServersResponse> call);

        partial void Modify_GetServerApiCall(ref gaxgrpc::ApiCall<GetServerRequest, Server> call);

        partial void Modify_CreateServerApiCall(ref gaxgrpc::ApiCall<CreateServerRequest, lro::Operation> call);

        partial void Modify_UpdateServerApiCall(ref gaxgrpc::ApiCall<UpdateServerRequest, lro::Operation> call);

        partial void Modify_DeleteServerApiCall(ref gaxgrpc::ApiCall<DeleteServerRequest, lro::Operation> call);

        partial void Modify_ListUsersApiCall(ref gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> call);

        partial void Modify_GetUserApiCall(ref gaxgrpc::ApiCall<GetUserRequest, User> call);

        partial void Modify_CreateUserApiCall(ref gaxgrpc::ApiCall<CreateUserRequest, lro::Operation> call);

        partial void Modify_UpdateUserApiCall(ref gaxgrpc::ApiCall<UpdateUserRequest, lro::Operation> call);

        partial void Modify_DeleteUserApiCall(ref gaxgrpc::ApiCall<DeleteUserRequest, lro::Operation> call);

        partial void Modify_StartServerApiCall(ref gaxgrpc::ApiCall<StartServerRequest, lro::Operation> call);

        partial void Modify_StopServerApiCall(ref gaxgrpc::ApiCall<StopServerRequest, lro::Operation> call);

        partial void OnConstruction(CloudFtp.CloudFtpClient grpcClient, CloudFtpSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudFtp client</summary>
        public override CloudFtp.CloudFtpClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListServersRequest(ref ListServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServerRequest(ref GetServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServerRequest(ref CreateServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServerRequest(ref UpdateServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServerRequest(ref DeleteServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsersRequest(ref ListUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserRequest(ref GetUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserRequest(ref CreateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserRequest(ref UpdateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserRequest(ref DeleteUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartServerRequest(ref StartServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopServerRequest(ref StopServerRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Server"/> resources.</returns>
        public override gax::PagedEnumerable<ListServersResponse, Server> ListServers(ListServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServersRequest, ListServersResponse, Server>(_callListServers, request, callSettings);
        }

        /// <summary>
        /// Lists Servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Server"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServersResponse, Server> ListServersAsync(ListServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServersRequest, ListServersResponse, Server>(_callListServers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Server GetServer(GetServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServerRequest(ref request, ref callSettings);
            return _callGetServer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Server> GetServerAsync(GetServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServerRequest(ref request, ref callSettings);
            return _callGetServer.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServer</c>.</summary>
        public override lro::OperationsClient CreateServerOperationsClient { get; }

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Server, OperationMetadata> CreateServer(CreateServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(_callCreateServer.Sync(request, callSettings), CreateServerOperationsClient);
        }

        /// <summary>
        /// Creates a new Server in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Server, OperationMetadata>> CreateServerAsync(CreateServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(await _callCreateServer.Async(request, callSettings).ConfigureAwait(false), CreateServerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServer</c>.</summary>
        public override lro::OperationsClient UpdateServerOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Server, OperationMetadata> UpdateServer(UpdateServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(_callUpdateServer.Sync(request, callSettings), UpdateServerOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Server, OperationMetadata>> UpdateServerAsync(UpdateServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(await _callUpdateServer.Async(request, callSettings).ConfigureAwait(false), UpdateServerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServer</c>.</summary>
        public override lro::OperationsClient DeleteServerOperationsClient { get; }

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServer(DeleteServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServerRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServer.Sync(request, callSettings), DeleteServerOperationsClient);
        }

        /// <summary>
        /// Deletes a single Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerAsync(DeleteServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServerRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServer.Async(request, callSettings).ConfigureAwait(false), DeleteServerOperationsClient);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateUser</c>.</summary>
        public override lro::OperationsClient CreateUserOperationsClient { get; }

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<User, OperationMetadata> CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserRequest(ref request, ref callSettings);
            return new lro::Operation<User, OperationMetadata>(_callCreateUser.Sync(request, callSettings), CreateUserOperationsClient);
        }

        /// <summary>
        /// Creates a new User in a given project and location and Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<User, OperationMetadata>> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserRequest(ref request, ref callSettings);
            return new lro::Operation<User, OperationMetadata>(await _callCreateUser.Async(request, callSettings).ConfigureAwait(false), CreateUserOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateUser</c>.</summary>
        public override lro::OperationsClient UpdateUserOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<User, OperationMetadata> UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserRequest(ref request, ref callSettings);
            return new lro::Operation<User, OperationMetadata>(_callUpdateUser.Sync(request, callSettings), UpdateUserOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<User, OperationMetadata>> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserRequest(ref request, ref callSettings);
            return new lro::Operation<User, OperationMetadata>(await _callUpdateUser.Async(request, callSettings).ConfigureAwait(false), UpdateUserOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteUser</c>.</summary>
        public override lro::OperationsClient DeleteUserOperationsClient { get; }

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteUser(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteUser.Sync(request, callSettings), DeleteUserOperationsClient);
        }

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUserAsync(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteUser.Async(request, callSettings).ConfigureAwait(false), DeleteUserOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartServer</c>.</summary>
        public override lro::OperationsClient StartServerOperationsClient { get; }

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Server, OperationMetadata> StartServer(StartServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(_callStartServer.Sync(request, callSettings), StartServerOperationsClient);
        }

        /// <summary>
        /// Starts a stopping/stopped Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Server, OperationMetadata>> StartServerAsync(StartServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(await _callStartServer.Async(request, callSettings).ConfigureAwait(false), StartServerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopServer</c>.</summary>
        public override lro::OperationsClient StopServerOperationsClient { get; }

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Server, OperationMetadata> StopServer(StopServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(_callStopServer.Sync(request, callSettings), StopServerOperationsClient);
        }

        /// <summary>
        /// Stops an active Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Server, OperationMetadata>> StopServerAsync(StopServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopServerRequest(ref request, ref callSettings);
            return new lro::Operation<Server, OperationMetadata>(await _callStopServer.Async(request, callSettings).ConfigureAwait(false), StopServerOperationsClient);
        }
    }

    public partial class ListServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUsersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServersResponse : gaxgrpc::IPageResponse<Server>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Server> GetEnumerator() => Servers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUsersResponse : gaxgrpc::IPageResponse<User>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<User> GetEnumerator() => Users.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudFtp
    {
        public partial class CloudFtpClient
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

    public static partial class CloudFtp
    {
        public partial class CloudFtpClient
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
