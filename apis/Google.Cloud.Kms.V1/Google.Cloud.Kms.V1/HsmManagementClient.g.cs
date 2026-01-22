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

namespace Google.Cloud.Kms.V1
{
    /// <summary>Settings for <see cref="HsmManagementClient"/> instances.</summary>
    public sealed partial class HsmManagementSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HsmManagementSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HsmManagementSettings"/>.</returns>
        public static HsmManagementSettings GetDefault() => new HsmManagementSettings();

        /// <summary>Constructs a new <see cref="HsmManagementSettings"/> object with default settings.</summary>
        public HsmManagementSettings()
        {
        }

        private HsmManagementSettings(HsmManagementSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSingleTenantHsmInstancesSettings = existing.ListSingleTenantHsmInstancesSettings;
            GetSingleTenantHsmInstanceSettings = existing.GetSingleTenantHsmInstanceSettings;
            CreateSingleTenantHsmInstanceSettings = existing.CreateSingleTenantHsmInstanceSettings;
            CreateSingleTenantHsmInstanceOperationsSettings = existing.CreateSingleTenantHsmInstanceOperationsSettings.Clone();
            CreateSingleTenantHsmInstanceProposalSettings = existing.CreateSingleTenantHsmInstanceProposalSettings;
            CreateSingleTenantHsmInstanceProposalOperationsSettings = existing.CreateSingleTenantHsmInstanceProposalOperationsSettings.Clone();
            ApproveSingleTenantHsmInstanceProposalSettings = existing.ApproveSingleTenantHsmInstanceProposalSettings;
            ExecuteSingleTenantHsmInstanceProposalSettings = existing.ExecuteSingleTenantHsmInstanceProposalSettings;
            ExecuteSingleTenantHsmInstanceProposalOperationsSettings = existing.ExecuteSingleTenantHsmInstanceProposalOperationsSettings.Clone();
            GetSingleTenantHsmInstanceProposalSettings = existing.GetSingleTenantHsmInstanceProposalSettings;
            ListSingleTenantHsmInstanceProposalsSettings = existing.ListSingleTenantHsmInstanceProposalsSettings;
            DeleteSingleTenantHsmInstanceProposalSettings = existing.DeleteSingleTenantHsmInstanceProposalSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(HsmManagementSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.ListSingleTenantHsmInstances</c> and
        /// <c>HsmManagementClient.ListSingleTenantHsmInstancesAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSingleTenantHsmInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.GetSingleTenantHsmInstance</c> and
        /// <c>HsmManagementClient.GetSingleTenantHsmInstanceAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSingleTenantHsmInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.CreateSingleTenantHsmInstance</c> and
        /// <c>HsmManagementClient.CreateSingleTenantHsmInstanceAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSingleTenantHsmInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HsmManagementClient.CreateSingleTenantHsmInstance</c> and
        /// <c>HsmManagementClient.CreateSingleTenantHsmInstanceAsync</c>.
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
        public lro::OperationsSettings CreateSingleTenantHsmInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.CreateSingleTenantHsmInstanceProposal</c> and
        /// <c>HsmManagementClient.CreateSingleTenantHsmInstanceProposalAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSingleTenantHsmInstanceProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HsmManagementClient.CreateSingleTenantHsmInstanceProposal</c>
        ///  and <c>HsmManagementClient.CreateSingleTenantHsmInstanceProposalAsync</c>.
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
        public lro::OperationsSettings CreateSingleTenantHsmInstanceProposalOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.ApproveSingleTenantHsmInstanceProposal</c> and
        /// <c>HsmManagementClient.ApproveSingleTenantHsmInstanceProposalAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApproveSingleTenantHsmInstanceProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.ExecuteSingleTenantHsmInstanceProposal</c> and
        /// <c>HsmManagementClient.ExecuteSingleTenantHsmInstanceProposalAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteSingleTenantHsmInstanceProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HsmManagementClient.ExecuteSingleTenantHsmInstanceProposal</c>
        ///  and <c>HsmManagementClient.ExecuteSingleTenantHsmInstanceProposalAsync</c>.
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
        public lro::OperationsSettings ExecuteSingleTenantHsmInstanceProposalOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.GetSingleTenantHsmInstanceProposal</c> and
        /// <c>HsmManagementClient.GetSingleTenantHsmInstanceProposalAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSingleTenantHsmInstanceProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.ListSingleTenantHsmInstanceProposals</c> and
        /// <c>HsmManagementClient.ListSingleTenantHsmInstanceProposalsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSingleTenantHsmInstanceProposalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HsmManagementClient.DeleteSingleTenantHsmInstanceProposal</c> and
        /// <c>HsmManagementClient.DeleteSingleTenantHsmInstanceProposalAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSingleTenantHsmInstanceProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HsmManagementSettings"/> object.</returns>
        public HsmManagementSettings Clone() => new HsmManagementSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HsmManagementClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class HsmManagementClientBuilder : gaxgrpc::ClientBuilderBase<HsmManagementClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HsmManagementSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HsmManagementClientBuilder() : base(HsmManagementClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HsmManagementClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HsmManagementClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HsmManagementClient Build()
        {
            HsmManagementClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HsmManagementClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HsmManagementClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HsmManagementClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HsmManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HsmManagementClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HsmManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HsmManagementClient.ChannelPool;
    }

    /// <summary>HsmManagement client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud HSM Management Service
    /// 
    /// Provides interfaces for managing HSM instances.
    /// 
    /// Implements a REST model with the following objects:
    /// * [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
    /// * [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
    /// </remarks>
    public abstract partial class HsmManagementClient
    {
        /// <summary>
        /// The default endpoint for the HsmManagement service, which is a host of "cloudkms.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudkms.googleapis.com:443";

        /// <summary>The default HsmManagement scopes.</summary>
        /// <remarks>
        /// The default HsmManagement scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloudkms</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloudkms",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HsmManagement.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HsmManagementClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HsmManagementClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HsmManagementClient"/>.</returns>
        public static stt::Task<HsmManagementClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HsmManagementClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HsmManagementClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HsmManagementClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HsmManagementClient"/>.</returns>
        public static HsmManagementClient Create() => new HsmManagementClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HsmManagementClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HsmManagementSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HsmManagementClient"/>.</returns>
        internal static HsmManagementClient Create(grpccore::CallInvoker callInvoker, HsmManagementSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HsmManagement.HsmManagementClient grpcClient = new HsmManagement.HsmManagementClient(callInvoker);
            return new HsmManagementClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HsmManagement client</summary>
        public virtual HsmManagement.HsmManagementClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstances(ListSingleTenantHsmInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstancesAsync(ListSingleTenantHsmInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance] to
        /// list, in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstancesRequest request = new ListSingleTenantHsmInstancesRequest
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
            return ListSingleTenantHsmInstances(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance] to
        /// list, in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstancesRequest request = new ListSingleTenantHsmInstancesRequest
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
            return ListSingleTenantHsmInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance] to
        /// list, in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstancesRequest request = new ListSingleTenantHsmInstancesRequest
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
            return ListSingleTenantHsmInstances(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance] to
        /// list, in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstancesRequest request = new ListSingleTenantHsmInstancesRequest
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
            return ListSingleTenantHsmInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SingleTenantHsmInstance GetSingleTenantHsmInstance(GetSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(GetSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(GetSingleTenantHsmInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetSingleTenantHsmInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SingleTenantHsmInstance GetSingleTenantHsmInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstance(new GetSingleTenantHsmInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstanceAsync(new GetSingleTenantHsmInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSingleTenantHsmInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SingleTenantHsmInstance GetSingleTenantHsmInstance(SingleTenantHsmInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstance(new GetSingleTenantHsmInstanceRequest
            {
                SingleTenantHsmInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(SingleTenantHsmInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstanceAsync(new GetSingleTenantHsmInstanceRequest
            {
                SingleTenantHsmInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(SingleTenantHsmInstanceName name, st::CancellationToken cancellationToken) =>
            GetSingleTenantHsmInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> CreateSingleTenantHsmInstance(CreateSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(CreateSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(CreateSingleTenantHsmInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateSingleTenantHsmInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSingleTenantHsmInstance</c>.</summary>
        public virtual lro::OperationsClient CreateSingleTenantHsmInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSingleTenantHsmInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> PollOnceCreateSingleTenantHsmInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSingleTenantHsmInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSingleTenantHsmInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> PollOnceCreateSingleTenantHsmInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSingleTenantHsmInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance], in
        /// the format `projects/*/locations/*`.
        /// </param>
        /// <param name="singleTenantHsmInstance">
        /// Required. An
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] with
        /// initial field values.
        /// </param>
        /// <param name="singleTenantHsmInstanceId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> CreateSingleTenantHsmInstance(string parent, SingleTenantHsmInstance singleTenantHsmInstance, string singleTenantHsmInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstance(new CreateSingleTenantHsmInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SingleTenantHsmInstanceId = singleTenantHsmInstanceId ?? "",
                SingleTenantHsmInstance = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstance, nameof(singleTenantHsmInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance], in
        /// the format `projects/*/locations/*`.
        /// </param>
        /// <param name="singleTenantHsmInstance">
        /// Required. An
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] with
        /// initial field values.
        /// </param>
        /// <param name="singleTenantHsmInstanceId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(string parent, SingleTenantHsmInstance singleTenantHsmInstance, string singleTenantHsmInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstanceAsync(new CreateSingleTenantHsmInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SingleTenantHsmInstanceId = singleTenantHsmInstanceId ?? "",
                SingleTenantHsmInstance = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstance, nameof(singleTenantHsmInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance], in
        /// the format `projects/*/locations/*`.
        /// </param>
        /// <param name="singleTenantHsmInstance">
        /// Required. An
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] with
        /// initial field values.
        /// </param>
        /// <param name="singleTenantHsmInstanceId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(string parent, SingleTenantHsmInstance singleTenantHsmInstance, string singleTenantHsmInstanceId, st::CancellationToken cancellationToken) =>
            CreateSingleTenantHsmInstanceAsync(parent, singleTenantHsmInstance, singleTenantHsmInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance], in
        /// the format `projects/*/locations/*`.
        /// </param>
        /// <param name="singleTenantHsmInstance">
        /// Required. An
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] with
        /// initial field values.
        /// </param>
        /// <param name="singleTenantHsmInstanceId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> CreateSingleTenantHsmInstance(gagr::LocationName parent, SingleTenantHsmInstance singleTenantHsmInstance, string singleTenantHsmInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstance(new CreateSingleTenantHsmInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SingleTenantHsmInstanceId = singleTenantHsmInstanceId ?? "",
                SingleTenantHsmInstance = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstance, nameof(singleTenantHsmInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance], in
        /// the format `projects/*/locations/*`.
        /// </param>
        /// <param name="singleTenantHsmInstance">
        /// Required. An
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] with
        /// initial field values.
        /// </param>
        /// <param name="singleTenantHsmInstanceId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(gagr::LocationName parent, SingleTenantHsmInstance singleTenantHsmInstance, string singleTenantHsmInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstanceAsync(new CreateSingleTenantHsmInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SingleTenantHsmInstanceId = singleTenantHsmInstanceId ?? "",
                SingleTenantHsmInstance = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstance, nameof(singleTenantHsmInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance], in
        /// the format `projects/*/locations/*`.
        /// </param>
        /// <param name="singleTenantHsmInstance">
        /// Required. An
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] with
        /// initial field values.
        /// </param>
        /// <param name="singleTenantHsmInstanceId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(gagr::LocationName parent, SingleTenantHsmInstance singleTenantHsmInstance, string singleTenantHsmInstanceId, st::CancellationToken cancellationToken) =>
            CreateSingleTenantHsmInstanceAsync(parent, singleTenantHsmInstance, singleTenantHsmInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> CreateSingleTenantHsmInstanceProposal(CreateSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(CreateSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(CreateSingleTenantHsmInstanceProposalRequest request, st::CancellationToken cancellationToken) =>
            CreateSingleTenantHsmInstanceProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSingleTenantHsmInstanceProposal</c>.</summary>
        public virtual lro::OperationsClient CreateSingleTenantHsmInstanceProposalOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSingleTenantHsmInstanceProposal</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> PollOnceCreateSingleTenantHsmInstanceProposal(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSingleTenantHsmInstanceProposalOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSingleTenantHsmInstanceProposal</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> PollOnceCreateSingleTenantHsmInstanceProposalAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSingleTenantHsmInstanceProposalOperationsClient, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// associated with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </param>
        /// <param name="singleTenantHsmInstanceProposal">
        /// Required. The
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to create.
        /// </param>
        /// <param name="singleTenantHsmInstanceProposalId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> CreateSingleTenantHsmInstanceProposal(string parent, SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal, string singleTenantHsmInstanceProposalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstanceProposal(new CreateSingleTenantHsmInstanceProposalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SingleTenantHsmInstanceProposalId = singleTenantHsmInstanceProposalId ?? "",
                SingleTenantHsmInstanceProposal = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstanceProposal, nameof(singleTenantHsmInstanceProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// associated with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </param>
        /// <param name="singleTenantHsmInstanceProposal">
        /// Required. The
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to create.
        /// </param>
        /// <param name="singleTenantHsmInstanceProposalId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(string parent, SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal, string singleTenantHsmInstanceProposalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstanceProposalAsync(new CreateSingleTenantHsmInstanceProposalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SingleTenantHsmInstanceProposalId = singleTenantHsmInstanceProposalId ?? "",
                SingleTenantHsmInstanceProposal = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstanceProposal, nameof(singleTenantHsmInstanceProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// associated with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </param>
        /// <param name="singleTenantHsmInstanceProposal">
        /// Required. The
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to create.
        /// </param>
        /// <param name="singleTenantHsmInstanceProposalId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(string parent, SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal, string singleTenantHsmInstanceProposalId, st::CancellationToken cancellationToken) =>
            CreateSingleTenantHsmInstanceProposalAsync(parent, singleTenantHsmInstanceProposal, singleTenantHsmInstanceProposalId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// associated with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </param>
        /// <param name="singleTenantHsmInstanceProposal">
        /// Required. The
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to create.
        /// </param>
        /// <param name="singleTenantHsmInstanceProposalId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> CreateSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceName parent, SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal, string singleTenantHsmInstanceProposalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstanceProposal(new CreateSingleTenantHsmInstanceProposalRequest
            {
                ParentAsSingleTenantHsmInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SingleTenantHsmInstanceProposalId = singleTenantHsmInstanceProposalId ?? "",
                SingleTenantHsmInstanceProposal = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstanceProposal, nameof(singleTenantHsmInstanceProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// associated with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </param>
        /// <param name="singleTenantHsmInstanceProposal">
        /// Required. The
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to create.
        /// </param>
        /// <param name="singleTenantHsmInstanceProposalId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceName parent, SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal, string singleTenantHsmInstanceProposalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSingleTenantHsmInstanceProposalAsync(new CreateSingleTenantHsmInstanceProposalRequest
            {
                ParentAsSingleTenantHsmInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SingleTenantHsmInstanceProposalId = singleTenantHsmInstanceProposalId ?? "",
                SingleTenantHsmInstanceProposal = gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstanceProposal, nameof(singleTenantHsmInstanceProposal)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.SingleTenantHsmInstance.name] of
        /// the [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
        /// associated with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </param>
        /// <param name="singleTenantHsmInstanceProposal">
        /// Required. The
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to create.
        /// </param>
        /// <param name="singleTenantHsmInstanceProposalId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceName parent, SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal, string singleTenantHsmInstanceProposalId, st::CancellationToken cancellationToken) =>
            CreateSingleTenantHsmInstanceProposalAsync(parent, singleTenantHsmInstanceProposal, singleTenantHsmInstanceProposalId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveSingleTenantHsmInstanceProposalResponse ApproveSingleTenantHsmInstanceProposal(ApproveSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(ApproveSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(ApproveSingleTenantHsmInstanceProposalRequest request, st::CancellationToken cancellationToken) =>
            ApproveSingleTenantHsmInstanceProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to approve.
        /// </param>
        /// <param name="quorumReply">
        /// Required. The reply to
        /// [QuorumParameters][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.QuorumParameters]
        /// for approving the proposal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveSingleTenantHsmInstanceProposalResponse ApproveSingleTenantHsmInstanceProposal(string name, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply, gaxgrpc::CallSettings callSettings = null) =>
            ApproveSingleTenantHsmInstanceProposal(new ApproveSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                QuorumReply = gax::GaxPreconditions.CheckNotNull(quorumReply, nameof(quorumReply)),
            }, callSettings);

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to approve.
        /// </param>
        /// <param name="quorumReply">
        /// Required. The reply to
        /// [QuorumParameters][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.QuorumParameters]
        /// for approving the proposal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(string name, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply, gaxgrpc::CallSettings callSettings = null) =>
            ApproveSingleTenantHsmInstanceProposalAsync(new ApproveSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                QuorumReply = gax::GaxPreconditions.CheckNotNull(quorumReply, nameof(quorumReply)),
            }, callSettings);

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to approve.
        /// </param>
        /// <param name="quorumReply">
        /// Required. The reply to
        /// [QuorumParameters][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.QuorumParameters]
        /// for approving the proposal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(string name, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply, st::CancellationToken cancellationToken) =>
            ApproveSingleTenantHsmInstanceProposalAsync(name, quorumReply, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to approve.
        /// </param>
        /// <param name="quorumReply">
        /// Required. The reply to
        /// [QuorumParameters][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.QuorumParameters]
        /// for approving the proposal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveSingleTenantHsmInstanceProposalResponse ApproveSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName name, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply, gaxgrpc::CallSettings callSettings = null) =>
            ApproveSingleTenantHsmInstanceProposal(new ApproveSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                QuorumReply = gax::GaxPreconditions.CheckNotNull(quorumReply, nameof(quorumReply)),
            }, callSettings);

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to approve.
        /// </param>
        /// <param name="quorumReply">
        /// Required. The reply to
        /// [QuorumParameters][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.QuorumParameters]
        /// for approving the proposal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply, gaxgrpc::CallSettings callSettings = null) =>
            ApproveSingleTenantHsmInstanceProposalAsync(new ApproveSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                QuorumReply = gax::GaxPreconditions.CheckNotNull(quorumReply, nameof(quorumReply)),
            }, callSettings);

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to approve.
        /// </param>
        /// <param name="quorumReply">
        /// Required. The reply to
        /// [QuorumParameters][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.QuorumParameters]
        /// for approving the proposal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply, st::CancellationToken cancellationToken) =>
            ApproveSingleTenantHsmInstanceProposalAsync(name, quorumReply, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> ExecuteSingleTenantHsmInstanceProposal(ExecuteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(ExecuteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(ExecuteSingleTenantHsmInstanceProposalRequest request, st::CancellationToken cancellationToken) =>
            ExecuteSingleTenantHsmInstanceProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExecuteSingleTenantHsmInstanceProposal</c>.</summary>
        public virtual lro::OperationsClient ExecuteSingleTenantHsmInstanceProposalOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExecuteSingleTenantHsmInstanceProposal</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> PollOnceExecuteSingleTenantHsmInstanceProposal(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExecuteSingleTenantHsmInstanceProposalOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExecuteSingleTenantHsmInstanceProposal</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> PollOnceExecuteSingleTenantHsmInstanceProposalAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExecuteSingleTenantHsmInstanceProposalOperationsClient, callSettings);

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> ExecuteSingleTenantHsmInstanceProposal(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSingleTenantHsmInstanceProposal(new ExecuteSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSingleTenantHsmInstanceProposalAsync(new ExecuteSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to execute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(string name, st::CancellationToken cancellationToken) =>
            ExecuteSingleTenantHsmInstanceProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> ExecuteSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSingleTenantHsmInstanceProposal(new ExecuteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSingleTenantHsmInstanceProposalAsync(new ExecuteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to execute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, st::CancellationToken cancellationToken) =>
            ExecuteSingleTenantHsmInstanceProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SingleTenantHsmInstanceProposal GetSingleTenantHsmInstanceProposal(GetSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(GetSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(GetSingleTenantHsmInstanceProposalRequest request, st::CancellationToken cancellationToken) =>
            GetSingleTenantHsmInstanceProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SingleTenantHsmInstanceProposal GetSingleTenantHsmInstanceProposal(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstanceProposal(new GetSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstanceProposalAsync(new GetSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(string name, st::CancellationToken cancellationToken) =>
            GetSingleTenantHsmInstanceProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SingleTenantHsmInstanceProposal GetSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstanceProposal(new GetSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSingleTenantHsmInstanceProposalAsync(new GetSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, st::CancellationToken cancellationToken) =>
            GetSingleTenantHsmInstanceProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposals(ListSingleTenantHsmInstanceProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposalsAsync(ListSingleTenantHsmInstanceProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the single tenant HSM instance associated
        /// with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to list, in the format `projects/*/locations/*/singleTenantHsmInstances/*`.
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
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposals(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstanceProposalsRequest request = new ListSingleTenantHsmInstanceProposalsRequest
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
            return ListSingleTenantHsmInstanceProposals(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the single tenant HSM instance associated
        /// with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to list, in the format `projects/*/locations/*/singleTenantHsmInstances/*`.
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
        /// A pageable asynchronous sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposalsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstanceProposalsRequest request = new ListSingleTenantHsmInstanceProposalsRequest
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
            return ListSingleTenantHsmInstanceProposalsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the single tenant HSM instance associated
        /// with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to list, in the format `projects/*/locations/*/singleTenantHsmInstances/*`.
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
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposals(SingleTenantHsmInstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstanceProposalsRequest request = new ListSingleTenantHsmInstanceProposalsRequest
            {
                ParentAsSingleTenantHsmInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSingleTenantHsmInstanceProposals(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the single tenant HSM instance associated
        /// with the
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to list, in the format `projects/*/locations/*/singleTenantHsmInstances/*`.
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
        /// A pageable asynchronous sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposalsAsync(SingleTenantHsmInstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSingleTenantHsmInstanceProposalsRequest request = new ListSingleTenantHsmInstanceProposalsRequest
            {
                ParentAsSingleTenantHsmInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSingleTenantHsmInstanceProposalsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSingleTenantHsmInstanceProposal(DeleteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSingleTenantHsmInstanceProposalAsync(DeleteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSingleTenantHsmInstanceProposalAsync(DeleteSingleTenantHsmInstanceProposalRequest request, st::CancellationToken cancellationToken) =>
            DeleteSingleTenantHsmInstanceProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSingleTenantHsmInstanceProposal(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSingleTenantHsmInstanceProposal(new DeleteSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSingleTenantHsmInstanceProposalAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSingleTenantHsmInstanceProposalAsync(new DeleteSingleTenantHsmInstanceProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSingleTenantHsmInstanceProposalAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSingleTenantHsmInstanceProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSingleTenantHsmInstanceProposal(new DeleteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSingleTenantHsmInstanceProposalAsync(new DeleteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.name] of the
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName name, st::CancellationToken cancellationToken) =>
            DeleteSingleTenantHsmInstanceProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HsmManagement client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud HSM Management Service
    /// 
    /// Provides interfaces for managing HSM instances.
    /// 
    /// Implements a REST model with the following objects:
    /// * [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]
    /// * [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
    /// </remarks>
    public sealed partial class HsmManagementClientImpl : HsmManagementClient
    {
        private readonly gaxgrpc::ApiCall<ListSingleTenantHsmInstancesRequest, ListSingleTenantHsmInstancesResponse> _callListSingleTenantHsmInstances;

        private readonly gaxgrpc::ApiCall<GetSingleTenantHsmInstanceRequest, SingleTenantHsmInstance> _callGetSingleTenantHsmInstance;

        private readonly gaxgrpc::ApiCall<CreateSingleTenantHsmInstanceRequest, lro::Operation> _callCreateSingleTenantHsmInstance;

        private readonly gaxgrpc::ApiCall<CreateSingleTenantHsmInstanceProposalRequest, lro::Operation> _callCreateSingleTenantHsmInstanceProposal;

        private readonly gaxgrpc::ApiCall<ApproveSingleTenantHsmInstanceProposalRequest, ApproveSingleTenantHsmInstanceProposalResponse> _callApproveSingleTenantHsmInstanceProposal;

        private readonly gaxgrpc::ApiCall<ExecuteSingleTenantHsmInstanceProposalRequest, lro::Operation> _callExecuteSingleTenantHsmInstanceProposal;

        private readonly gaxgrpc::ApiCall<GetSingleTenantHsmInstanceProposalRequest, SingleTenantHsmInstanceProposal> _callGetSingleTenantHsmInstanceProposal;

        private readonly gaxgrpc::ApiCall<ListSingleTenantHsmInstanceProposalsRequest, ListSingleTenantHsmInstanceProposalsResponse> _callListSingleTenantHsmInstanceProposals;

        private readonly gaxgrpc::ApiCall<DeleteSingleTenantHsmInstanceProposalRequest, wkt::Empty> _callDeleteSingleTenantHsmInstanceProposal;

        /// <summary>
        /// Constructs a client wrapper for the HsmManagement service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HsmManagementSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HsmManagementClientImpl(HsmManagement.HsmManagementClient grpcClient, HsmManagementSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HsmManagementSettings effectiveSettings = settings ?? HsmManagementSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSingleTenantHsmInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSingleTenantHsmInstanceOperationsSettings, logger);
            CreateSingleTenantHsmInstanceProposalOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSingleTenantHsmInstanceProposalOperationsSettings, logger);
            ExecuteSingleTenantHsmInstanceProposalOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExecuteSingleTenantHsmInstanceProposalOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListSingleTenantHsmInstances = clientHelper.BuildApiCall<ListSingleTenantHsmInstancesRequest, ListSingleTenantHsmInstancesResponse>("ListSingleTenantHsmInstances", grpcClient.ListSingleTenantHsmInstancesAsync, grpcClient.ListSingleTenantHsmInstances, effectiveSettings.ListSingleTenantHsmInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSingleTenantHsmInstances);
            Modify_ListSingleTenantHsmInstancesApiCall(ref _callListSingleTenantHsmInstances);
            _callGetSingleTenantHsmInstance = clientHelper.BuildApiCall<GetSingleTenantHsmInstanceRequest, SingleTenantHsmInstance>("GetSingleTenantHsmInstance", grpcClient.GetSingleTenantHsmInstanceAsync, grpcClient.GetSingleTenantHsmInstance, effectiveSettings.GetSingleTenantHsmInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSingleTenantHsmInstance);
            Modify_GetSingleTenantHsmInstanceApiCall(ref _callGetSingleTenantHsmInstance);
            _callCreateSingleTenantHsmInstance = clientHelper.BuildApiCall<CreateSingleTenantHsmInstanceRequest, lro::Operation>("CreateSingleTenantHsmInstance", grpcClient.CreateSingleTenantHsmInstanceAsync, grpcClient.CreateSingleTenantHsmInstance, effectiveSettings.CreateSingleTenantHsmInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSingleTenantHsmInstance);
            Modify_CreateSingleTenantHsmInstanceApiCall(ref _callCreateSingleTenantHsmInstance);
            _callCreateSingleTenantHsmInstanceProposal = clientHelper.BuildApiCall<CreateSingleTenantHsmInstanceProposalRequest, lro::Operation>("CreateSingleTenantHsmInstanceProposal", grpcClient.CreateSingleTenantHsmInstanceProposalAsync, grpcClient.CreateSingleTenantHsmInstanceProposal, effectiveSettings.CreateSingleTenantHsmInstanceProposalSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSingleTenantHsmInstanceProposal);
            Modify_CreateSingleTenantHsmInstanceProposalApiCall(ref _callCreateSingleTenantHsmInstanceProposal);
            _callApproveSingleTenantHsmInstanceProposal = clientHelper.BuildApiCall<ApproveSingleTenantHsmInstanceProposalRequest, ApproveSingleTenantHsmInstanceProposalResponse>("ApproveSingleTenantHsmInstanceProposal", grpcClient.ApproveSingleTenantHsmInstanceProposalAsync, grpcClient.ApproveSingleTenantHsmInstanceProposal, effectiveSettings.ApproveSingleTenantHsmInstanceProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveSingleTenantHsmInstanceProposal);
            Modify_ApproveSingleTenantHsmInstanceProposalApiCall(ref _callApproveSingleTenantHsmInstanceProposal);
            _callExecuteSingleTenantHsmInstanceProposal = clientHelper.BuildApiCall<ExecuteSingleTenantHsmInstanceProposalRequest, lro::Operation>("ExecuteSingleTenantHsmInstanceProposal", grpcClient.ExecuteSingleTenantHsmInstanceProposalAsync, grpcClient.ExecuteSingleTenantHsmInstanceProposal, effectiveSettings.ExecuteSingleTenantHsmInstanceProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExecuteSingleTenantHsmInstanceProposal);
            Modify_ExecuteSingleTenantHsmInstanceProposalApiCall(ref _callExecuteSingleTenantHsmInstanceProposal);
            _callGetSingleTenantHsmInstanceProposal = clientHelper.BuildApiCall<GetSingleTenantHsmInstanceProposalRequest, SingleTenantHsmInstanceProposal>("GetSingleTenantHsmInstanceProposal", grpcClient.GetSingleTenantHsmInstanceProposalAsync, grpcClient.GetSingleTenantHsmInstanceProposal, effectiveSettings.GetSingleTenantHsmInstanceProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSingleTenantHsmInstanceProposal);
            Modify_GetSingleTenantHsmInstanceProposalApiCall(ref _callGetSingleTenantHsmInstanceProposal);
            _callListSingleTenantHsmInstanceProposals = clientHelper.BuildApiCall<ListSingleTenantHsmInstanceProposalsRequest, ListSingleTenantHsmInstanceProposalsResponse>("ListSingleTenantHsmInstanceProposals", grpcClient.ListSingleTenantHsmInstanceProposalsAsync, grpcClient.ListSingleTenantHsmInstanceProposals, effectiveSettings.ListSingleTenantHsmInstanceProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSingleTenantHsmInstanceProposals);
            Modify_ListSingleTenantHsmInstanceProposalsApiCall(ref _callListSingleTenantHsmInstanceProposals);
            _callDeleteSingleTenantHsmInstanceProposal = clientHelper.BuildApiCall<DeleteSingleTenantHsmInstanceProposalRequest, wkt::Empty>("DeleteSingleTenantHsmInstanceProposal", grpcClient.DeleteSingleTenantHsmInstanceProposalAsync, grpcClient.DeleteSingleTenantHsmInstanceProposal, effectiveSettings.DeleteSingleTenantHsmInstanceProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSingleTenantHsmInstanceProposal);
            Modify_DeleteSingleTenantHsmInstanceProposalApiCall(ref _callDeleteSingleTenantHsmInstanceProposal);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListSingleTenantHsmInstancesApiCall(ref gaxgrpc::ApiCall<ListSingleTenantHsmInstancesRequest, ListSingleTenantHsmInstancesResponse> call);

        partial void Modify_GetSingleTenantHsmInstanceApiCall(ref gaxgrpc::ApiCall<GetSingleTenantHsmInstanceRequest, SingleTenantHsmInstance> call);

        partial void Modify_CreateSingleTenantHsmInstanceApiCall(ref gaxgrpc::ApiCall<CreateSingleTenantHsmInstanceRequest, lro::Operation> call);

        partial void Modify_CreateSingleTenantHsmInstanceProposalApiCall(ref gaxgrpc::ApiCall<CreateSingleTenantHsmInstanceProposalRequest, lro::Operation> call);

        partial void Modify_ApproveSingleTenantHsmInstanceProposalApiCall(ref gaxgrpc::ApiCall<ApproveSingleTenantHsmInstanceProposalRequest, ApproveSingleTenantHsmInstanceProposalResponse> call);

        partial void Modify_ExecuteSingleTenantHsmInstanceProposalApiCall(ref gaxgrpc::ApiCall<ExecuteSingleTenantHsmInstanceProposalRequest, lro::Operation> call);

        partial void Modify_GetSingleTenantHsmInstanceProposalApiCall(ref gaxgrpc::ApiCall<GetSingleTenantHsmInstanceProposalRequest, SingleTenantHsmInstanceProposal> call);

        partial void Modify_ListSingleTenantHsmInstanceProposalsApiCall(ref gaxgrpc::ApiCall<ListSingleTenantHsmInstanceProposalsRequest, ListSingleTenantHsmInstanceProposalsResponse> call);

        partial void Modify_DeleteSingleTenantHsmInstanceProposalApiCall(ref gaxgrpc::ApiCall<DeleteSingleTenantHsmInstanceProposalRequest, wkt::Empty> call);

        partial void OnConstruction(HsmManagement.HsmManagementClient grpcClient, HsmManagementSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HsmManagement client</summary>
        public override HsmManagement.HsmManagementClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListSingleTenantHsmInstancesRequest(ref ListSingleTenantHsmInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSingleTenantHsmInstanceRequest(ref GetSingleTenantHsmInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSingleTenantHsmInstanceRequest(ref CreateSingleTenantHsmInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSingleTenantHsmInstanceProposalRequest(ref CreateSingleTenantHsmInstanceProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveSingleTenantHsmInstanceProposalRequest(ref ApproveSingleTenantHsmInstanceProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteSingleTenantHsmInstanceProposalRequest(ref ExecuteSingleTenantHsmInstanceProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSingleTenantHsmInstanceProposalRequest(ref GetSingleTenantHsmInstanceProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSingleTenantHsmInstanceProposalsRequest(ref ListSingleTenantHsmInstanceProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSingleTenantHsmInstanceProposalRequest(ref DeleteSingleTenantHsmInstanceProposalRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public override gax::PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstances(ListSingleTenantHsmInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSingleTenantHsmInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSingleTenantHsmInstancesRequest, ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance>(_callListSingleTenantHsmInstances, request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstances][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SingleTenantHsmInstance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> ListSingleTenantHsmInstancesAsync(ListSingleTenantHsmInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSingleTenantHsmInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSingleTenantHsmInstancesRequest, ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance>(_callListSingleTenantHsmInstances, request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SingleTenantHsmInstance GetSingleTenantHsmInstance(GetSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSingleTenantHsmInstanceRequest(ref request, ref callSettings);
            return _callGetSingleTenantHsmInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SingleTenantHsmInstance> GetSingleTenantHsmInstanceAsync(GetSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSingleTenantHsmInstanceRequest(ref request, ref callSettings);
            return _callGetSingleTenantHsmInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSingleTenantHsmInstance</c>.</summary>
        public override lro::OperationsClient CreateSingleTenantHsmInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> CreateSingleTenantHsmInstance(CreateSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSingleTenantHsmInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>(_callCreateSingleTenantHsmInstance.Sync(request, callSettings), CreateSingleTenantHsmInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance] in a
        /// given Project and Location. User must create a RegisterTwoFactorAuthKeys
        /// proposal with this single-tenant HSM instance to finish setup of the
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>> CreateSingleTenantHsmInstanceAsync(CreateSingleTenantHsmInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSingleTenantHsmInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata>(await _callCreateSingleTenantHsmInstance.Async(request, callSettings).ConfigureAwait(false), CreateSingleTenantHsmInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateSingleTenantHsmInstanceProposal</c>.</summary>
        public override lro::OperationsClient CreateSingleTenantHsmInstanceProposalOperationsClient { get; }

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> CreateSingleTenantHsmInstanceProposal(CreateSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return new lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>(_callCreateSingleTenantHsmInstanceProposal.Sync(request, callSettings), CreateSingleTenantHsmInstanceProposalOperationsClient);
        }

        /// <summary>
        /// Creates a new
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>> CreateSingleTenantHsmInstanceProposalAsync(CreateSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return new lro::Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata>(await _callCreateSingleTenantHsmInstanceProposal.Async(request, callSettings).ConfigureAwait(false), CreateSingleTenantHsmInstanceProposalOperationsClient);
        }

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApproveSingleTenantHsmInstanceProposalResponse ApproveSingleTenantHsmInstanceProposal(ApproveSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return _callApproveSingleTenantHsmInstanceProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [PENDING][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.PENDING]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApproveSingleTenantHsmInstanceProposalResponse> ApproveSingleTenantHsmInstanceProposalAsync(ApproveSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return _callApproveSingleTenantHsmInstanceProposal.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExecuteSingleTenantHsmInstanceProposal</c>.</summary>
        public override lro::OperationsClient ExecuteSingleTenantHsmInstanceProposalOperationsClient { get; }

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> ExecuteSingleTenantHsmInstanceProposal(ExecuteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return new lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>(_callExecuteSingleTenantHsmInstanceProposal.Sync(request, callSettings), ExecuteSingleTenantHsmInstanceProposalOperationsClient);
        }

        /// <summary>
        /// Executes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal]
        /// for a given
        /// [SingleTenantHsmInstance][google.cloud.kms.v1.SingleTenantHsmInstance]. The
        /// proposal must be in the
        /// [APPROVED][google.cloud.kms.v1.SingleTenantHsmInstanceProposal.State.APPROVED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>> ExecuteSingleTenantHsmInstanceProposalAsync(ExecuteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return new lro::Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata>(await _callExecuteSingleTenantHsmInstanceProposal.Async(request, callSettings).ConfigureAwait(false), ExecuteSingleTenantHsmInstanceProposalOperationsClient);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SingleTenantHsmInstanceProposal GetSingleTenantHsmInstanceProposal(GetSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return _callGetSingleTenantHsmInstanceProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SingleTenantHsmInstanceProposal> GetSingleTenantHsmInstanceProposalAsync(GetSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return _callGetSingleTenantHsmInstanceProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.</returns>
        public override gax::PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposals(ListSingleTenantHsmInstanceProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSingleTenantHsmInstanceProposalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSingleTenantHsmInstanceProposalsRequest, ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal>(_callListSingleTenantHsmInstanceProposals, request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [SingleTenantHsmInstanceProposals][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SingleTenantHsmInstanceProposal"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> ListSingleTenantHsmInstanceProposalsAsync(ListSingleTenantHsmInstanceProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSingleTenantHsmInstanceProposalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsRequest, ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal>(_callListSingleTenantHsmInstanceProposals, request, callSettings);
        }

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSingleTenantHsmInstanceProposal(DeleteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            _callDeleteSingleTenantHsmInstanceProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a
        /// [SingleTenantHsmInstanceProposal][google.cloud.kms.v1.SingleTenantHsmInstanceProposal].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSingleTenantHsmInstanceProposalAsync(DeleteSingleTenantHsmInstanceProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSingleTenantHsmInstanceProposalRequest(ref request, ref callSettings);
            return _callDeleteSingleTenantHsmInstanceProposal.Async(request, callSettings);
        }
    }

    public partial class ListSingleTenantHsmInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSingleTenantHsmInstanceProposalsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSingleTenantHsmInstancesResponse : gaxgrpc::IPageResponse<SingleTenantHsmInstance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SingleTenantHsmInstance> GetEnumerator() => SingleTenantHsmInstances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSingleTenantHsmInstanceProposalsResponse : gaxgrpc::IPageResponse<SingleTenantHsmInstanceProposal>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SingleTenantHsmInstanceProposal> GetEnumerator() =>
            SingleTenantHsmInstanceProposals.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class HsmManagement
    {
        public partial class HsmManagementClient
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

    public static partial class HsmManagement
    {
        public partial class HsmManagementClient
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
