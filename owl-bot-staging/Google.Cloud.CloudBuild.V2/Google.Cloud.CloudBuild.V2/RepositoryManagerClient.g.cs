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

namespace Google.Cloud.CloudBuild.V2
{
    /// <summary>Settings for <see cref="RepositoryManagerClient"/> instances.</summary>
    public sealed partial class RepositoryManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RepositoryManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RepositoryManagerSettings"/>.</returns>
        public static RepositoryManagerSettings GetDefault() => new RepositoryManagerSettings();

        /// <summary>Constructs a new <see cref="RepositoryManagerSettings"/> object with default settings.</summary>
        public RepositoryManagerSettings()
        {
        }

        private RepositoryManagerSettings(RepositoryManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConnectionSettings = existing.CreateConnectionSettings;
            CreateConnectionOperationsSettings = existing.CreateConnectionOperationsSettings.Clone();
            GetConnectionSettings = existing.GetConnectionSettings;
            ListConnectionsSettings = existing.ListConnectionsSettings;
            UpdateConnectionSettings = existing.UpdateConnectionSettings;
            UpdateConnectionOperationsSettings = existing.UpdateConnectionOperationsSettings.Clone();
            DeleteConnectionSettings = existing.DeleteConnectionSettings;
            DeleteConnectionOperationsSettings = existing.DeleteConnectionOperationsSettings.Clone();
            CreateRepositorySettings = existing.CreateRepositorySettings;
            CreateRepositoryOperationsSettings = existing.CreateRepositoryOperationsSettings.Clone();
            BatchCreateRepositoriesSettings = existing.BatchCreateRepositoriesSettings;
            BatchCreateRepositoriesOperationsSettings = existing.BatchCreateRepositoriesOperationsSettings.Clone();
            GetRepositorySettings = existing.GetRepositorySettings;
            ListRepositoriesSettings = existing.ListRepositoriesSettings;
            DeleteRepositorySettings = existing.DeleteRepositorySettings;
            DeleteRepositoryOperationsSettings = existing.DeleteRepositoryOperationsSettings.Clone();
            FetchReadWriteTokenSettings = existing.FetchReadWriteTokenSettings;
            FetchReadTokenSettings = existing.FetchReadTokenSettings;
            FetchLinkableRepositoriesSettings = existing.FetchLinkableRepositoriesSettings;
            FetchGitRefsSettings = existing.FetchGitRefsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(RepositoryManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.CreateConnection</c> and <c>RepositoryManagerClient.CreateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RepositoryManagerClient.CreateConnection</c> and
        /// <c>RepositoryManagerClient.CreateConnectionAsync</c>.
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
        public lro::OperationsSettings CreateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.GetConnection</c> and <c>RepositoryManagerClient.GetConnectionAsync</c>.
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
        public gaxgrpc::CallSettings GetConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.ListConnections</c> and <c>RepositoryManagerClient.ListConnectionsAsync</c>.
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
        public gaxgrpc::CallSettings ListConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.UpdateConnection</c> and <c>RepositoryManagerClient.UpdateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RepositoryManagerClient.UpdateConnection</c> and
        /// <c>RepositoryManagerClient.UpdateConnectionAsync</c>.
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
        public lro::OperationsSettings UpdateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.DeleteConnection</c> and <c>RepositoryManagerClient.DeleteConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RepositoryManagerClient.DeleteConnection</c> and
        /// <c>RepositoryManagerClient.DeleteConnectionAsync</c>.
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
        public lro::OperationsSettings DeleteConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.CreateRepository</c> and <c>RepositoryManagerClient.CreateRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RepositoryManagerClient.CreateRepository</c> and
        /// <c>RepositoryManagerClient.CreateRepositoryAsync</c>.
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
        public lro::OperationsSettings CreateRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.BatchCreateRepositories</c> and
        /// <c>RepositoryManagerClient.BatchCreateRepositoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateRepositoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>RepositoryManagerClient.BatchCreateRepositories</c> and
        /// <c>RepositoryManagerClient.BatchCreateRepositoriesAsync</c>.
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
        public lro::OperationsSettings BatchCreateRepositoriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.GetRepository</c> and <c>RepositoryManagerClient.GetRepositoryAsync</c>.
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
        public gaxgrpc::CallSettings GetRepositorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.ListRepositories</c> and <c>RepositoryManagerClient.ListRepositoriesAsync</c>.
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
        public gaxgrpc::CallSettings ListRepositoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.DeleteRepository</c> and <c>RepositoryManagerClient.DeleteRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RepositoryManagerClient.DeleteRepository</c> and
        /// <c>RepositoryManagerClient.DeleteRepositoryAsync</c>.
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
        public lro::OperationsSettings DeleteRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.FetchReadWriteToken</c> and <c>RepositoryManagerClient.FetchReadWriteTokenAsync</c>
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
        public gaxgrpc::CallSettings FetchReadWriteTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.FetchReadToken</c> and <c>RepositoryManagerClient.FetchReadTokenAsync</c>.
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
        public gaxgrpc::CallSettings FetchReadTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.FetchLinkableRepositories</c> and
        /// <c>RepositoryManagerClient.FetchLinkableRepositoriesAsync</c>.
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
        public gaxgrpc::CallSettings FetchLinkableRepositoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RepositoryManagerClient.FetchGitRefs</c> and <c>RepositoryManagerClient.FetchGitRefsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchGitRefsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RepositoryManagerSettings"/> object.</returns>
        public RepositoryManagerSettings Clone() => new RepositoryManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RepositoryManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RepositoryManagerClientBuilder : gaxgrpc::ClientBuilderBase<RepositoryManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RepositoryManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RepositoryManagerClientBuilder() : base(RepositoryManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RepositoryManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RepositoryManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RepositoryManagerClient Build()
        {
            RepositoryManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RepositoryManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RepositoryManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RepositoryManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RepositoryManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RepositoryManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RepositoryManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RepositoryManagerClient.ChannelPool;
    }

    /// <summary>RepositoryManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages connections to source code repositories.
    /// </remarks>
    public abstract partial class RepositoryManagerClient
    {
        /// <summary>
        /// The default endpoint for the RepositoryManager service, which is a host of "cloudbuild.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudbuild.googleapis.com:443";

        /// <summary>The default RepositoryManager scopes.</summary>
        /// <remarks>
        /// The default RepositoryManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RepositoryManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RepositoryManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RepositoryManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RepositoryManagerClient"/>.</returns>
        public static stt::Task<RepositoryManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RepositoryManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RepositoryManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RepositoryManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RepositoryManagerClient"/>.</returns>
        public static RepositoryManagerClient Create() => new RepositoryManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RepositoryManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RepositoryManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RepositoryManagerClient"/>.</returns>
        internal static RepositoryManagerClient Create(grpccore::CallInvoker callInvoker, RepositoryManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RepositoryManager.RepositoryManagerClient grpcClient = new RepositoryManager.RepositoryManagerClient(callInvoker);
            return new RepositoryManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RepositoryManager client</summary>
        public virtual RepositoryManager.RepositoryManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(CreateConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnection</c>.</summary>
        public virtual lro::OperationsClient CreateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> PollOnceCreateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> PollOnceCreateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location where the connection will be created.
        /// Format: `projects/*/locations/*`.
        /// </param>
        /// <param name="connection">
        /// Required. The Connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID to use for the Connection, which will become the final
        /// component of the Connection's resource name. Names must be unique
        /// per-project per-location. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> CreateConnection(string parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
            }, callSettings);

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location where the connection will be created.
        /// Format: `projects/*/locations/*`.
        /// </param>
        /// <param name="connection">
        /// Required. The Connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID to use for the Connection, which will become the final
        /// component of the Connection's resource name. Names must be unique
        /// per-project per-location. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(string parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
            }, callSettings);

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location where the connection will be created.
        /// Format: `projects/*/locations/*`.
        /// </param>
        /// <param name="connection">
        /// Required. The Connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID to use for the Connection, which will become the final
        /// component of the Connection's resource name. Names must be unique
        /// per-project per-location. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(string parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location where the connection will be created.
        /// Format: `projects/*/locations/*`.
        /// </param>
        /// <param name="connection">
        /// Required. The Connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID to use for the Connection, which will become the final
        /// component of the Connection's resource name. Names must be unique
        /// per-project per-location. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> CreateConnection(gagr::LocationName parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
            }, callSettings);

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location where the connection will be created.
        /// Format: `projects/*/locations/*`.
        /// </param>
        /// <param name="connection">
        /// Required. The Connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID to use for the Connection, which will become the final
        /// component of the Connection's resource name. Names must be unique
        /// per-project per-location. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(gagr::LocationName parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
            }, callSettings);

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location where the connection will be created.
        /// Format: `projects/*/locations/*`.
        /// </param>
        /// <param name="connection">
        /// Required. The Connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID to use for the Connection, which will become the final
        /// component of the Connection's resource name. Names must be unique
        /// per-project per-location. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(gagr::LocationName parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to retrieve.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to retrieve.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to retrieve.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to retrieve.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to retrieve.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to retrieve.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Connections.
        /// Format: `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Connections.
        /// Format: `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Connections.
        /// Format: `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Connections.
        /// Format: `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(UpdateConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnection</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> PollOnceUpdateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> PollOnceUpdateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The Connection to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> UpdateConnection(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnection(new UpdateConnectionRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The Connection to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionAsync(new UpdateConnectionRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The Connection to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(connection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(DeleteConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnection</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to delete.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to delete.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to delete.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to delete.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to delete.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Connection to delete.
        /// Format: `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRepository</c>.</summary>
        public virtual lro::OperationsClient CreateRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> PollOnceCreateRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> PollOnceCreateRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain the repository. If the request is part
        /// of a BatchCreateRepositoriesRequest, this field should be empty or match
        /// the parent specified there.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain the repository. If the request is part
        /// of a BatchCreateRepositoriesRequest, this field should be empty or match
        /// the parent specified there.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain the repository. If the request is part
        /// of a BatchCreateRepositoriesRequest, this field should be empty or match
        /// the parent specified there.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain the repository. If the request is part
        /// of a BatchCreateRepositoriesRequest, this field should be empty or match
        /// the parent specified there.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(ConnectionName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain the repository. If the request is part
        /// of a BatchCreateRepositoriesRequest, this field should be empty or match
        /// the parent specified there.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(ConnectionName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain the repository. If the request is part
        /// of a BatchCreateRepositoriesRequest, this field should be empty or match
        /// the parent specified there.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(ConnectionName parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata> BatchCreateRepositories(BatchCreateRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(BatchCreateRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(BatchCreateRepositoriesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateRepositoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreateRepositories</c>.</summary>
        public virtual lro::OperationsClient BatchCreateRepositoriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateRepositories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata> PollOnceBatchCreateRepositories(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateRepositoriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateRepositories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> PollOnceBatchCreateRepositoriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateRepositoriesOperationsClient, callSettings);

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain all the repositories being created.
        /// Format: projects/*/locations/*/connections/*
        /// The parent field in the CreateRepositoryRequest messages
        /// must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request messages specifying the repositories to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata> BatchCreateRepositories(string parent, scg::IEnumerable<CreateRepositoryRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateRepositories(new BatchCreateRepositoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain all the repositories being created.
        /// Format: projects/*/locations/*/connections/*
        /// The parent field in the CreateRepositoryRequest messages
        /// must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request messages specifying the repositories to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(string parent, scg::IEnumerable<CreateRepositoryRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateRepositoriesAsync(new BatchCreateRepositoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain all the repositories being created.
        /// Format: projects/*/locations/*/connections/*
        /// The parent field in the CreateRepositoryRequest messages
        /// must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request messages specifying the repositories to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(string parent, scg::IEnumerable<CreateRepositoryRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateRepositoriesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain all the repositories being created.
        /// Format: projects/*/locations/*/connections/*
        /// The parent field in the CreateRepositoryRequest messages
        /// must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request messages specifying the repositories to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata> BatchCreateRepositories(ConnectionName parent, scg::IEnumerable<CreateRepositoryRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateRepositories(new BatchCreateRepositoriesRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain all the repositories being created.
        /// Format: projects/*/locations/*/connections/*
        /// The parent field in the CreateRepositoryRequest messages
        /// must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request messages specifying the repositories to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(ConnectionName parent, scg::IEnumerable<CreateRepositoryRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateRepositoriesAsync(new BatchCreateRepositoriesRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The connection to contain all the repositories being created.
        /// Format: projects/*/locations/*/connections/*
        /// The parent field in the CreateRepositoryRequest messages
        /// must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request messages specifying the repositories to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(ConnectionName parent, scg::IEnumerable<CreateRepositoryRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateRepositoriesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to retrieve.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to retrieve.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to retrieve.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to retrieve.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to retrieve.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to retrieve.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Repositories.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositories(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Repositories.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Repositories.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRepositories(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Repositories.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRepository</c>.</summary>
        public virtual lro::OperationsClient DeleteRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to delete.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to delete.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to delete.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to delete.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to delete.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Repository to delete.
        /// Format: `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadWriteTokenResponse FetchReadWriteToken(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(FetchReadWriteTokenRequest request, st::CancellationToken cancellationToken) =>
            FetchReadWriteTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadWriteTokenResponse FetchReadWriteToken(string repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteToken(new FetchReadWriteTokenRequest
            {
                Repository = gax::GaxPreconditions.CheckNotNullOrEmpty(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(string repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteTokenAsync(new FetchReadWriteTokenRequest
            {
                Repository = gax::GaxPreconditions.CheckNotNullOrEmpty(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(string repository, st::CancellationToken cancellationToken) =>
            FetchReadWriteTokenAsync(repository, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadWriteTokenResponse FetchReadWriteToken(RepositoryName repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteToken(new FetchReadWriteTokenRequest
            {
                RepositoryAsRepositoryName = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(RepositoryName repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteTokenAsync(new FetchReadWriteTokenRequest
            {
                RepositoryAsRepositoryName = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(RepositoryName repository, st::CancellationToken cancellationToken) =>
            FetchReadWriteTokenAsync(repository, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadTokenResponse FetchReadToken(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(FetchReadTokenRequest request, st::CancellationToken cancellationToken) =>
            FetchReadTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadTokenResponse FetchReadToken(string repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadToken(new FetchReadTokenRequest
            {
                Repository = gax::GaxPreconditions.CheckNotNullOrEmpty(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(string repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadTokenAsync(new FetchReadTokenRequest
            {
                Repository = gax::GaxPreconditions.CheckNotNullOrEmpty(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(string repository, st::CancellationToken cancellationToken) =>
            FetchReadTokenAsync(repository, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadTokenResponse FetchReadToken(RepositoryName repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadToken(new FetchReadTokenRequest
            {
                RepositoryAsRepositoryName = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(RepositoryName repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadTokenAsync(new FetchReadTokenRequest
            {
                RepositoryAsRepositoryName = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(RepositoryName repository, st::CancellationToken cancellationToken) =>
            FetchReadTokenAsync(repository, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchLinkableRepositories get repositories from SCM that are
        /// accessible and could be added to the connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchLinkableRepositoriesResponse, Repository> FetchLinkableRepositories(FetchLinkableRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchLinkableRepositories get repositories from SCM that are
        /// accessible and could be added to the connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchLinkableRepositoriesResponse, Repository> FetchLinkableRepositoriesAsync(FetchLinkableRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitRefsResponse FetchGitRefs(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(FetchGitRefsRequest request, st::CancellationToken cancellationToken) =>
            FetchGitRefsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitRefsResponse FetchGitRefs(string repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitRefs(new FetchGitRefsRequest
            {
                Repository = gax::GaxPreconditions.CheckNotNullOrEmpty(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(string repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitRefsAsync(new FetchGitRefsRequest
            {
                Repository = gax::GaxPreconditions.CheckNotNullOrEmpty(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(string repository, st::CancellationToken cancellationToken) =>
            FetchGitRefsAsync(repository, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitRefsResponse FetchGitRefs(RepositoryName repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitRefs(new FetchGitRefsRequest
            {
                RepositoryAsRepositoryName = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(RepositoryName repository, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitRefsAsync(new FetchGitRefsRequest
            {
                RepositoryAsRepositoryName = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The resource name of the repository in the format
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(RepositoryName repository, st::CancellationToken cancellationToken) =>
            FetchGitRefsAsync(repository, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RepositoryManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages connections to source code repositories.
    /// </remarks>
    public sealed partial class RepositoryManagerClientImpl : RepositoryManagerClient
    {
        private readonly gaxgrpc::ApiCall<CreateConnectionRequest, lro::Operation> _callCreateConnection;

        private readonly gaxgrpc::ApiCall<GetConnectionRequest, Connection> _callGetConnection;

        private readonly gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> _callListConnections;

        private readonly gaxgrpc::ApiCall<UpdateConnectionRequest, lro::Operation> _callUpdateConnection;

        private readonly gaxgrpc::ApiCall<DeleteConnectionRequest, lro::Operation> _callDeleteConnection;

        private readonly gaxgrpc::ApiCall<CreateRepositoryRequest, lro::Operation> _callCreateRepository;

        private readonly gaxgrpc::ApiCall<BatchCreateRepositoriesRequest, lro::Operation> _callBatchCreateRepositories;

        private readonly gaxgrpc::ApiCall<GetRepositoryRequest, Repository> _callGetRepository;

        private readonly gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> _callListRepositories;

        private readonly gaxgrpc::ApiCall<DeleteRepositoryRequest, lro::Operation> _callDeleteRepository;

        private readonly gaxgrpc::ApiCall<FetchReadWriteTokenRequest, FetchReadWriteTokenResponse> _callFetchReadWriteToken;

        private readonly gaxgrpc::ApiCall<FetchReadTokenRequest, FetchReadTokenResponse> _callFetchReadToken;

        private readonly gaxgrpc::ApiCall<FetchLinkableRepositoriesRequest, FetchLinkableRepositoriesResponse> _callFetchLinkableRepositories;

        private readonly gaxgrpc::ApiCall<FetchGitRefsRequest, FetchGitRefsResponse> _callFetchGitRefs;

        /// <summary>
        /// Constructs a client wrapper for the RepositoryManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RepositoryManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RepositoryManagerClientImpl(RepositoryManager.RepositoryManagerClient grpcClient, RepositoryManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RepositoryManagerSettings effectiveSettings = settings ?? RepositoryManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectionOperationsSettings, logger);
            UpdateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectionOperationsSettings, logger);
            DeleteConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectionOperationsSettings, logger);
            CreateRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRepositoryOperationsSettings, logger);
            BatchCreateRepositoriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateRepositoriesOperationsSettings, logger);
            DeleteRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRepositoryOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateConnection = clientHelper.BuildApiCall<CreateConnectionRequest, lro::Operation>("CreateConnection", grpcClient.CreateConnectionAsync, grpcClient.CreateConnection, effectiveSettings.CreateConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnection);
            Modify_CreateConnectionApiCall(ref _callCreateConnection);
            _callGetConnection = clientHelper.BuildApiCall<GetConnectionRequest, Connection>("GetConnection", grpcClient.GetConnectionAsync, grpcClient.GetConnection, effectiveSettings.GetConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnection);
            Modify_GetConnectionApiCall(ref _callGetConnection);
            _callListConnections = clientHelper.BuildApiCall<ListConnectionsRequest, ListConnectionsResponse>("ListConnections", grpcClient.ListConnectionsAsync, grpcClient.ListConnections, effectiveSettings.ListConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnections);
            Modify_ListConnectionsApiCall(ref _callListConnections);
            _callUpdateConnection = clientHelper.BuildApiCall<UpdateConnectionRequest, lro::Operation>("UpdateConnection", grpcClient.UpdateConnectionAsync, grpcClient.UpdateConnection, effectiveSettings.UpdateConnectionSettings).WithGoogleRequestParam("connection.name", request => request.Connection?.Name);
            Modify_ApiCall(ref _callUpdateConnection);
            Modify_UpdateConnectionApiCall(ref _callUpdateConnection);
            _callDeleteConnection = clientHelper.BuildApiCall<DeleteConnectionRequest, lro::Operation>("DeleteConnection", grpcClient.DeleteConnectionAsync, grpcClient.DeleteConnection, effectiveSettings.DeleteConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnection);
            Modify_DeleteConnectionApiCall(ref _callDeleteConnection);
            _callCreateRepository = clientHelper.BuildApiCall<CreateRepositoryRequest, lro::Operation>("CreateRepository", grpcClient.CreateRepositoryAsync, grpcClient.CreateRepository, effectiveSettings.CreateRepositorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRepository);
            Modify_CreateRepositoryApiCall(ref _callCreateRepository);
            _callBatchCreateRepositories = clientHelper.BuildApiCall<BatchCreateRepositoriesRequest, lro::Operation>("BatchCreateRepositories", grpcClient.BatchCreateRepositoriesAsync, grpcClient.BatchCreateRepositories, effectiveSettings.BatchCreateRepositoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateRepositories);
            Modify_BatchCreateRepositoriesApiCall(ref _callBatchCreateRepositories);
            _callGetRepository = clientHelper.BuildApiCall<GetRepositoryRequest, Repository>("GetRepository", grpcClient.GetRepositoryAsync, grpcClient.GetRepository, effectiveSettings.GetRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRepository);
            Modify_GetRepositoryApiCall(ref _callGetRepository);
            _callListRepositories = clientHelper.BuildApiCall<ListRepositoriesRequest, ListRepositoriesResponse>("ListRepositories", grpcClient.ListRepositoriesAsync, grpcClient.ListRepositories, effectiveSettings.ListRepositoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRepositories);
            Modify_ListRepositoriesApiCall(ref _callListRepositories);
            _callDeleteRepository = clientHelper.BuildApiCall<DeleteRepositoryRequest, lro::Operation>("DeleteRepository", grpcClient.DeleteRepositoryAsync, grpcClient.DeleteRepository, effectiveSettings.DeleteRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRepository);
            Modify_DeleteRepositoryApiCall(ref _callDeleteRepository);
            _callFetchReadWriteToken = clientHelper.BuildApiCall<FetchReadWriteTokenRequest, FetchReadWriteTokenResponse>("FetchReadWriteToken", grpcClient.FetchReadWriteTokenAsync, grpcClient.FetchReadWriteToken, effectiveSettings.FetchReadWriteTokenSettings).WithGoogleRequestParam("repository", request => request.Repository);
            Modify_ApiCall(ref _callFetchReadWriteToken);
            Modify_FetchReadWriteTokenApiCall(ref _callFetchReadWriteToken);
            _callFetchReadToken = clientHelper.BuildApiCall<FetchReadTokenRequest, FetchReadTokenResponse>("FetchReadToken", grpcClient.FetchReadTokenAsync, grpcClient.FetchReadToken, effectiveSettings.FetchReadTokenSettings).WithGoogleRequestParam("repository", request => request.Repository);
            Modify_ApiCall(ref _callFetchReadToken);
            Modify_FetchReadTokenApiCall(ref _callFetchReadToken);
            _callFetchLinkableRepositories = clientHelper.BuildApiCall<FetchLinkableRepositoriesRequest, FetchLinkableRepositoriesResponse>("FetchLinkableRepositories", grpcClient.FetchLinkableRepositoriesAsync, grpcClient.FetchLinkableRepositories, effectiveSettings.FetchLinkableRepositoriesSettings).WithGoogleRequestParam("connection", request => request.Connection);
            Modify_ApiCall(ref _callFetchLinkableRepositories);
            Modify_FetchLinkableRepositoriesApiCall(ref _callFetchLinkableRepositories);
            _callFetchGitRefs = clientHelper.BuildApiCall<FetchGitRefsRequest, FetchGitRefsResponse>("FetchGitRefs", grpcClient.FetchGitRefsAsync, grpcClient.FetchGitRefs, effectiveSettings.FetchGitRefsSettings).WithGoogleRequestParam("repository", request => request.Repository);
            Modify_ApiCall(ref _callFetchGitRefs);
            Modify_FetchGitRefsApiCall(ref _callFetchGitRefs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConnectionApiCall(ref gaxgrpc::ApiCall<CreateConnectionRequest, lro::Operation> call);

        partial void Modify_GetConnectionApiCall(ref gaxgrpc::ApiCall<GetConnectionRequest, Connection> call);

        partial void Modify_ListConnectionsApiCall(ref gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> call);

        partial void Modify_UpdateConnectionApiCall(ref gaxgrpc::ApiCall<UpdateConnectionRequest, lro::Operation> call);

        partial void Modify_DeleteConnectionApiCall(ref gaxgrpc::ApiCall<DeleteConnectionRequest, lro::Operation> call);

        partial void Modify_CreateRepositoryApiCall(ref gaxgrpc::ApiCall<CreateRepositoryRequest, lro::Operation> call);

        partial void Modify_BatchCreateRepositoriesApiCall(ref gaxgrpc::ApiCall<BatchCreateRepositoriesRequest, lro::Operation> call);

        partial void Modify_GetRepositoryApiCall(ref gaxgrpc::ApiCall<GetRepositoryRequest, Repository> call);

        partial void Modify_ListRepositoriesApiCall(ref gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> call);

        partial void Modify_DeleteRepositoryApiCall(ref gaxgrpc::ApiCall<DeleteRepositoryRequest, lro::Operation> call);

        partial void Modify_FetchReadWriteTokenApiCall(ref gaxgrpc::ApiCall<FetchReadWriteTokenRequest, FetchReadWriteTokenResponse> call);

        partial void Modify_FetchReadTokenApiCall(ref gaxgrpc::ApiCall<FetchReadTokenRequest, FetchReadTokenResponse> call);

        partial void Modify_FetchLinkableRepositoriesApiCall(ref gaxgrpc::ApiCall<FetchLinkableRepositoriesRequest, FetchLinkableRepositoriesResponse> call);

        partial void Modify_FetchGitRefsApiCall(ref gaxgrpc::ApiCall<FetchGitRefsRequest, FetchGitRefsResponse> call);

        partial void OnConstruction(RepositoryManager.RepositoryManagerClient grpcClient, RepositoryManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RepositoryManager client</summary>
        public override RepositoryManager.RepositoryManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateConnectionRequest(ref CreateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionRequest(ref GetConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectionsRequest(ref ListConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionRequest(ref UpdateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionRequest(ref DeleteConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRepositoryRequest(ref CreateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateRepositoriesRequest(ref BatchCreateRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRepositoryRequest(ref GetRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRepositoriesRequest(ref ListRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRepositoryRequest(ref DeleteRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchReadWriteTokenRequest(ref FetchReadWriteTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchReadTokenRequest(ref FetchReadTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchLinkableRepositoriesRequest(ref FetchLinkableRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchGitRefsRequest(ref FetchGitRefsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateConnection</c>.</summary>
        public override lro::OperationsClient CreateConnectionOperationsClient { get; }

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Connection, OperationMetadata> CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(_callCreateConnection.Sync(request, callSettings), CreateConnectionOperationsClient);
        }

        /// <summary>
        /// Creates a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(await _callCreateConnection.Async(request, callSettings).ConfigureAwait(false), CreateConnectionOperationsClient);
        }

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionRequest(ref request, ref callSettings);
            return _callGetConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionRequest(ref request, ref callSettings);
            return _callGetConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectionsRequest, ListConnectionsResponse, Connection>(_callListConnections, request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectionsRequest, ListConnectionsResponse, Connection>(_callListConnections, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateConnection</c>.</summary>
        public override lro::OperationsClient UpdateConnectionOperationsClient { get; }

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Connection, OperationMetadata> UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(_callUpdateConnection.Sync(request, callSettings), UpdateConnectionOperationsClient);
        }

        /// <summary>
        /// Updates a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(await _callUpdateConnection.Async(request, callSettings).ConfigureAwait(false), UpdateConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnection</c>.</summary>
        public override lro::OperationsClient DeleteConnectionOperationsClient { get; }

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnection.Sync(request, callSettings), DeleteConnectionOperationsClient);
        }

        /// <summary>
        /// Deletes a single connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnection.Async(request, callSettings).ConfigureAwait(false), DeleteConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateRepository</c>.</summary>
        public override lro::OperationsClient CreateRepositoryOperationsClient { get; }

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Repository, OperationMetadata> CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(_callCreateRepository.Sync(request, callSettings), CreateRepositoryOperationsClient);
        }

        /// <summary>
        /// Creates a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(await _callCreateRepository.Async(request, callSettings).ConfigureAwait(false), CreateRepositoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchCreateRepositories</c>.</summary>
        public override lro::OperationsClient BatchCreateRepositoriesOperationsClient { get; }

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata> BatchCreateRepositories(BatchCreateRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateRepositoriesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>(_callBatchCreateRepositories.Sync(request, callSettings), BatchCreateRepositoriesOperationsClient);
        }

        /// <summary>
        /// Creates multiple repositories inside a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>> BatchCreateRepositoriesAsync(BatchCreateRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateRepositoriesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateRepositoriesResponse, OperationMetadata>(await _callBatchCreateRepositories.Async(request, callSettings).ConfigureAwait(false), BatchCreateRepositoriesOperationsClient);
        }

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRepository</c>.</summary>
        public override lro::OperationsClient DeleteRepositoryOperationsClient { get; }

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRepository.Sync(request, callSettings), DeleteRepositoryOperationsClient);
        }

        /// <summary>
        /// Deletes a single repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRepository.Async(request, callSettings).ConfigureAwait(false), DeleteRepositoryOperationsClient);
        }

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchReadWriteTokenResponse FetchReadWriteToken(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadWriteTokenRequest(ref request, ref callSettings);
            return _callFetchReadWriteToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches read/write token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadWriteTokenRequest(ref request, ref callSettings);
            return _callFetchReadWriteToken.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchReadTokenResponse FetchReadToken(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadTokenRequest(ref request, ref callSettings);
            return _callFetchReadToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches read token of a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadTokenRequest(ref request, ref callSettings);
            return _callFetchReadToken.Async(request, callSettings);
        }

        /// <summary>
        /// FetchLinkableRepositories get repositories from SCM that are
        /// accessible and could be added to the connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedEnumerable<FetchLinkableRepositoriesResponse, Repository> FetchLinkableRepositories(FetchLinkableRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchLinkableRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchLinkableRepositoriesRequest, FetchLinkableRepositoriesResponse, Repository>(_callFetchLinkableRepositories, request, callSettings);
        }

        /// <summary>
        /// FetchLinkableRepositories get repositories from SCM that are
        /// accessible and could be added to the connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchLinkableRepositoriesResponse, Repository> FetchLinkableRepositoriesAsync(FetchLinkableRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchLinkableRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchLinkableRepositoriesRequest, FetchLinkableRepositoriesResponse, Repository>(_callFetchLinkableRepositories, request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchGitRefsResponse FetchGitRefs(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitRefsRequest(ref request, ref callSettings);
            return _callFetchGitRefs.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchGitRefsResponse> FetchGitRefsAsync(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitRefsRequest(ref request, ref callSettings);
            return _callFetchGitRefs.Async(request, callSettings);
        }
    }

    public partial class ListConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchLinkableRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionsResponse : gaxgrpc::IPageResponse<Connection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connection> GetEnumerator() => Connections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRepositoriesResponse : gaxgrpc::IPageResponse<Repository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Repository> GetEnumerator() => Repositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchLinkableRepositoriesResponse : gaxgrpc::IPageResponse<Repository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Repository> GetEnumerator() => Repositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RepositoryManager
    {
        public partial class RepositoryManagerClient
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

    public static partial class RepositoryManager
    {
        public partial class RepositoryManagerClient
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
