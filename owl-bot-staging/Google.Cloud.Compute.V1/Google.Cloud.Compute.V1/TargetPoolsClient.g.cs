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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="TargetPoolsClient"/> instances.</summary>
    public sealed partial class TargetPoolsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetPoolsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetPoolsSettings"/>.</returns>
        public static TargetPoolsSettings GetDefault() => new TargetPoolsSettings();

        /// <summary>Constructs a new <see cref="TargetPoolsSettings"/> object with default settings.</summary>
        public TargetPoolsSettings()
        {
        }

        private TargetPoolsSettings(TargetPoolsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddHealthCheckSettings = existing.AddHealthCheckSettings;
            AddHealthCheckOperationsSettings = existing.AddHealthCheckOperationsSettings.Clone();
            AddInstanceSettings = existing.AddInstanceSettings;
            AddInstanceOperationsSettings = existing.AddInstanceOperationsSettings.Clone();
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetHealthSettings = existing.GetHealthSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            RemoveHealthCheckSettings = existing.RemoveHealthCheckSettings;
            RemoveHealthCheckOperationsSettings = existing.RemoveHealthCheckOperationsSettings.Clone();
            RemoveInstanceSettings = existing.RemoveInstanceSettings;
            RemoveInstanceOperationsSettings = existing.RemoveInstanceOperationsSettings.Clone();
            SetBackupSettings = existing.SetBackupSettings;
            SetBackupOperationsSettings = existing.SetBackupOperationsSettings.Clone();
            SetSecurityPolicySettings = existing.SetSecurityPolicySettings;
            SetSecurityPolicyOperationsSettings = existing.SetSecurityPolicyOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(TargetPoolsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetPoolsClient.AddHealthCheck</c> and <c>TargetPoolsClient.AddHealthCheckAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddHealthCheckSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.AddHealthCheck</c> and
        /// <c>TargetPoolsClient.AddHealthCheckAsync</c>.
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
        public lro::OperationsSettings AddHealthCheckOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetPoolsClient.AddInstance</c> and <c>TargetPoolsClient.AddInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.AddInstance</c> and
        /// <c>TargetPoolsClient.AddInstanceAsync</c>.
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
        public lro::OperationsSettings AddInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetPoolsClient.AggregatedList</c> and <c>TargetPoolsClient.AggregatedListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetPoolsClient.Delete</c>
        ///  and <c>TargetPoolsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.Delete</c> and
        /// <c>TargetPoolsClient.DeleteAsync</c>.
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
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetPoolsClient.Get</c>
        /// and <c>TargetPoolsClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetPoolsClient.GetHealth</c>
        ///  and <c>TargetPoolsClient.GetHealthAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHealthSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetPoolsClient.Insert</c>
        ///  and <c>TargetPoolsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.Insert</c> and
        /// <c>TargetPoolsClient.InsertAsync</c>.
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
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetPoolsClient.List</c>
        /// and <c>TargetPoolsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetPoolsClient.RemoveHealthCheck</c> and <c>TargetPoolsClient.RemoveHealthCheckAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveHealthCheckSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.RemoveHealthCheck</c> and
        /// <c>TargetPoolsClient.RemoveHealthCheckAsync</c>.
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
        public lro::OperationsSettings RemoveHealthCheckOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetPoolsClient.RemoveInstance</c> and <c>TargetPoolsClient.RemoveInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.RemoveInstance</c> and
        /// <c>TargetPoolsClient.RemoveInstanceAsync</c>.
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
        public lro::OperationsSettings RemoveInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetPoolsClient.SetBackup</c>
        ///  and <c>TargetPoolsClient.SetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.SetBackup</c> and
        /// <c>TargetPoolsClient.SetBackupAsync</c>.
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
        public lro::OperationsSettings SetBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetPoolsClient.SetSecurityPolicy</c> and <c>TargetPoolsClient.SetSecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetPoolsClient.SetSecurityPolicy</c> and
        /// <c>TargetPoolsClient.SetSecurityPolicyAsync</c>.
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
        public lro::OperationsSettings SetSecurityPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetPoolsSettings"/> object.</returns>
        public TargetPoolsSettings Clone() => new TargetPoolsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetPoolsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TargetPoolsClientBuilder : gaxgrpc::ClientBuilderBase<TargetPoolsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetPoolsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TargetPoolsClientBuilder() : base(TargetPoolsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TargetPoolsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetPoolsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetPoolsClient Build()
        {
            TargetPoolsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetPoolsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetPoolsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetPoolsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetPoolsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TargetPoolsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetPoolsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetPoolsClient.ChannelPool;
    }

    /// <summary>TargetPools client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetPools API.
    /// </remarks>
    public abstract partial class TargetPoolsClient
    {
        /// <summary>
        /// The default endpoint for the TargetPools service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetPools scopes.</summary>
        /// <remarks>
        /// The default TargetPools scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TargetPools.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TargetPoolsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetPoolsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetPoolsClient"/>.</returns>
        public static stt::Task<TargetPoolsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetPoolsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetPoolsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetPoolsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TargetPoolsClient"/>.</returns>
        public static TargetPoolsClient Create() => new TargetPoolsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetPoolsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetPoolsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TargetPoolsClient"/>.</returns>
        internal static TargetPoolsClient Create(grpccore::CallInvoker callInvoker, TargetPoolsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetPools.TargetPoolsClient grpcClient = new TargetPools.TargetPoolsClient(callInvoker);
            return new TargetPoolsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TargetPools client</summary>
        public virtual TargetPools.TargetPoolsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddHealthCheck(AddHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddHealthCheckAsync(AddHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddHealthCheckAsync(AddHealthCheckTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            AddHealthCheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddHealthCheck</c>.</summary>
        public virtual lro::OperationsClient AddHealthCheckOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddHealthCheck</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddHealthCheck(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddHealthCheckOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddHealthCheck</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddHealthCheckAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddHealthCheckOperationsClient, callSettings);

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the target pool to add a health check to.
        /// </param>
        /// <param name="targetPoolsAddHealthCheckRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddHealthCheck(string project, string region, string targetPool, TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddHealthCheck(new AddHealthCheckTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsAddHealthCheckRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsAddHealthCheckRequestResource, nameof(targetPoolsAddHealthCheckRequestResource)),
            }, callSettings);

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the target pool to add a health check to.
        /// </param>
        /// <param name="targetPoolsAddHealthCheckRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddHealthCheckAsync(string project, string region, string targetPool, TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddHealthCheckAsync(new AddHealthCheckTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsAddHealthCheckRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsAddHealthCheckRequestResource, nameof(targetPoolsAddHealthCheckRequestResource)),
            }, callSettings);

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the target pool to add a health check to.
        /// </param>
        /// <param name="targetPoolsAddHealthCheckRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddHealthCheckAsync(string project, string region, string targetPool, TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource, st::CancellationToken cancellationToken) =>
            AddHealthCheckAsync(project, region, targetPool, targetPoolsAddHealthCheckRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddInstance(AddInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstanceAsync(AddInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstanceAsync(AddInstanceTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            AddInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddInstance</c>.</summary>
        public virtual lro::OperationsClient AddInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddInstanceOperationsClient, callSettings);

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to add instances to.
        /// </param>
        /// <param name="targetPoolsAddInstanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddInstance(string project, string region, string targetPool, TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddInstance(new AddInstanceTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsAddInstanceRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsAddInstanceRequestResource, nameof(targetPoolsAddInstanceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to add instances to.
        /// </param>
        /// <param name="targetPoolsAddInstanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstanceAsync(string project, string region, string targetPool, TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddInstanceAsync(new AddInstanceTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsAddInstanceRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsAddInstanceRequestResource, nameof(targetPoolsAddInstanceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to add instances to.
        /// </param>
        /// <param name="targetPoolsAddInstanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstanceAsync(string project, string region, string targetPool, TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource, st::CancellationToken cancellationToken) =>
            AddInstanceAsync(project, region, targetPool, targetPoolsAddInstanceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an aggregated list of target pools. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>> AggregatedList(AggregatedListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of target pools. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>> AggregatedListAsync(AggregatedListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of target pools. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of target pools. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string region, string targetPool, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string targetPool, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string targetPool, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, targetPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetPool Get(GetTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPool> GetAsync(GetTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPool> GetAsync(GetTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetPool Get(string project, string region, string targetPool, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPool> GetAsync(string project, string region, string targetPool, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPool> GetAsync(string project, string region, string targetPool, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, targetPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetPoolInstanceHealth GetHealth(GetHealthTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPoolInstanceHealth> GetHealthAsync(GetHealthTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPoolInstanceHealth> GetHealthAsync(GetHealthTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            GetHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to which the queried instance belongs.
        /// </param>
        /// <param name="instanceReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetPoolInstanceHealth GetHealth(string project, string region, string targetPool, InstanceReference instanceReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            GetHealth(new GetHealthTargetPoolRequest
            {
                InstanceReferenceResource = gax::GaxPreconditions.CheckNotNull(instanceReferenceResource, nameof(instanceReferenceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to which the queried instance belongs.
        /// </param>
        /// <param name="instanceReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPoolInstanceHealth> GetHealthAsync(string project, string region, string targetPool, InstanceReference instanceReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            GetHealthAsync(new GetHealthTargetPoolRequest
            {
                InstanceReferenceResource = gax::GaxPreconditions.CheckNotNull(instanceReferenceResource, nameof(instanceReferenceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to which the queried instance belongs.
        /// </param>
        /// <param name="instanceReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetPoolInstanceHealth> GetHealthAsync(string project, string region, string targetPool, InstanceReference instanceReferenceResource, st::CancellationToken cancellationToken) =>
            GetHealthAsync(project, region, targetPool, instanceReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPoolResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string region, TargetPool targetPoolResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPoolResource = gax::GaxPreconditions.CheckNotNull(targetPoolResource, nameof(targetPoolResource)),
            }, callSettings);

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPoolResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, TargetPool targetPoolResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPoolResource = gax::GaxPreconditions.CheckNotNull(targetPoolResource, nameof(targetPoolResource)),
            }, callSettings);

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPoolResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, TargetPool targetPoolResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, targetPoolResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetPoolList, TargetPool> List(ListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetPoolList, TargetPool> ListAsync(ListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable sequence of <see cref="TargetPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetPoolList, TargetPool> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetPoolList, TargetPool> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveHealthCheck(RemoveHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            RemoveHealthCheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveHealthCheck</c>.</summary>
        public virtual lro::OperationsClient RemoveHealthCheckOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveHealthCheck</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceRemoveHealthCheck(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveHealthCheckOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveHealthCheck</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceRemoveHealthCheckAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveHealthCheckOperationsClient, callSettings);

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the target pool to remove health checks from.
        /// </param>
        /// <param name="targetPoolsRemoveHealthCheckRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveHealthCheck(string project, string region, string targetPool, TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveHealthCheck(new RemoveHealthCheckTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsRemoveHealthCheckRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsRemoveHealthCheckRequestResource, nameof(targetPoolsRemoveHealthCheckRequestResource)),
            }, callSettings);

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the target pool to remove health checks from.
        /// </param>
        /// <param name="targetPoolsRemoveHealthCheckRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveHealthCheckAsync(string project, string region, string targetPool, TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveHealthCheckAsync(new RemoveHealthCheckTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsRemoveHealthCheckRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsRemoveHealthCheckRequestResource, nameof(targetPoolsRemoveHealthCheckRequestResource)),
            }, callSettings);

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the target pool to remove health checks from.
        /// </param>
        /// <param name="targetPoolsRemoveHealthCheckRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveHealthCheckAsync(string project, string region, string targetPool, TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource, st::CancellationToken cancellationToken) =>
            RemoveHealthCheckAsync(project, region, targetPool, targetPoolsRemoveHealthCheckRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveInstance(RemoveInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstanceAsync(RemoveInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstanceAsync(RemoveInstanceTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            RemoveInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveInstance</c>.</summary>
        public virtual lro::OperationsClient RemoveInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceRemoveInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceRemoveInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveInstanceOperationsClient, callSettings);

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to remove instances from.
        /// </param>
        /// <param name="targetPoolsRemoveInstanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveInstance(string project, string region, string targetPool, TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveInstance(new RemoveInstanceTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsRemoveInstanceRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsRemoveInstanceRequestResource, nameof(targetPoolsRemoveInstanceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to remove instances from.
        /// </param>
        /// <param name="targetPoolsRemoveInstanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstanceAsync(string project, string region, string targetPool, TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveInstanceAsync(new RemoveInstanceTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetPoolsRemoveInstanceRequestResource = gax::GaxPreconditions.CheckNotNull(targetPoolsRemoveInstanceRequestResource, nameof(targetPoolsRemoveInstanceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to remove instances from.
        /// </param>
        /// <param name="targetPoolsRemoveInstanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstanceAsync(string project, string region, string targetPool, TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource, st::CancellationToken cancellationToken) =>
            RemoveInstanceAsync(project, region, targetPool, targetPoolsRemoveInstanceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetBackup(SetBackupTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackupAsync(SetBackupTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackupAsync(SetBackupTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            SetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetBackup</c>.</summary>
        public virtual lro::OperationsClient SetBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetBackupOperationsClient, callSettings);

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to set a backup pool for.
        /// </param>
        /// <param name="targetReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetBackup(string project, string region, string targetPool, TargetReference targetReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackup(new SetBackupTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetReferenceResource = gax::GaxPreconditions.CheckNotNull(targetReferenceResource, nameof(targetReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to set a backup pool for.
        /// </param>
        /// <param name="targetReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackupAsync(string project, string region, string targetPool, TargetReference targetReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackupAsync(new SetBackupTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
                TargetReferenceResource = gax::GaxPreconditions.CheckNotNull(targetReferenceResource, nameof(targetReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to set a backup pool for.
        /// </param>
        /// <param name="targetReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackupAsync(string project, string region, string targetPool, TargetReference targetReferenceResource, st::CancellationToken cancellationToken) =>
            SetBackupAsync(project, region, targetPool, targetReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSecurityPolicy(SetSecurityPolicyTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(SetSecurityPolicyTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(SetSecurityPolicyTargetPoolRequest request, st::CancellationToken cancellationToken) =>
            SetSecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSecurityPolicy</c>.</summary>
        public virtual lro::OperationsClient SetSecurityPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetSecurityPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetSecurityPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSecurityPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="securityPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSecurityPolicy(string project, string region, string targetPool, SecurityPolicyReference securityPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSecurityPolicy(new SetSecurityPolicyTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SecurityPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(securityPolicyReferenceResource, nameof(securityPolicyReferenceResource)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="securityPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(string project, string region, string targetPool, SecurityPolicyReference securityPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSecurityPolicyAsync(new SetSecurityPolicyTargetPoolRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SecurityPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(securityPolicyReferenceResource, nameof(securityPolicyReferenceResource)),
                TargetPool = gax::GaxPreconditions.CheckNotNullOrEmpty(targetPool, nameof(targetPool)),
            }, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetPool">
        /// Name of the TargetPool resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="securityPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(string project, string region, string targetPool, SecurityPolicyReference securityPolicyReferenceResource, st::CancellationToken cancellationToken) =>
            SetSecurityPolicyAsync(project, region, targetPool, securityPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetPools client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetPools API.
    /// </remarks>
    public sealed partial class TargetPoolsClientImpl : TargetPoolsClient
    {
        private readonly gaxgrpc::ApiCall<AddHealthCheckTargetPoolRequest, Operation> _callAddHealthCheck;

        private readonly gaxgrpc::ApiCall<AddInstanceTargetPoolRequest, Operation> _callAddInstance;

        private readonly gaxgrpc::ApiCall<AggregatedListTargetPoolsRequest, TargetPoolAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteTargetPoolRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetPoolRequest, TargetPool> _callGet;

        private readonly gaxgrpc::ApiCall<GetHealthTargetPoolRequest, TargetPoolInstanceHealth> _callGetHealth;

        private readonly gaxgrpc::ApiCall<InsertTargetPoolRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetPoolsRequest, TargetPoolList> _callList;

        private readonly gaxgrpc::ApiCall<RemoveHealthCheckTargetPoolRequest, Operation> _callRemoveHealthCheck;

        private readonly gaxgrpc::ApiCall<RemoveInstanceTargetPoolRequest, Operation> _callRemoveInstance;

        private readonly gaxgrpc::ApiCall<SetBackupTargetPoolRequest, Operation> _callSetBackup;

        private readonly gaxgrpc::ApiCall<SetSecurityPolicyTargetPoolRequest, Operation> _callSetSecurityPolicy;

        /// <summary>
        /// Constructs a client wrapper for the TargetPools service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetPoolsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TargetPoolsClientImpl(TargetPools.TargetPoolsClient grpcClient, TargetPoolsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TargetPoolsSettings effectiveSettings = settings ?? TargetPoolsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddHealthCheckOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.AddHealthCheckOperationsSettings, logger);
            AddInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.AddInstanceOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.InsertOperationsSettings, logger);
            RemoveHealthCheckOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.RemoveHealthCheckOperationsSettings, logger);
            RemoveInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.RemoveInstanceOperationsSettings, logger);
            SetBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.SetBackupOperationsSettings, logger);
            SetSecurityPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.SetSecurityPolicyOperationsSettings, logger);
            _callAddHealthCheck = clientHelper.BuildApiCall<AddHealthCheckTargetPoolRequest, Operation>("AddHealthCheck", grpcClient.AddHealthCheckAsync, grpcClient.AddHealthCheck, effectiveSettings.AddHealthCheckSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callAddHealthCheck);
            Modify_AddHealthCheckApiCall(ref _callAddHealthCheck);
            _callAddInstance = clientHelper.BuildApiCall<AddInstanceTargetPoolRequest, Operation>("AddInstance", grpcClient.AddInstanceAsync, grpcClient.AddInstance, effectiveSettings.AddInstanceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callAddInstance);
            Modify_AddInstanceApiCall(ref _callAddInstance);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListTargetPoolsRequest, TargetPoolAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetPoolRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetPoolRequest, TargetPool>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetHealth = clientHelper.BuildApiCall<GetHealthTargetPoolRequest, TargetPoolInstanceHealth>("GetHealth", grpcClient.GetHealthAsync, grpcClient.GetHealth, effectiveSettings.GetHealthSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callGetHealth);
            Modify_GetHealthApiCall(ref _callGetHealth);
            _callInsert = clientHelper.BuildApiCall<InsertTargetPoolRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetPoolsRequest, TargetPoolList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callRemoveHealthCheck = clientHelper.BuildApiCall<RemoveHealthCheckTargetPoolRequest, Operation>("RemoveHealthCheck", grpcClient.RemoveHealthCheckAsync, grpcClient.RemoveHealthCheck, effectiveSettings.RemoveHealthCheckSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callRemoveHealthCheck);
            Modify_RemoveHealthCheckApiCall(ref _callRemoveHealthCheck);
            _callRemoveInstance = clientHelper.BuildApiCall<RemoveInstanceTargetPoolRequest, Operation>("RemoveInstance", grpcClient.RemoveInstanceAsync, grpcClient.RemoveInstance, effectiveSettings.RemoveInstanceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callRemoveInstance);
            Modify_RemoveInstanceApiCall(ref _callRemoveInstance);
            _callSetBackup = clientHelper.BuildApiCall<SetBackupTargetPoolRequest, Operation>("SetBackup", grpcClient.SetBackupAsync, grpcClient.SetBackup, effectiveSettings.SetBackupSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callSetBackup);
            Modify_SetBackupApiCall(ref _callSetBackup);
            _callSetSecurityPolicy = clientHelper.BuildApiCall<SetSecurityPolicyTargetPoolRequest, Operation>("SetSecurityPolicy", grpcClient.SetSecurityPolicyAsync, grpcClient.SetSecurityPolicy, effectiveSettings.SetSecurityPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_pool", request => request.TargetPool);
            Modify_ApiCall(ref _callSetSecurityPolicy);
            Modify_SetSecurityPolicyApiCall(ref _callSetSecurityPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddHealthCheckApiCall(ref gaxgrpc::ApiCall<AddHealthCheckTargetPoolRequest, Operation> call);

        partial void Modify_AddInstanceApiCall(ref gaxgrpc::ApiCall<AddInstanceTargetPoolRequest, Operation> call);

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListTargetPoolsRequest, TargetPoolAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetPoolRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetPoolRequest, TargetPool> call);

        partial void Modify_GetHealthApiCall(ref gaxgrpc::ApiCall<GetHealthTargetPoolRequest, TargetPoolInstanceHealth> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetPoolRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetPoolsRequest, TargetPoolList> call);

        partial void Modify_RemoveHealthCheckApiCall(ref gaxgrpc::ApiCall<RemoveHealthCheckTargetPoolRequest, Operation> call);

        partial void Modify_RemoveInstanceApiCall(ref gaxgrpc::ApiCall<RemoveInstanceTargetPoolRequest, Operation> call);

        partial void Modify_SetBackupApiCall(ref gaxgrpc::ApiCall<SetBackupTargetPoolRequest, Operation> call);

        partial void Modify_SetSecurityPolicyApiCall(ref gaxgrpc::ApiCall<SetSecurityPolicyTargetPoolRequest, Operation> call);

        partial void OnConstruction(TargetPools.TargetPoolsClient grpcClient, TargetPoolsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetPools client</summary>
        public override TargetPools.TargetPoolsClient GrpcClient { get; }

        partial void Modify_AddHealthCheckTargetPoolRequest(ref AddHealthCheckTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddInstanceTargetPoolRequest(ref AddInstanceTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregatedListTargetPoolsRequest(ref AggregatedListTargetPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetPoolRequest(ref DeleteTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetPoolRequest(ref GetTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHealthTargetPoolRequest(ref GetHealthTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetPoolRequest(ref InsertTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetPoolsRequest(ref ListTargetPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveHealthCheckTargetPoolRequest(ref RemoveHealthCheckTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveInstanceTargetPoolRequest(ref RemoveInstanceTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetBackupTargetPoolRequest(ref SetBackupTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSecurityPolicyTargetPoolRequest(ref SetSecurityPolicyTargetPoolRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddHealthCheck</c>.</summary>
        public override lro::OperationsClient AddHealthCheckOperationsClient { get; }

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddHealthCheck(AddHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddHealthCheckTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callAddHealthCheck.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddHealthCheckOperationsClient);
        }

        /// <summary>
        /// Adds health check URLs to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddHealthCheckAsync(AddHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddHealthCheckTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callAddHealthCheck.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddHealthCheckOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddInstance</c>.</summary>
        public override lro::OperationsClient AddInstanceOperationsClient { get; }

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddInstance(AddInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddInstanceTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callAddInstance.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddInstanceOperationsClient);
        }

        /// <summary>
        /// Adds an instance to a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddInstanceAsync(AddInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddInstanceTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callAddInstance.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddInstanceOperationsClient);
        }

        /// <summary>
        /// Retrieves an aggregated list of target pools. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>> AggregatedList(AggregatedListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListTargetPoolsRequest, TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of target pools. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>> AggregatedListAsync(AggregatedListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListTargetPoolsRequest, TargetPoolAggregatedList, scg::KeyValuePair<string, TargetPoolsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetPool Get(GetTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetPoolRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetPool> GetAsync(GetTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetPoolRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetPoolInstanceHealth GetHealth(GetHealthTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHealthTargetPoolRequest(ref request, ref callSettings);
            return _callGetHealth.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetPoolInstanceHealth> GetHealthAsync(GetHealthTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHealthTargetPoolRequest(ref request, ref callSettings);
            return _callGetHealth.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetPool"/> resources.</returns>
        public override gax::PagedEnumerable<TargetPoolList, TargetPool> List(ListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetPoolsRequest, TargetPoolList, TargetPool>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetPoolList, TargetPool> ListAsync(ListTargetPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetPoolsRequest, TargetPoolList, TargetPool>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RemoveHealthCheck</c>.</summary>
        public override lro::OperationsClient RemoveHealthCheckOperationsClient { get; }

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveHealthCheck(RemoveHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveHealthCheckTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callRemoveHealthCheck.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveHealthCheckOperationsClient);
        }

        /// <summary>
        /// Removes health check URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveHealthCheckTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callRemoveHealthCheck.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveHealthCheckOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveInstance</c>.</summary>
        public override lro::OperationsClient RemoveInstanceOperationsClient { get; }

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveInstance(RemoveInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveInstanceTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callRemoveInstance.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveInstanceOperationsClient);
        }

        /// <summary>
        /// Removes instance URL from a target pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveInstanceAsync(RemoveInstanceTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveInstanceTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callRemoveInstance.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetBackup</c>.</summary>
        public override lro::OperationsClient SetBackupOperationsClient { get; }

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetBackup(SetBackupTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackupTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callSetBackup.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetBackupOperationsClient);
        }

        /// <summary>
        /// Changes a backup target pool's configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetBackupAsync(SetBackupTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackupTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callSetBackup.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetSecurityPolicy</c>.</summary>
        public override lro::OperationsClient SetSecurityPolicyOperationsClient { get; }

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetSecurityPolicy(SetSecurityPolicyTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSecurityPolicyTargetPoolRequest(ref request, ref callSettings);
            Operation response = _callSetSecurityPolicy.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSecurityPolicyOperationsClient);
        }

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified target pool. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSecurityPolicyAsync(SetSecurityPolicyTargetPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSecurityPolicyTargetPoolRequest(ref request, ref callSettings);
            Operation response = await _callSetSecurityPolicy.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSecurityPolicyOperationsClient);
        }
    }

    public partial class AggregatedListTargetPoolsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListTargetPoolsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class TargetPoolAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, TargetPoolsScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, TargetPoolsScopedList>> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class TargetPoolList : gaxgrpc::IPageResponse<TargetPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetPool> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TargetPools
    {
        public partial class TargetPoolsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to RegionOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
