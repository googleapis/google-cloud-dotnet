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

namespace Google.Cloud.CloudDms.V1
{
    /// <summary>Settings for <see cref="DataMigrationServiceClient"/> instances.</summary>
    public sealed partial class DataMigrationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataMigrationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataMigrationServiceSettings"/>.</returns>
        public static DataMigrationServiceSettings GetDefault() => new DataMigrationServiceSettings();

        /// <summary>Constructs a new <see cref="DataMigrationServiceSettings"/> object with default settings.</summary>
        public DataMigrationServiceSettings()
        {
        }

        private DataMigrationServiceSettings(DataMigrationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMigrationJobsSettings = existing.ListMigrationJobsSettings;
            GetMigrationJobSettings = existing.GetMigrationJobSettings;
            CreateMigrationJobSettings = existing.CreateMigrationJobSettings;
            CreateMigrationJobOperationsSettings = existing.CreateMigrationJobOperationsSettings.Clone();
            UpdateMigrationJobSettings = existing.UpdateMigrationJobSettings;
            UpdateMigrationJobOperationsSettings = existing.UpdateMigrationJobOperationsSettings.Clone();
            DeleteMigrationJobSettings = existing.DeleteMigrationJobSettings;
            DeleteMigrationJobOperationsSettings = existing.DeleteMigrationJobOperationsSettings.Clone();
            StartMigrationJobSettings = existing.StartMigrationJobSettings;
            StartMigrationJobOperationsSettings = existing.StartMigrationJobOperationsSettings.Clone();
            StopMigrationJobSettings = existing.StopMigrationJobSettings;
            StopMigrationJobOperationsSettings = existing.StopMigrationJobOperationsSettings.Clone();
            ResumeMigrationJobSettings = existing.ResumeMigrationJobSettings;
            ResumeMigrationJobOperationsSettings = existing.ResumeMigrationJobOperationsSettings.Clone();
            PromoteMigrationJobSettings = existing.PromoteMigrationJobSettings;
            PromoteMigrationJobOperationsSettings = existing.PromoteMigrationJobOperationsSettings.Clone();
            VerifyMigrationJobSettings = existing.VerifyMigrationJobSettings;
            VerifyMigrationJobOperationsSettings = existing.VerifyMigrationJobOperationsSettings.Clone();
            RestartMigrationJobSettings = existing.RestartMigrationJobSettings;
            RestartMigrationJobOperationsSettings = existing.RestartMigrationJobOperationsSettings.Clone();
            GenerateSshScriptSettings = existing.GenerateSshScriptSettings;
            GenerateTcpProxyScriptSettings = existing.GenerateTcpProxyScriptSettings;
            ListConnectionProfilesSettings = existing.ListConnectionProfilesSettings;
            GetConnectionProfileSettings = existing.GetConnectionProfileSettings;
            CreateConnectionProfileSettings = existing.CreateConnectionProfileSettings;
            CreateConnectionProfileOperationsSettings = existing.CreateConnectionProfileOperationsSettings.Clone();
            UpdateConnectionProfileSettings = existing.UpdateConnectionProfileSettings;
            UpdateConnectionProfileOperationsSettings = existing.UpdateConnectionProfileOperationsSettings.Clone();
            DeleteConnectionProfileSettings = existing.DeleteConnectionProfileSettings;
            DeleteConnectionProfileOperationsSettings = existing.DeleteConnectionProfileOperationsSettings.Clone();
            CreatePrivateConnectionSettings = existing.CreatePrivateConnectionSettings;
            CreatePrivateConnectionOperationsSettings = existing.CreatePrivateConnectionOperationsSettings.Clone();
            GetPrivateConnectionSettings = existing.GetPrivateConnectionSettings;
            ListPrivateConnectionsSettings = existing.ListPrivateConnectionsSettings;
            DeletePrivateConnectionSettings = existing.DeletePrivateConnectionSettings;
            DeletePrivateConnectionOperationsSettings = existing.DeletePrivateConnectionOperationsSettings.Clone();
            GetConversionWorkspaceSettings = existing.GetConversionWorkspaceSettings;
            ListConversionWorkspacesSettings = existing.ListConversionWorkspacesSettings;
            CreateConversionWorkspaceSettings = existing.CreateConversionWorkspaceSettings;
            CreateConversionWorkspaceOperationsSettings = existing.CreateConversionWorkspaceOperationsSettings.Clone();
            UpdateConversionWorkspaceSettings = existing.UpdateConversionWorkspaceSettings;
            UpdateConversionWorkspaceOperationsSettings = existing.UpdateConversionWorkspaceOperationsSettings.Clone();
            DeleteConversionWorkspaceSettings = existing.DeleteConversionWorkspaceSettings;
            DeleteConversionWorkspaceOperationsSettings = existing.DeleteConversionWorkspaceOperationsSettings.Clone();
            CreateMappingRuleSettings = existing.CreateMappingRuleSettings;
            DeleteMappingRuleSettings = existing.DeleteMappingRuleSettings;
            ListMappingRulesSettings = existing.ListMappingRulesSettings;
            GetMappingRuleSettings = existing.GetMappingRuleSettings;
            SeedConversionWorkspaceSettings = existing.SeedConversionWorkspaceSettings;
            SeedConversionWorkspaceOperationsSettings = existing.SeedConversionWorkspaceOperationsSettings.Clone();
            ImportMappingRulesSettings = existing.ImportMappingRulesSettings;
            ImportMappingRulesOperationsSettings = existing.ImportMappingRulesOperationsSettings.Clone();
            ConvertConversionWorkspaceSettings = existing.ConvertConversionWorkspaceSettings;
            ConvertConversionWorkspaceOperationsSettings = existing.ConvertConversionWorkspaceOperationsSettings.Clone();
            CommitConversionWorkspaceSettings = existing.CommitConversionWorkspaceSettings;
            CommitConversionWorkspaceOperationsSettings = existing.CommitConversionWorkspaceOperationsSettings.Clone();
            RollbackConversionWorkspaceSettings = existing.RollbackConversionWorkspaceSettings;
            RollbackConversionWorkspaceOperationsSettings = existing.RollbackConversionWorkspaceOperationsSettings.Clone();
            ApplyConversionWorkspaceSettings = existing.ApplyConversionWorkspaceSettings;
            ApplyConversionWorkspaceOperationsSettings = existing.ApplyConversionWorkspaceOperationsSettings.Clone();
            DescribeDatabaseEntitiesSettings = existing.DescribeDatabaseEntitiesSettings;
            SearchBackgroundJobsSettings = existing.SearchBackgroundJobsSettings;
            DescribeConversionWorkspaceRevisionsSettings = existing.DescribeConversionWorkspaceRevisionsSettings;
            FetchStaticIpsSettings = existing.FetchStaticIpsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataMigrationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListMigrationJobs</c> and <c>DataMigrationServiceClient.ListMigrationJobsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMigrationJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetMigrationJob</c> and <c>DataMigrationServiceClient.GetMigrationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.CreateMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CreateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.CreateMigrationJobAsync</c>.
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
        public lro::OperationsSettings CreateMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.UpdateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.UpdateMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.UpdateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.UpdateMigrationJobAsync</c>.
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
        public lro::OperationsSettings UpdateMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeleteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.DeleteMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.DeleteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.DeleteMigrationJobAsync</c>.
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
        public lro::OperationsSettings DeleteMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.StartMigrationJob</c> and <c>DataMigrationServiceClient.StartMigrationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.StartMigrationJob</c> and
        /// <c>DataMigrationServiceClient.StartMigrationJobAsync</c>.
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
        public lro::OperationsSettings StartMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.StopMigrationJob</c> and <c>DataMigrationServiceClient.StopMigrationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.StopMigrationJob</c> and
        /// <c>DataMigrationServiceClient.StopMigrationJobAsync</c>.
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
        public lro::OperationsSettings StopMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ResumeMigrationJob</c> and
        /// <c>DataMigrationServiceClient.ResumeMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.ResumeMigrationJob</c> and
        /// <c>DataMigrationServiceClient.ResumeMigrationJobAsync</c>.
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
        public lro::OperationsSettings ResumeMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.PromoteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.PromoteMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PromoteMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.PromoteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.PromoteMigrationJobAsync</c>.
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
        public lro::OperationsSettings PromoteMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.VerifyMigrationJob</c> and
        /// <c>DataMigrationServiceClient.VerifyMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.VerifyMigrationJob</c> and
        /// <c>DataMigrationServiceClient.VerifyMigrationJobAsync</c>.
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
        public lro::OperationsSettings VerifyMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.RestartMigrationJob</c> and
        /// <c>DataMigrationServiceClient.RestartMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestartMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.RestartMigrationJob</c> and
        /// <c>DataMigrationServiceClient.RestartMigrationJobAsync</c>.
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
        public lro::OperationsSettings RestartMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GenerateSshScript</c> and <c>DataMigrationServiceClient.GenerateSshScriptAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateSshScriptSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GenerateTcpProxyScript</c> and
        /// <c>DataMigrationServiceClient.GenerateTcpProxyScriptAsync</c>.
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
        public gaxgrpc::CallSettings GenerateTcpProxyScriptSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListConnectionProfiles</c> and
        /// <c>DataMigrationServiceClient.ListConnectionProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectionProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.GetConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.CreateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CreateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.CreateConnectionProfileAsync</c>.
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
        public lro::OperationsSettings CreateConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.UpdateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.UpdateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.UpdateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.UpdateConnectionProfileAsync</c>.
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
        public lro::OperationsSettings UpdateConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeleteConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.DeleteConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.DeleteConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.DeleteConnectionProfileAsync</c>.
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
        public lro::OperationsSettings DeleteConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreatePrivateConnection</c> and
        /// <c>DataMigrationServiceClient.CreatePrivateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CreatePrivateConnection</c> and
        /// <c>DataMigrationServiceClient.CreatePrivateConnectionAsync</c>.
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
        public lro::OperationsSettings CreatePrivateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetPrivateConnection</c> and
        /// <c>DataMigrationServiceClient.GetPrivateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPrivateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListPrivateConnections</c> and
        /// <c>DataMigrationServiceClient.ListPrivateConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPrivateConnectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeletePrivateConnection</c> and
        /// <c>DataMigrationServiceClient.DeletePrivateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePrivateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.DeletePrivateConnection</c> and
        /// <c>DataMigrationServiceClient.DeletePrivateConnectionAsync</c>.
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
        public lro::OperationsSettings DeletePrivateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.GetConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListConversionWorkspaces</c> and
        /// <c>DataMigrationServiceClient.ListConversionWorkspacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConversionWorkspacesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreateConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.CreateConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CreateConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.CreateConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings CreateConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.UpdateConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.UpdateConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.UpdateConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.UpdateConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings UpdateConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeleteConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.DeleteConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.DeleteConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.DeleteConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings DeleteConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreateMappingRule</c> and <c>DataMigrationServiceClient.CreateMappingRuleAsync</c>
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
        public gaxgrpc::CallSettings CreateMappingRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeleteMappingRule</c> and <c>DataMigrationServiceClient.DeleteMappingRuleAsync</c>
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
        public gaxgrpc::CallSettings DeleteMappingRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListMappingRules</c> and <c>DataMigrationServiceClient.ListMappingRulesAsync</c>
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
        public gaxgrpc::CallSettings ListMappingRulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetMappingRule</c> and <c>DataMigrationServiceClient.GetMappingRuleAsync</c>.
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
        public gaxgrpc::CallSettings GetMappingRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.SeedConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.SeedConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SeedConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.SeedConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.SeedConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings SeedConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ImportMappingRules</c> and
        /// <c>DataMigrationServiceClient.ImportMappingRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportMappingRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.ImportMappingRules</c> and
        /// <c>DataMigrationServiceClient.ImportMappingRulesAsync</c>.
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
        public lro::OperationsSettings ImportMappingRulesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ConvertConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.ConvertConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConvertConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.ConvertConversionWorkspace</c>
        /// and <c>DataMigrationServiceClient.ConvertConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings ConvertConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CommitConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.CommitConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CommitConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.CommitConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings CommitConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.RollbackConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.RollbackConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.RollbackConversionWorkspace</c>
        /// and <c>DataMigrationServiceClient.RollbackConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings RollbackConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ApplyConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.ApplyConversionWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApplyConversionWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.ApplyConversionWorkspace</c> and
        /// <c>DataMigrationServiceClient.ApplyConversionWorkspaceAsync</c>.
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
        public lro::OperationsSettings ApplyConversionWorkspaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DescribeDatabaseEntities</c> and
        /// <c>DataMigrationServiceClient.DescribeDatabaseEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DescribeDatabaseEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.SearchBackgroundJobs</c> and
        /// <c>DataMigrationServiceClient.SearchBackgroundJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchBackgroundJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DescribeConversionWorkspaceRevisions</c> and
        /// <c>DataMigrationServiceClient.DescribeConversionWorkspaceRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DescribeConversionWorkspaceRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.FetchStaticIps</c> and <c>DataMigrationServiceClient.FetchStaticIpsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchStaticIpsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataMigrationServiceSettings"/> object.</returns>
        public DataMigrationServiceSettings Clone() => new DataMigrationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataMigrationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataMigrationServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataMigrationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataMigrationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataMigrationServiceClientBuilder() : base(DataMigrationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataMigrationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataMigrationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataMigrationServiceClient Build()
        {
            DataMigrationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataMigrationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataMigrationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataMigrationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataMigrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataMigrationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataMigrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataMigrationServiceClient.ChannelPool;
    }

    /// <summary>DataMigrationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Database Migration service
    /// </remarks>
    public abstract partial class DataMigrationServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataMigrationService service, which is a host of "datamigration.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamigration.googleapis.com:443";

        /// <summary>The default DataMigrationService scopes.</summary>
        /// <remarks>
        /// The default DataMigrationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataMigrationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataMigrationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataMigrationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataMigrationServiceClient"/>.</returns>
        public static stt::Task<DataMigrationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataMigrationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataMigrationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataMigrationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataMigrationServiceClient"/>.</returns>
        public static DataMigrationServiceClient Create() => new DataMigrationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataMigrationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataMigrationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataMigrationServiceClient"/>.</returns>
        internal static DataMigrationServiceClient Create(grpccore::CallInvoker callInvoker, DataMigrationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataMigrationService.DataMigrationServiceClient grpcClient = new DataMigrationService.DataMigrationServiceClient(callInvoker);
            return new DataMigrationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataMigrationService client</summary>
        public virtual DataMigrationService.DataMigrationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migrationJobs.
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
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationJobsRequest request = new ListMigrationJobsRequest
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
            return ListMigrationJobs(request, callSettings);
        }

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migrationJobs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationJobsRequest request = new ListMigrationJobsRequest
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
            return ListMigrationJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migrationJobs.
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
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationJobsRequest request = new ListMigrationJobsRequest
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
            return ListMigrationJobs(request, callSettings);
        }

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migrationJobs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationJobsRequest request = new ListMigrationJobsRequest
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
            return ListMigrationJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationJob GetMigrationJob(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(GetMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            GetMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationJob GetMigrationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJob(new GetMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJobAsync(new GetMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationJob GetMigrationJob(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJob(new GetMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJobAsync(new GetMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(MigrationJobName name, st::CancellationToken cancellationToken) =>
            GetMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(CreateMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            CreateMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMigrationJob</c>.</summary>
        public virtual lro::OperationsClient CreateMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceCreateMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceCreateMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(string parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJob(new CreateMigrationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(string parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJobAsync(new CreateMigrationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(string parent, MigrationJob migrationJob, string migrationJobId, st::CancellationToken cancellationToken) =>
            CreateMigrationJobAsync(parent, migrationJob, migrationJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(gagr::LocationName parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJob(new CreateMigrationJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(gagr::LocationName parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJobAsync(new CreateMigrationJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(gagr::LocationName parent, MigrationJob migrationJob, string migrationJobId, st::CancellationToken cancellationToken) =>
            CreateMigrationJobAsync(parent, migrationJob, migrationJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> UpdateMigrationJob(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(UpdateMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMigrationJob</c>.</summary>
        public virtual lro::OperationsClient UpdateMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceUpdateMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceUpdateMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="migrationJob">
        /// Required. The migration job parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> UpdateMigrationJob(MigrationJob migrationJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMigrationJob(new UpdateMigrationJobRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="migrationJob">
        /// Required. The migration job parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(MigrationJob migrationJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMigrationJobAsync(new UpdateMigrationJobRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="migrationJob">
        /// Required. The migration job parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(MigrationJob migrationJob, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMigrationJobAsync(migrationJob, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(DeleteMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMigrationJob</c>.</summary>
        public virtual lro::OperationsClient DeleteMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJob(new DeleteMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJobAsync(new DeleteMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJob(new DeleteMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJobAsync(new DeleteMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(MigrationJobName name, st::CancellationToken cancellationToken) =>
            DeleteMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> StartMigrationJob(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StartMigrationJobAsync(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StartMigrationJobAsync(StartMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            StartMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartMigrationJob</c>.</summary>
        public virtual lro::OperationsClient StartMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceStartMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceStartMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> StopMigrationJob(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StopMigrationJobAsync(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StopMigrationJobAsync(StopMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            StopMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopMigrationJob</c>.</summary>
        public virtual lro::OperationsClient StopMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceStopMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceStopMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> ResumeMigrationJob(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> ResumeMigrationJobAsync(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> ResumeMigrationJobAsync(ResumeMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            ResumeMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeMigrationJob</c>.</summary>
        public virtual lro::OperationsClient ResumeMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceResumeMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceResumeMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PromoteMigrationJob(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PromoteMigrationJobAsync(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PromoteMigrationJobAsync(PromoteMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            PromoteMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteMigrationJob</c>.</summary>
        public virtual lro::OperationsClient PromoteMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOncePromoteMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOncePromoteMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> VerifyMigrationJob(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> VerifyMigrationJobAsync(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> VerifyMigrationJobAsync(VerifyMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            VerifyMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>VerifyMigrationJob</c>.</summary>
        public virtual lro::OperationsClient VerifyMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>VerifyMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceVerifyMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), VerifyMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>VerifyMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceVerifyMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), VerifyMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> RestartMigrationJob(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> RestartMigrationJobAsync(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> RestartMigrationJobAsync(RestartMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            RestartMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestartMigrationJob</c>.</summary>
        public virtual lro::OperationsClient RestartMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestartMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceRestartMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestartMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceRestartMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SshScript GenerateSshScript(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SshScript> GenerateSshScriptAsync(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SshScript> GenerateSshScriptAsync(GenerateSshScriptRequest request, st::CancellationToken cancellationToken) =>
            GenerateSshScriptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM
        /// running a TCP Proxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TcpProxyScript GenerateTcpProxyScript(GenerateTcpProxyScriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM
        /// running a TCP Proxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpProxyScript> GenerateTcpProxyScriptAsync(GenerateTcpProxyScriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM
        /// running a TCP Proxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpProxyScript> GenerateTcpProxyScriptAsync(GenerateTcpProxyScriptRequest request, st::CancellationToken cancellationToken) =>
            GenerateTcpProxyScriptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
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
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfiles(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
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
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfiles(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfile(new GetConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfileAsync(new GetConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfile(new GetConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfileAsync(new GetConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(ConnectionProfileName name, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient CreateConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> PollOnceCreateConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> PollOnceCreateConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(string parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfile(new CreateConnectionProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(string parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfileAsync(new CreateConnectionProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(string parent, ConnectionProfile connectionProfile, string connectionProfileId, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(gagr::LocationName parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfile(new CreateConnectionProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(gagr::LocationName parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfileAsync(new CreateConnectionProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(gagr::LocationName parent, ConnectionProfile connectionProfile, string connectionProfileId, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> PollOnceUpdateConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> PollOnceUpdateConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionProfile(new UpdateConnectionProfileRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionProfileAsync(new UpdateConnectionProfileRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectionProfileAsync(connectionProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfile(new DeleteConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfileAsync(new DeleteConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfile(new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfileAsync(new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(ConnectionProfileName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePrivateConnection</c>.</summary>
        public virtual lro::OperationsClient CreatePrivateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> PollOnceCreatePrivateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateConnection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> PollOnceCreatePrivateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateConnection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The private connection resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connection identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(string parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnection(new CreatePrivateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The private connection resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connection identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(string parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnectionAsync(new CreatePrivateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The private connection resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connection identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(string parent, PrivateConnection privateConnection, string privateConnectionId, st::CancellationToken cancellationToken) =>
            CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The private connection resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connection identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(gagr::LocationName parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnection(new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The private connection resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connection identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(gagr::LocationName parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnectionAsync(new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The private connection resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connection identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(gagr::LocationName parent, PrivateConnection privateConnection, string privateConnectionId, st::CancellationToken cancellationToken) =>
            CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateConnection GetPrivateConnection(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(GetPrivateConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateConnection GetPrivateConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnection(new GetPrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnectionAsync(new GetPrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateConnection GetPrivateConnection(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnection(new GetPrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnectionAsync(new GetPrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(PrivateConnectionName name, st::CancellationToken cancellationToken) =>
            GetPrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connections.
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
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnections(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connections.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connections.
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
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnections(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connections.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeletePrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePrivateConnection</c>.</summary>
        public virtual lro::OperationsClient DeletePrivateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePrivateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePrivateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnection(new DeletePrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnectionAsync(new DeletePrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnection(new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnectionAsync(new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connection to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(PrivateConnectionName name, st::CancellationToken cancellationToken) =>
            DeletePrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionWorkspace GetConversionWorkspace(GetConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(GetConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(GetConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            GetConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionWorkspace GetConversionWorkspace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionWorkspace(new GetConversionWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionWorkspaceAsync(new GetConversionWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversionWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionWorkspace GetConversionWorkspace(ConversionWorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionWorkspace(new GetConversionWorkspaceRequest
            {
                ConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(ConversionWorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionWorkspaceAsync(new GetConversionWorkspaceRequest
            {
                ConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(ConversionWorkspaceName name, st::CancellationToken cancellationToken) =>
            GetConversionWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspaces(ListConversionWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspacesAsync(ListConversionWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
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
        /// <returns>A pageable sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspaces(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionWorkspacesRequest request = new ListConversionWorkspacesRequest
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
            return ListConversionWorkspaces(request, callSettings);
        }

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspacesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionWorkspacesRequest request = new ListConversionWorkspacesRequest
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
            return ListConversionWorkspacesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
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
        /// <returns>A pageable sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspaces(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionWorkspacesRequest request = new ListConversionWorkspacesRequest
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
            return ListConversionWorkspaces(request, callSettings);
        }

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspacesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionWorkspacesRequest request = new ListConversionWorkspacesRequest
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
            return ListConversionWorkspacesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> CreateConversionWorkspace(CreateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(CreateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(CreateConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            CreateConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient CreateConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceCreateConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceCreateConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
        /// </param>
        /// <param name="conversionWorkspace">
        /// Required. Represents a conversion workspace object.
        /// </param>
        /// <param name="conversionWorkspaceId">
        /// Required. The ID of the conversion workspace to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> CreateConversionWorkspace(string parent, ConversionWorkspace conversionWorkspace, string conversionWorkspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionWorkspace(new CreateConversionWorkspaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversionWorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)),
                ConversionWorkspace = gax::GaxPreconditions.CheckNotNull(conversionWorkspace, nameof(conversionWorkspace)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
        /// </param>
        /// <param name="conversionWorkspace">
        /// Required. Represents a conversion workspace object.
        /// </param>
        /// <param name="conversionWorkspaceId">
        /// Required. The ID of the conversion workspace to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(string parent, ConversionWorkspace conversionWorkspace, string conversionWorkspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionWorkspaceAsync(new CreateConversionWorkspaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversionWorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)),
                ConversionWorkspace = gax::GaxPreconditions.CheckNotNull(conversionWorkspace, nameof(conversionWorkspace)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
        /// </param>
        /// <param name="conversionWorkspace">
        /// Required. Represents a conversion workspace object.
        /// </param>
        /// <param name="conversionWorkspaceId">
        /// Required. The ID of the conversion workspace to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(string parent, ConversionWorkspace conversionWorkspace, string conversionWorkspaceId, st::CancellationToken cancellationToken) =>
            CreateConversionWorkspaceAsync(parent, conversionWorkspace, conversionWorkspaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
        /// </param>
        /// <param name="conversionWorkspace">
        /// Required. Represents a conversion workspace object.
        /// </param>
        /// <param name="conversionWorkspaceId">
        /// Required. The ID of the conversion workspace to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> CreateConversionWorkspace(gagr::LocationName parent, ConversionWorkspace conversionWorkspace, string conversionWorkspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionWorkspace(new CreateConversionWorkspaceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversionWorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)),
                ConversionWorkspace = gax::GaxPreconditions.CheckNotNull(conversionWorkspace, nameof(conversionWorkspace)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
        /// </param>
        /// <param name="conversionWorkspace">
        /// Required. Represents a conversion workspace object.
        /// </param>
        /// <param name="conversionWorkspaceId">
        /// Required. The ID of the conversion workspace to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(gagr::LocationName parent, ConversionWorkspace conversionWorkspace, string conversionWorkspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionWorkspaceAsync(new CreateConversionWorkspaceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversionWorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(conversionWorkspaceId, nameof(conversionWorkspaceId)),
                ConversionWorkspace = gax::GaxPreconditions.CheckNotNull(conversionWorkspace, nameof(conversionWorkspace)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of conversion workspaces.
        /// </param>
        /// <param name="conversionWorkspace">
        /// Required. Represents a conversion workspace object.
        /// </param>
        /// <param name="conversionWorkspaceId">
        /// Required. The ID of the conversion workspace to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(gagr::LocationName parent, ConversionWorkspace conversionWorkspace, string conversionWorkspaceId, st::CancellationToken cancellationToken) =>
            CreateConversionWorkspaceAsync(parent, conversionWorkspace, conversionWorkspaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> UpdateConversionWorkspace(UpdateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> UpdateConversionWorkspaceAsync(UpdateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> UpdateConversionWorkspaceAsync(UpdateConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient UpdateConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceUpdateConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceUpdateConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="conversionWorkspace">
        /// Required. The conversion workspace parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> UpdateConversionWorkspace(ConversionWorkspace conversionWorkspace, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversionWorkspace(new UpdateConversionWorkspaceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConversionWorkspace = gax::GaxPreconditions.CheckNotNull(conversionWorkspace, nameof(conversionWorkspace)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="conversionWorkspace">
        /// Required. The conversion workspace parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> UpdateConversionWorkspaceAsync(ConversionWorkspace conversionWorkspace, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversionWorkspaceAsync(new UpdateConversionWorkspaceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConversionWorkspace = gax::GaxPreconditions.CheckNotNull(conversionWorkspace, nameof(conversionWorkspace)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="conversionWorkspace">
        /// Required. The conversion workspace parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the conversion workspace resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> UpdateConversionWorkspaceAsync(ConversionWorkspace conversionWorkspace, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversionWorkspaceAsync(conversionWorkspace, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConversionWorkspace(DeleteConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(DeleteConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(DeleteConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient DeleteConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConversionWorkspace(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionWorkspace(new DeleteConversionWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionWorkspaceAsync(new DeleteConversionWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversionWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConversionWorkspace(ConversionWorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionWorkspace(new DeleteConversionWorkspaceRequest
            {
                ConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(ConversionWorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionWorkspaceAsync(new DeleteConversionWorkspaceRequest
            {
                ConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the conversion workspace resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(ConversionWorkspaceName name, st::CancellationToken cancellationToken) =>
            DeleteConversionWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MappingRule CreateMappingRule(CreateMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> CreateMappingRuleAsync(CreateMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> CreateMappingRuleAsync(CreateMappingRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateMappingRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of mapping rules.
        /// </param>
        /// <param name="mappingRule">
        /// Required. Represents a [mapping rule]
        /// (https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.mappingRules)
        /// object.
        /// </param>
        /// <param name="mappingRuleId">
        /// Required. The ID of the rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MappingRule CreateMappingRule(string parent, MappingRule mappingRule, string mappingRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMappingRule(new CreateMappingRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MappingRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(mappingRuleId, nameof(mappingRuleId)),
                MappingRule = gax::GaxPreconditions.CheckNotNull(mappingRule, nameof(mappingRule)),
            }, callSettings);

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of mapping rules.
        /// </param>
        /// <param name="mappingRule">
        /// Required. Represents a [mapping rule]
        /// (https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.mappingRules)
        /// object.
        /// </param>
        /// <param name="mappingRuleId">
        /// Required. The ID of the rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> CreateMappingRuleAsync(string parent, MappingRule mappingRule, string mappingRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMappingRuleAsync(new CreateMappingRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MappingRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(mappingRuleId, nameof(mappingRuleId)),
                MappingRule = gax::GaxPreconditions.CheckNotNull(mappingRule, nameof(mappingRule)),
            }, callSettings);

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of mapping rules.
        /// </param>
        /// <param name="mappingRule">
        /// Required. Represents a [mapping rule]
        /// (https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.mappingRules)
        /// object.
        /// </param>
        /// <param name="mappingRuleId">
        /// Required. The ID of the rule to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> CreateMappingRuleAsync(string parent, MappingRule mappingRule, string mappingRuleId, st::CancellationToken cancellationToken) =>
            CreateMappingRuleAsync(parent, mappingRule, mappingRuleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of mapping rules.
        /// </param>
        /// <param name="mappingRule">
        /// Required. Represents a [mapping rule]
        /// (https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.mappingRules)
        /// object.
        /// </param>
        /// <param name="mappingRuleId">
        /// Required. The ID of the rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MappingRule CreateMappingRule(ConversionWorkspaceName parent, MappingRule mappingRule, string mappingRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMappingRule(new CreateMappingRuleRequest
            {
                ParentAsConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MappingRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(mappingRuleId, nameof(mappingRuleId)),
                MappingRule = gax::GaxPreconditions.CheckNotNull(mappingRule, nameof(mappingRule)),
            }, callSettings);

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of mapping rules.
        /// </param>
        /// <param name="mappingRule">
        /// Required. Represents a [mapping rule]
        /// (https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.mappingRules)
        /// object.
        /// </param>
        /// <param name="mappingRuleId">
        /// Required. The ID of the rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> CreateMappingRuleAsync(ConversionWorkspaceName parent, MappingRule mappingRule, string mappingRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMappingRuleAsync(new CreateMappingRuleRequest
            {
                ParentAsConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MappingRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(mappingRuleId, nameof(mappingRuleId)),
                MappingRule = gax::GaxPreconditions.CheckNotNull(mappingRule, nameof(mappingRule)),
            }, callSettings);

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of mapping rules.
        /// </param>
        /// <param name="mappingRule">
        /// Required. Represents a [mapping rule]
        /// (https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.mappingRules)
        /// object.
        /// </param>
        /// <param name="mappingRuleId">
        /// Required. The ID of the rule to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> CreateMappingRuleAsync(ConversionWorkspaceName parent, MappingRule mappingRule, string mappingRuleId, st::CancellationToken cancellationToken) =>
            CreateMappingRuleAsync(parent, mappingRule, mappingRuleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMappingRule(DeleteMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMappingRuleAsync(DeleteMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMappingRuleAsync(DeleteMappingRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteMappingRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMappingRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMappingRule(new DeleteMappingRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMappingRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMappingRuleAsync(new DeleteMappingRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMappingRuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMappingRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMappingRule(ConversionWorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMappingRule(new DeleteMappingRuleRequest
            {
                ConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMappingRuleAsync(ConversionWorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMappingRuleAsync(new DeleteMappingRuleRequest
            {
                ConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMappingRuleAsync(ConversionWorkspaceName name, st::CancellationToken cancellationToken) =>
            DeleteMappingRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MappingRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRules(ListMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MappingRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRulesAsync(ListMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the conversion workspace resource whose mapping rules are
        /// listed in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
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
        /// <returns>A pageable sequence of <see cref="MappingRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMappingRulesRequest request = new ListMappingRulesRequest
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
            return ListMappingRules(request, callSettings);
        }

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the conversion workspace resource whose mapping rules are
        /// listed in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MappingRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMappingRulesRequest request = new ListMappingRulesRequest
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
            return ListMappingRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the conversion workspace resource whose mapping rules are
        /// listed in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
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
        /// <returns>A pageable sequence of <see cref="MappingRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRules(ConversionWorkspaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMappingRulesRequest request = new ListMappingRulesRequest
            {
                ParentAsConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMappingRules(request, callSettings);
        }

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the conversion workspace resource whose mapping rules are
        /// listed in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MappingRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRulesAsync(ConversionWorkspaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMappingRulesRequest request = new ListMappingRulesRequest
            {
                ParentAsConversionWorkspaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMappingRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MappingRule GetMappingRule(GetMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> GetMappingRuleAsync(GetMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> GetMappingRuleAsync(GetMappingRuleRequest request, st::CancellationToken cancellationToken) =>
            GetMappingRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to get.
        /// Example: conversionWorkspaces/123/mappingRules/rule123
        /// 
        /// In order to retrieve a previous revision of the mapping rule, also provide
        /// the revision ID.
        /// Example:
        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MappingRule GetMappingRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMappingRule(new GetMappingRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to get.
        /// Example: conversionWorkspaces/123/mappingRules/rule123
        /// 
        /// In order to retrieve a previous revision of the mapping rule, also provide
        /// the revision ID.
        /// Example:
        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> GetMappingRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMappingRuleAsync(new GetMappingRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to get.
        /// Example: conversionWorkspaces/123/mappingRules/rule123
        /// 
        /// In order to retrieve a previous revision of the mapping rule, also provide
        /// the revision ID.
        /// Example:
        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> GetMappingRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetMappingRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to get.
        /// Example: conversionWorkspaces/123/mappingRules/rule123
        /// 
        /// In order to retrieve a previous revision of the mapping rule, also provide
        /// the revision ID.
        /// Example:
        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MappingRule GetMappingRule(MappingRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMappingRule(new GetMappingRuleRequest
            {
                MappingRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to get.
        /// Example: conversionWorkspaces/123/mappingRules/rule123
        /// 
        /// In order to retrieve a previous revision of the mapping rule, also provide
        /// the revision ID.
        /// Example:
        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> GetMappingRuleAsync(MappingRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMappingRuleAsync(new GetMappingRuleRequest
            {
                MappingRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mapping rule resource to get.
        /// Example: conversionWorkspaces/123/mappingRules/rule123
        /// 
        /// In order to retrieve a previous revision of the mapping rule, also provide
        /// the revision ID.
        /// Example:
        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MappingRule> GetMappingRuleAsync(MappingRuleName name, st::CancellationToken cancellationToken) =>
            GetMappingRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a snapshot of the source database into the
        /// conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> SeedConversionWorkspace(SeedConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a snapshot of the source database into the
        /// conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> SeedConversionWorkspaceAsync(SeedConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a snapshot of the source database into the
        /// conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> SeedConversionWorkspaceAsync(SeedConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            SeedConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SeedConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient SeedConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SeedConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceSeedConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SeedConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SeedConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceSeedConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SeedConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Imports the mapping rules for a given conversion workspace.
        /// Supports various formats of external rules files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> ImportMappingRules(ImportMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the mapping rules for a given conversion workspace.
        /// Supports various formats of external rules files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ImportMappingRulesAsync(ImportMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the mapping rules for a given conversion workspace.
        /// Supports various formats of external rules files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ImportMappingRulesAsync(ImportMappingRulesRequest request, st::CancellationToken cancellationToken) =>
            ImportMappingRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportMappingRules</c>.</summary>
        public virtual lro::OperationsClient ImportMappingRulesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportMappingRules</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceImportMappingRules(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportMappingRulesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportMappingRules</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceImportMappingRulesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportMappingRulesOperationsClient, callSettings);

        /// <summary>
        /// Creates a draft tree schema for the destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> ConvertConversionWorkspace(ConvertConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a draft tree schema for the destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ConvertConversionWorkspaceAsync(ConvertConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a draft tree schema for the destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ConvertConversionWorkspaceAsync(ConvertConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            ConvertConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ConvertConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient ConvertConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConvertConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceConvertConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConvertConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConvertConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceConvertConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConvertConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Marks all the data in the conversion workspace as committed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> CommitConversionWorkspace(CommitConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks all the data in the conversion workspace as committed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CommitConversionWorkspaceAsync(CommitConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks all the data in the conversion workspace as committed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CommitConversionWorkspaceAsync(CommitConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            CommitConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CommitConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient CommitConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CommitConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceCommitConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CommitConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CommitConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceCommitConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CommitConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Rolls back a conversion workspace to the last committed snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> RollbackConversionWorkspace(RollbackConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a conversion workspace to the last committed snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> RollbackConversionWorkspaceAsync(RollbackConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a conversion workspace to the last committed snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> RollbackConversionWorkspaceAsync(RollbackConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            RollbackConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RollbackConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient RollbackConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RollbackConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceRollbackConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RollbackConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RollbackConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceRollbackConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RollbackConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Applies draft tree onto a specific destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> ApplyConversionWorkspace(ApplyConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies draft tree onto a specific destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ApplyConversionWorkspaceAsync(ApplyConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies draft tree onto a specific destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ApplyConversionWorkspaceAsync(ApplyConversionWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            ApplyConversionWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ApplyConversionWorkspace</c>.</summary>
        public virtual lro::OperationsClient ApplyConversionWorkspaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ApplyConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversionWorkspace, OperationMetadata> PollOnceApplyConversionWorkspace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApplyConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ApplyConversionWorkspace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> PollOnceApplyConversionWorkspaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversionWorkspace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApplyConversionWorkspaceOperationsClient, callSettings);

        /// <summary>
        /// Describes the database entities tree for a specific conversion workspace
        /// and a specific tree type.
        /// 
        /// Database entities are not resources like conversion workspaces or mapping
        /// rules, and they can't be created, updated or deleted. Instead, they are
        /// simple data objects describing the structure of the client database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatabaseEntity"/> resources.</returns>
        public virtual gax::PagedEnumerable<DescribeDatabaseEntitiesResponse, DatabaseEntity> DescribeDatabaseEntities(DescribeDatabaseEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes the database entities tree for a specific conversion workspace
        /// and a specific tree type.
        /// 
        /// Database entities are not resources like conversion workspaces or mapping
        /// rules, and they can't be created, updated or deleted. Instead, they are
        /// simple data objects describing the structure of the client database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatabaseEntity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<DescribeDatabaseEntitiesResponse, DatabaseEntity> DescribeDatabaseEntitiesAsync(DescribeDatabaseEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches/lists the background jobs for a specific
        /// conversion workspace.
        /// 
        /// The background jobs are not resources like conversion workspaces or
        /// mapping rules, and they can't be created, updated or deleted.
        /// Instead, they are a way to expose the data plane jobs log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchBackgroundJobsResponse SearchBackgroundJobs(SearchBackgroundJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches/lists the background jobs for a specific
        /// conversion workspace.
        /// 
        /// The background jobs are not resources like conversion workspaces or
        /// mapping rules, and they can't be created, updated or deleted.
        /// Instead, they are a way to expose the data plane jobs log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchBackgroundJobsResponse> SearchBackgroundJobsAsync(SearchBackgroundJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches/lists the background jobs for a specific
        /// conversion workspace.
        /// 
        /// The background jobs are not resources like conversion workspaces or
        /// mapping rules, and they can't be created, updated or deleted.
        /// Instead, they are a way to expose the data plane jobs log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchBackgroundJobsResponse> SearchBackgroundJobsAsync(SearchBackgroundJobsRequest request, st::CancellationToken cancellationToken) =>
            SearchBackgroundJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of committed revisions of a specific conversion
        /// workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DescribeConversionWorkspaceRevisionsResponse DescribeConversionWorkspaceRevisions(DescribeConversionWorkspaceRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of committed revisions of a specific conversion
        /// workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DescribeConversionWorkspaceRevisionsResponse> DescribeConversionWorkspaceRevisionsAsync(DescribeConversionWorkspaceRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of committed revisions of a specific conversion
        /// workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DescribeConversionWorkspaceRevisionsResponse> DescribeConversionWorkspaceRevisionsAsync(DescribeConversionWorkspaceRevisionsRequest request, st::CancellationToken cancellationToken) =>
            DescribeConversionWorkspaceRevisionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIps(request, callSettings);
        }

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIpsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(gagr::LocationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIps(request, callSettings);
        }

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(gagr::LocationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIpsAsync(request, callSettings);
        }
    }

    /// <summary>DataMigrationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Database Migration service
    /// </remarks>
    public sealed partial class DataMigrationServiceClientImpl : DataMigrationServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMigrationJobsRequest, ListMigrationJobsResponse> _callListMigrationJobs;

        private readonly gaxgrpc::ApiCall<GetMigrationJobRequest, MigrationJob> _callGetMigrationJob;

        private readonly gaxgrpc::ApiCall<CreateMigrationJobRequest, lro::Operation> _callCreateMigrationJob;

        private readonly gaxgrpc::ApiCall<UpdateMigrationJobRequest, lro::Operation> _callUpdateMigrationJob;

        private readonly gaxgrpc::ApiCall<DeleteMigrationJobRequest, lro::Operation> _callDeleteMigrationJob;

        private readonly gaxgrpc::ApiCall<StartMigrationJobRequest, lro::Operation> _callStartMigrationJob;

        private readonly gaxgrpc::ApiCall<StopMigrationJobRequest, lro::Operation> _callStopMigrationJob;

        private readonly gaxgrpc::ApiCall<ResumeMigrationJobRequest, lro::Operation> _callResumeMigrationJob;

        private readonly gaxgrpc::ApiCall<PromoteMigrationJobRequest, lro::Operation> _callPromoteMigrationJob;

        private readonly gaxgrpc::ApiCall<VerifyMigrationJobRequest, lro::Operation> _callVerifyMigrationJob;

        private readonly gaxgrpc::ApiCall<RestartMigrationJobRequest, lro::Operation> _callRestartMigrationJob;

        private readonly gaxgrpc::ApiCall<GenerateSshScriptRequest, SshScript> _callGenerateSshScript;

        private readonly gaxgrpc::ApiCall<GenerateTcpProxyScriptRequest, TcpProxyScript> _callGenerateTcpProxyScript;

        private readonly gaxgrpc::ApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse> _callListConnectionProfiles;

        private readonly gaxgrpc::ApiCall<GetConnectionProfileRequest, ConnectionProfile> _callGetConnectionProfile;

        private readonly gaxgrpc::ApiCall<CreateConnectionProfileRequest, lro::Operation> _callCreateConnectionProfile;

        private readonly gaxgrpc::ApiCall<UpdateConnectionProfileRequest, lro::Operation> _callUpdateConnectionProfile;

        private readonly gaxgrpc::ApiCall<DeleteConnectionProfileRequest, lro::Operation> _callDeleteConnectionProfile;

        private readonly gaxgrpc::ApiCall<CreatePrivateConnectionRequest, lro::Operation> _callCreatePrivateConnection;

        private readonly gaxgrpc::ApiCall<GetPrivateConnectionRequest, PrivateConnection> _callGetPrivateConnection;

        private readonly gaxgrpc::ApiCall<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse> _callListPrivateConnections;

        private readonly gaxgrpc::ApiCall<DeletePrivateConnectionRequest, lro::Operation> _callDeletePrivateConnection;

        private readonly gaxgrpc::ApiCall<GetConversionWorkspaceRequest, ConversionWorkspace> _callGetConversionWorkspace;

        private readonly gaxgrpc::ApiCall<ListConversionWorkspacesRequest, ListConversionWorkspacesResponse> _callListConversionWorkspaces;

        private readonly gaxgrpc::ApiCall<CreateConversionWorkspaceRequest, lro::Operation> _callCreateConversionWorkspace;

        private readonly gaxgrpc::ApiCall<UpdateConversionWorkspaceRequest, lro::Operation> _callUpdateConversionWorkspace;

        private readonly gaxgrpc::ApiCall<DeleteConversionWorkspaceRequest, lro::Operation> _callDeleteConversionWorkspace;

        private readonly gaxgrpc::ApiCall<CreateMappingRuleRequest, MappingRule> _callCreateMappingRule;

        private readonly gaxgrpc::ApiCall<DeleteMappingRuleRequest, wkt::Empty> _callDeleteMappingRule;

        private readonly gaxgrpc::ApiCall<ListMappingRulesRequest, ListMappingRulesResponse> _callListMappingRules;

        private readonly gaxgrpc::ApiCall<GetMappingRuleRequest, MappingRule> _callGetMappingRule;

        private readonly gaxgrpc::ApiCall<SeedConversionWorkspaceRequest, lro::Operation> _callSeedConversionWorkspace;

        private readonly gaxgrpc::ApiCall<ImportMappingRulesRequest, lro::Operation> _callImportMappingRules;

        private readonly gaxgrpc::ApiCall<ConvertConversionWorkspaceRequest, lro::Operation> _callConvertConversionWorkspace;

        private readonly gaxgrpc::ApiCall<CommitConversionWorkspaceRequest, lro::Operation> _callCommitConversionWorkspace;

        private readonly gaxgrpc::ApiCall<RollbackConversionWorkspaceRequest, lro::Operation> _callRollbackConversionWorkspace;

        private readonly gaxgrpc::ApiCall<ApplyConversionWorkspaceRequest, lro::Operation> _callApplyConversionWorkspace;

        private readonly gaxgrpc::ApiCall<DescribeDatabaseEntitiesRequest, DescribeDatabaseEntitiesResponse> _callDescribeDatabaseEntities;

        private readonly gaxgrpc::ApiCall<SearchBackgroundJobsRequest, SearchBackgroundJobsResponse> _callSearchBackgroundJobs;

        private readonly gaxgrpc::ApiCall<DescribeConversionWorkspaceRevisionsRequest, DescribeConversionWorkspaceRevisionsResponse> _callDescribeConversionWorkspaceRevisions;

        private readonly gaxgrpc::ApiCall<FetchStaticIpsRequest, FetchStaticIpsResponse> _callFetchStaticIps;

        /// <summary>
        /// Constructs a client wrapper for the DataMigrationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataMigrationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataMigrationServiceClientImpl(DataMigrationService.DataMigrationServiceClient grpcClient, DataMigrationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataMigrationServiceSettings effectiveSettings = settings ?? DataMigrationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMigrationJobOperationsSettings, logger);
            UpdateMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMigrationJobOperationsSettings, logger);
            DeleteMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMigrationJobOperationsSettings, logger);
            StartMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartMigrationJobOperationsSettings, logger);
            StopMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopMigrationJobOperationsSettings, logger);
            ResumeMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeMigrationJobOperationsSettings, logger);
            PromoteMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteMigrationJobOperationsSettings, logger);
            VerifyMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.VerifyMigrationJobOperationsSettings, logger);
            RestartMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestartMigrationJobOperationsSettings, logger);
            CreateConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectionProfileOperationsSettings, logger);
            UpdateConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectionProfileOperationsSettings, logger);
            DeleteConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectionProfileOperationsSettings, logger);
            CreatePrivateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePrivateConnectionOperationsSettings, logger);
            DeletePrivateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePrivateConnectionOperationsSettings, logger);
            CreateConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConversionWorkspaceOperationsSettings, logger);
            UpdateConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConversionWorkspaceOperationsSettings, logger);
            DeleteConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConversionWorkspaceOperationsSettings, logger);
            SeedConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SeedConversionWorkspaceOperationsSettings, logger);
            ImportMappingRulesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportMappingRulesOperationsSettings, logger);
            ConvertConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ConvertConversionWorkspaceOperationsSettings, logger);
            CommitConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CommitConversionWorkspaceOperationsSettings, logger);
            RollbackConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RollbackConversionWorkspaceOperationsSettings, logger);
            ApplyConversionWorkspaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ApplyConversionWorkspaceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListMigrationJobs = clientHelper.BuildApiCall<ListMigrationJobsRequest, ListMigrationJobsResponse>("ListMigrationJobs", grpcClient.ListMigrationJobsAsync, grpcClient.ListMigrationJobs, effectiveSettings.ListMigrationJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMigrationJobs);
            Modify_ListMigrationJobsApiCall(ref _callListMigrationJobs);
            _callGetMigrationJob = clientHelper.BuildApiCall<GetMigrationJobRequest, MigrationJob>("GetMigrationJob", grpcClient.GetMigrationJobAsync, grpcClient.GetMigrationJob, effectiveSettings.GetMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMigrationJob);
            Modify_GetMigrationJobApiCall(ref _callGetMigrationJob);
            _callCreateMigrationJob = clientHelper.BuildApiCall<CreateMigrationJobRequest, lro::Operation>("CreateMigrationJob", grpcClient.CreateMigrationJobAsync, grpcClient.CreateMigrationJob, effectiveSettings.CreateMigrationJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMigrationJob);
            Modify_CreateMigrationJobApiCall(ref _callCreateMigrationJob);
            _callUpdateMigrationJob = clientHelper.BuildApiCall<UpdateMigrationJobRequest, lro::Operation>("UpdateMigrationJob", grpcClient.UpdateMigrationJobAsync, grpcClient.UpdateMigrationJob, effectiveSettings.UpdateMigrationJobSettings).WithGoogleRequestParam("migration_job.name", request => request.MigrationJob?.Name);
            Modify_ApiCall(ref _callUpdateMigrationJob);
            Modify_UpdateMigrationJobApiCall(ref _callUpdateMigrationJob);
            _callDeleteMigrationJob = clientHelper.BuildApiCall<DeleteMigrationJobRequest, lro::Operation>("DeleteMigrationJob", grpcClient.DeleteMigrationJobAsync, grpcClient.DeleteMigrationJob, effectiveSettings.DeleteMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMigrationJob);
            Modify_DeleteMigrationJobApiCall(ref _callDeleteMigrationJob);
            _callStartMigrationJob = clientHelper.BuildApiCall<StartMigrationJobRequest, lro::Operation>("StartMigrationJob", grpcClient.StartMigrationJobAsync, grpcClient.StartMigrationJob, effectiveSettings.StartMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartMigrationJob);
            Modify_StartMigrationJobApiCall(ref _callStartMigrationJob);
            _callStopMigrationJob = clientHelper.BuildApiCall<StopMigrationJobRequest, lro::Operation>("StopMigrationJob", grpcClient.StopMigrationJobAsync, grpcClient.StopMigrationJob, effectiveSettings.StopMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopMigrationJob);
            Modify_StopMigrationJobApiCall(ref _callStopMigrationJob);
            _callResumeMigrationJob = clientHelper.BuildApiCall<ResumeMigrationJobRequest, lro::Operation>("ResumeMigrationJob", grpcClient.ResumeMigrationJobAsync, grpcClient.ResumeMigrationJob, effectiveSettings.ResumeMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeMigrationJob);
            Modify_ResumeMigrationJobApiCall(ref _callResumeMigrationJob);
            _callPromoteMigrationJob = clientHelper.BuildApiCall<PromoteMigrationJobRequest, lro::Operation>("PromoteMigrationJob", grpcClient.PromoteMigrationJobAsync, grpcClient.PromoteMigrationJob, effectiveSettings.PromoteMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPromoteMigrationJob);
            Modify_PromoteMigrationJobApiCall(ref _callPromoteMigrationJob);
            _callVerifyMigrationJob = clientHelper.BuildApiCall<VerifyMigrationJobRequest, lro::Operation>("VerifyMigrationJob", grpcClient.VerifyMigrationJobAsync, grpcClient.VerifyMigrationJob, effectiveSettings.VerifyMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callVerifyMigrationJob);
            Modify_VerifyMigrationJobApiCall(ref _callVerifyMigrationJob);
            _callRestartMigrationJob = clientHelper.BuildApiCall<RestartMigrationJobRequest, lro::Operation>("RestartMigrationJob", grpcClient.RestartMigrationJobAsync, grpcClient.RestartMigrationJob, effectiveSettings.RestartMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestartMigrationJob);
            Modify_RestartMigrationJobApiCall(ref _callRestartMigrationJob);
            _callGenerateSshScript = clientHelper.BuildApiCall<GenerateSshScriptRequest, SshScript>("GenerateSshScript", grpcClient.GenerateSshScriptAsync, grpcClient.GenerateSshScript, effectiveSettings.GenerateSshScriptSettings).WithGoogleRequestParam("migration_job", request => request.MigrationJob);
            Modify_ApiCall(ref _callGenerateSshScript);
            Modify_GenerateSshScriptApiCall(ref _callGenerateSshScript);
            _callGenerateTcpProxyScript = clientHelper.BuildApiCall<GenerateTcpProxyScriptRequest, TcpProxyScript>("GenerateTcpProxyScript", grpcClient.GenerateTcpProxyScriptAsync, grpcClient.GenerateTcpProxyScript, effectiveSettings.GenerateTcpProxyScriptSettings).WithGoogleRequestParam("migration_job", request => request.MigrationJob);
            Modify_ApiCall(ref _callGenerateTcpProxyScript);
            Modify_GenerateTcpProxyScriptApiCall(ref _callGenerateTcpProxyScript);
            _callListConnectionProfiles = clientHelper.BuildApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse>("ListConnectionProfiles", grpcClient.ListConnectionProfilesAsync, grpcClient.ListConnectionProfiles, effectiveSettings.ListConnectionProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectionProfiles);
            Modify_ListConnectionProfilesApiCall(ref _callListConnectionProfiles);
            _callGetConnectionProfile = clientHelper.BuildApiCall<GetConnectionProfileRequest, ConnectionProfile>("GetConnectionProfile", grpcClient.GetConnectionProfileAsync, grpcClient.GetConnectionProfile, effectiveSettings.GetConnectionProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectionProfile);
            Modify_GetConnectionProfileApiCall(ref _callGetConnectionProfile);
            _callCreateConnectionProfile = clientHelper.BuildApiCall<CreateConnectionProfileRequest, lro::Operation>("CreateConnectionProfile", grpcClient.CreateConnectionProfileAsync, grpcClient.CreateConnectionProfile, effectiveSettings.CreateConnectionProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnectionProfile);
            Modify_CreateConnectionProfileApiCall(ref _callCreateConnectionProfile);
            _callUpdateConnectionProfile = clientHelper.BuildApiCall<UpdateConnectionProfileRequest, lro::Operation>("UpdateConnectionProfile", grpcClient.UpdateConnectionProfileAsync, grpcClient.UpdateConnectionProfile, effectiveSettings.UpdateConnectionProfileSettings).WithGoogleRequestParam("connection_profile.name", request => request.ConnectionProfile?.Name);
            Modify_ApiCall(ref _callUpdateConnectionProfile);
            Modify_UpdateConnectionProfileApiCall(ref _callUpdateConnectionProfile);
            _callDeleteConnectionProfile = clientHelper.BuildApiCall<DeleteConnectionProfileRequest, lro::Operation>("DeleteConnectionProfile", grpcClient.DeleteConnectionProfileAsync, grpcClient.DeleteConnectionProfile, effectiveSettings.DeleteConnectionProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnectionProfile);
            Modify_DeleteConnectionProfileApiCall(ref _callDeleteConnectionProfile);
            _callCreatePrivateConnection = clientHelper.BuildApiCall<CreatePrivateConnectionRequest, lro::Operation>("CreatePrivateConnection", grpcClient.CreatePrivateConnectionAsync, grpcClient.CreatePrivateConnection, effectiveSettings.CreatePrivateConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateConnection);
            Modify_CreatePrivateConnectionApiCall(ref _callCreatePrivateConnection);
            _callGetPrivateConnection = clientHelper.BuildApiCall<GetPrivateConnectionRequest, PrivateConnection>("GetPrivateConnection", grpcClient.GetPrivateConnectionAsync, grpcClient.GetPrivateConnection, effectiveSettings.GetPrivateConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateConnection);
            Modify_GetPrivateConnectionApiCall(ref _callGetPrivateConnection);
            _callListPrivateConnections = clientHelper.BuildApiCall<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse>("ListPrivateConnections", grpcClient.ListPrivateConnectionsAsync, grpcClient.ListPrivateConnections, effectiveSettings.ListPrivateConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateConnections);
            Modify_ListPrivateConnectionsApiCall(ref _callListPrivateConnections);
            _callDeletePrivateConnection = clientHelper.BuildApiCall<DeletePrivateConnectionRequest, lro::Operation>("DeletePrivateConnection", grpcClient.DeletePrivateConnectionAsync, grpcClient.DeletePrivateConnection, effectiveSettings.DeletePrivateConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePrivateConnection);
            Modify_DeletePrivateConnectionApiCall(ref _callDeletePrivateConnection);
            _callGetConversionWorkspace = clientHelper.BuildApiCall<GetConversionWorkspaceRequest, ConversionWorkspace>("GetConversionWorkspace", grpcClient.GetConversionWorkspaceAsync, grpcClient.GetConversionWorkspace, effectiveSettings.GetConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversionWorkspace);
            Modify_GetConversionWorkspaceApiCall(ref _callGetConversionWorkspace);
            _callListConversionWorkspaces = clientHelper.BuildApiCall<ListConversionWorkspacesRequest, ListConversionWorkspacesResponse>("ListConversionWorkspaces", grpcClient.ListConversionWorkspacesAsync, grpcClient.ListConversionWorkspaces, effectiveSettings.ListConversionWorkspacesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversionWorkspaces);
            Modify_ListConversionWorkspacesApiCall(ref _callListConversionWorkspaces);
            _callCreateConversionWorkspace = clientHelper.BuildApiCall<CreateConversionWorkspaceRequest, lro::Operation>("CreateConversionWorkspace", grpcClient.CreateConversionWorkspaceAsync, grpcClient.CreateConversionWorkspace, effectiveSettings.CreateConversionWorkspaceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversionWorkspace);
            Modify_CreateConversionWorkspaceApiCall(ref _callCreateConversionWorkspace);
            _callUpdateConversionWorkspace = clientHelper.BuildApiCall<UpdateConversionWorkspaceRequest, lro::Operation>("UpdateConversionWorkspace", grpcClient.UpdateConversionWorkspaceAsync, grpcClient.UpdateConversionWorkspace, effectiveSettings.UpdateConversionWorkspaceSettings).WithGoogleRequestParam("conversion_workspace.name", request => request.ConversionWorkspace?.Name);
            Modify_ApiCall(ref _callUpdateConversionWorkspace);
            Modify_UpdateConversionWorkspaceApiCall(ref _callUpdateConversionWorkspace);
            _callDeleteConversionWorkspace = clientHelper.BuildApiCall<DeleteConversionWorkspaceRequest, lro::Operation>("DeleteConversionWorkspace", grpcClient.DeleteConversionWorkspaceAsync, grpcClient.DeleteConversionWorkspace, effectiveSettings.DeleteConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversionWorkspace);
            Modify_DeleteConversionWorkspaceApiCall(ref _callDeleteConversionWorkspace);
            _callCreateMappingRule = clientHelper.BuildApiCall<CreateMappingRuleRequest, MappingRule>("CreateMappingRule", grpcClient.CreateMappingRuleAsync, grpcClient.CreateMappingRule, effectiveSettings.CreateMappingRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMappingRule);
            Modify_CreateMappingRuleApiCall(ref _callCreateMappingRule);
            _callDeleteMappingRule = clientHelper.BuildApiCall<DeleteMappingRuleRequest, wkt::Empty>("DeleteMappingRule", grpcClient.DeleteMappingRuleAsync, grpcClient.DeleteMappingRule, effectiveSettings.DeleteMappingRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMappingRule);
            Modify_DeleteMappingRuleApiCall(ref _callDeleteMappingRule);
            _callListMappingRules = clientHelper.BuildApiCall<ListMappingRulesRequest, ListMappingRulesResponse>("ListMappingRules", grpcClient.ListMappingRulesAsync, grpcClient.ListMappingRules, effectiveSettings.ListMappingRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMappingRules);
            Modify_ListMappingRulesApiCall(ref _callListMappingRules);
            _callGetMappingRule = clientHelper.BuildApiCall<GetMappingRuleRequest, MappingRule>("GetMappingRule", grpcClient.GetMappingRuleAsync, grpcClient.GetMappingRule, effectiveSettings.GetMappingRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMappingRule);
            Modify_GetMappingRuleApiCall(ref _callGetMappingRule);
            _callSeedConversionWorkspace = clientHelper.BuildApiCall<SeedConversionWorkspaceRequest, lro::Operation>("SeedConversionWorkspace", grpcClient.SeedConversionWorkspaceAsync, grpcClient.SeedConversionWorkspace, effectiveSettings.SeedConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSeedConversionWorkspace);
            Modify_SeedConversionWorkspaceApiCall(ref _callSeedConversionWorkspace);
            _callImportMappingRules = clientHelper.BuildApiCall<ImportMappingRulesRequest, lro::Operation>("ImportMappingRules", grpcClient.ImportMappingRulesAsync, grpcClient.ImportMappingRules, effectiveSettings.ImportMappingRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportMappingRules);
            Modify_ImportMappingRulesApiCall(ref _callImportMappingRules);
            _callConvertConversionWorkspace = clientHelper.BuildApiCall<ConvertConversionWorkspaceRequest, lro::Operation>("ConvertConversionWorkspace", grpcClient.ConvertConversionWorkspaceAsync, grpcClient.ConvertConversionWorkspace, effectiveSettings.ConvertConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callConvertConversionWorkspace);
            Modify_ConvertConversionWorkspaceApiCall(ref _callConvertConversionWorkspace);
            _callCommitConversionWorkspace = clientHelper.BuildApiCall<CommitConversionWorkspaceRequest, lro::Operation>("CommitConversionWorkspace", grpcClient.CommitConversionWorkspaceAsync, grpcClient.CommitConversionWorkspace, effectiveSettings.CommitConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCommitConversionWorkspace);
            Modify_CommitConversionWorkspaceApiCall(ref _callCommitConversionWorkspace);
            _callRollbackConversionWorkspace = clientHelper.BuildApiCall<RollbackConversionWorkspaceRequest, lro::Operation>("RollbackConversionWorkspace", grpcClient.RollbackConversionWorkspaceAsync, grpcClient.RollbackConversionWorkspace, effectiveSettings.RollbackConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackConversionWorkspace);
            Modify_RollbackConversionWorkspaceApiCall(ref _callRollbackConversionWorkspace);
            _callApplyConversionWorkspace = clientHelper.BuildApiCall<ApplyConversionWorkspaceRequest, lro::Operation>("ApplyConversionWorkspace", grpcClient.ApplyConversionWorkspaceAsync, grpcClient.ApplyConversionWorkspace, effectiveSettings.ApplyConversionWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApplyConversionWorkspace);
            Modify_ApplyConversionWorkspaceApiCall(ref _callApplyConversionWorkspace);
            _callDescribeDatabaseEntities = clientHelper.BuildApiCall<DescribeDatabaseEntitiesRequest, DescribeDatabaseEntitiesResponse>("DescribeDatabaseEntities", grpcClient.DescribeDatabaseEntitiesAsync, grpcClient.DescribeDatabaseEntities, effectiveSettings.DescribeDatabaseEntitiesSettings).WithGoogleRequestParam("conversion_workspace", request => request.ConversionWorkspace);
            Modify_ApiCall(ref _callDescribeDatabaseEntities);
            Modify_DescribeDatabaseEntitiesApiCall(ref _callDescribeDatabaseEntities);
            _callSearchBackgroundJobs = clientHelper.BuildApiCall<SearchBackgroundJobsRequest, SearchBackgroundJobsResponse>("SearchBackgroundJobs", grpcClient.SearchBackgroundJobsAsync, grpcClient.SearchBackgroundJobs, effectiveSettings.SearchBackgroundJobsSettings).WithGoogleRequestParam("conversion_workspace", request => request.ConversionWorkspace);
            Modify_ApiCall(ref _callSearchBackgroundJobs);
            Modify_SearchBackgroundJobsApiCall(ref _callSearchBackgroundJobs);
            _callDescribeConversionWorkspaceRevisions = clientHelper.BuildApiCall<DescribeConversionWorkspaceRevisionsRequest, DescribeConversionWorkspaceRevisionsResponse>("DescribeConversionWorkspaceRevisions", grpcClient.DescribeConversionWorkspaceRevisionsAsync, grpcClient.DescribeConversionWorkspaceRevisions, effectiveSettings.DescribeConversionWorkspaceRevisionsSettings).WithGoogleRequestParam("conversion_workspace", request => request.ConversionWorkspace);
            Modify_ApiCall(ref _callDescribeConversionWorkspaceRevisions);
            Modify_DescribeConversionWorkspaceRevisionsApiCall(ref _callDescribeConversionWorkspaceRevisions);
            _callFetchStaticIps = clientHelper.BuildApiCall<FetchStaticIpsRequest, FetchStaticIpsResponse>("FetchStaticIps", grpcClient.FetchStaticIpsAsync, grpcClient.FetchStaticIps, effectiveSettings.FetchStaticIpsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchStaticIps);
            Modify_FetchStaticIpsApiCall(ref _callFetchStaticIps);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMigrationJobsApiCall(ref gaxgrpc::ApiCall<ListMigrationJobsRequest, ListMigrationJobsResponse> call);

        partial void Modify_GetMigrationJobApiCall(ref gaxgrpc::ApiCall<GetMigrationJobRequest, MigrationJob> call);

        partial void Modify_CreateMigrationJobApiCall(ref gaxgrpc::ApiCall<CreateMigrationJobRequest, lro::Operation> call);

        partial void Modify_UpdateMigrationJobApiCall(ref gaxgrpc::ApiCall<UpdateMigrationJobRequest, lro::Operation> call);

        partial void Modify_DeleteMigrationJobApiCall(ref gaxgrpc::ApiCall<DeleteMigrationJobRequest, lro::Operation> call);

        partial void Modify_StartMigrationJobApiCall(ref gaxgrpc::ApiCall<StartMigrationJobRequest, lro::Operation> call);

        partial void Modify_StopMigrationJobApiCall(ref gaxgrpc::ApiCall<StopMigrationJobRequest, lro::Operation> call);

        partial void Modify_ResumeMigrationJobApiCall(ref gaxgrpc::ApiCall<ResumeMigrationJobRequest, lro::Operation> call);

        partial void Modify_PromoteMigrationJobApiCall(ref gaxgrpc::ApiCall<PromoteMigrationJobRequest, lro::Operation> call);

        partial void Modify_VerifyMigrationJobApiCall(ref gaxgrpc::ApiCall<VerifyMigrationJobRequest, lro::Operation> call);

        partial void Modify_RestartMigrationJobApiCall(ref gaxgrpc::ApiCall<RestartMigrationJobRequest, lro::Operation> call);

        partial void Modify_GenerateSshScriptApiCall(ref gaxgrpc::ApiCall<GenerateSshScriptRequest, SshScript> call);

        partial void Modify_GenerateTcpProxyScriptApiCall(ref gaxgrpc::ApiCall<GenerateTcpProxyScriptRequest, TcpProxyScript> call);

        partial void Modify_ListConnectionProfilesApiCall(ref gaxgrpc::ApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse> call);

        partial void Modify_GetConnectionProfileApiCall(ref gaxgrpc::ApiCall<GetConnectionProfileRequest, ConnectionProfile> call);

        partial void Modify_CreateConnectionProfileApiCall(ref gaxgrpc::ApiCall<CreateConnectionProfileRequest, lro::Operation> call);

        partial void Modify_UpdateConnectionProfileApiCall(ref gaxgrpc::ApiCall<UpdateConnectionProfileRequest, lro::Operation> call);

        partial void Modify_DeleteConnectionProfileApiCall(ref gaxgrpc::ApiCall<DeleteConnectionProfileRequest, lro::Operation> call);

        partial void Modify_CreatePrivateConnectionApiCall(ref gaxgrpc::ApiCall<CreatePrivateConnectionRequest, lro::Operation> call);

        partial void Modify_GetPrivateConnectionApiCall(ref gaxgrpc::ApiCall<GetPrivateConnectionRequest, PrivateConnection> call);

        partial void Modify_ListPrivateConnectionsApiCall(ref gaxgrpc::ApiCall<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse> call);

        partial void Modify_DeletePrivateConnectionApiCall(ref gaxgrpc::ApiCall<DeletePrivateConnectionRequest, lro::Operation> call);

        partial void Modify_GetConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<GetConversionWorkspaceRequest, ConversionWorkspace> call);

        partial void Modify_ListConversionWorkspacesApiCall(ref gaxgrpc::ApiCall<ListConversionWorkspacesRequest, ListConversionWorkspacesResponse> call);

        partial void Modify_CreateConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<CreateConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_UpdateConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<UpdateConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_DeleteConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<DeleteConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_CreateMappingRuleApiCall(ref gaxgrpc::ApiCall<CreateMappingRuleRequest, MappingRule> call);

        partial void Modify_DeleteMappingRuleApiCall(ref gaxgrpc::ApiCall<DeleteMappingRuleRequest, wkt::Empty> call);

        partial void Modify_ListMappingRulesApiCall(ref gaxgrpc::ApiCall<ListMappingRulesRequest, ListMappingRulesResponse> call);

        partial void Modify_GetMappingRuleApiCall(ref gaxgrpc::ApiCall<GetMappingRuleRequest, MappingRule> call);

        partial void Modify_SeedConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<SeedConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_ImportMappingRulesApiCall(ref gaxgrpc::ApiCall<ImportMappingRulesRequest, lro::Operation> call);

        partial void Modify_ConvertConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<ConvertConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_CommitConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<CommitConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_RollbackConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<RollbackConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_ApplyConversionWorkspaceApiCall(ref gaxgrpc::ApiCall<ApplyConversionWorkspaceRequest, lro::Operation> call);

        partial void Modify_DescribeDatabaseEntitiesApiCall(ref gaxgrpc::ApiCall<DescribeDatabaseEntitiesRequest, DescribeDatabaseEntitiesResponse> call);

        partial void Modify_SearchBackgroundJobsApiCall(ref gaxgrpc::ApiCall<SearchBackgroundJobsRequest, SearchBackgroundJobsResponse> call);

        partial void Modify_DescribeConversionWorkspaceRevisionsApiCall(ref gaxgrpc::ApiCall<DescribeConversionWorkspaceRevisionsRequest, DescribeConversionWorkspaceRevisionsResponse> call);

        partial void Modify_FetchStaticIpsApiCall(ref gaxgrpc::ApiCall<FetchStaticIpsRequest, FetchStaticIpsResponse> call);

        partial void OnConstruction(DataMigrationService.DataMigrationServiceClient grpcClient, DataMigrationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataMigrationService client</summary>
        public override DataMigrationService.DataMigrationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListMigrationJobsRequest(ref ListMigrationJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMigrationJobRequest(ref GetMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMigrationJobRequest(ref CreateMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMigrationJobRequest(ref UpdateMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMigrationJobRequest(ref DeleteMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMigrationJobRequest(ref StartMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopMigrationJobRequest(ref StopMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeMigrationJobRequest(ref ResumeMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteMigrationJobRequest(ref PromoteMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyMigrationJobRequest(ref VerifyMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestartMigrationJobRequest(ref RestartMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateSshScriptRequest(ref GenerateSshScriptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateTcpProxyScriptRequest(ref GenerateTcpProxyScriptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectionProfilesRequest(ref ListConnectionProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionProfileRequest(ref GetConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionProfileRequest(ref CreateConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionProfileRequest(ref UpdateConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionProfileRequest(ref DeleteConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateConnectionRequest(ref CreatePrivateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPrivateConnectionRequest(ref GetPrivateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrivateConnectionsRequest(ref ListPrivateConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePrivateConnectionRequest(ref DeletePrivateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversionWorkspaceRequest(ref GetConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversionWorkspacesRequest(ref ListConversionWorkspacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversionWorkspaceRequest(ref CreateConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversionWorkspaceRequest(ref UpdateConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversionWorkspaceRequest(ref DeleteConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMappingRuleRequest(ref CreateMappingRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMappingRuleRequest(ref DeleteMappingRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMappingRulesRequest(ref ListMappingRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMappingRuleRequest(ref GetMappingRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SeedConversionWorkspaceRequest(ref SeedConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportMappingRulesRequest(ref ImportMappingRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ConvertConversionWorkspaceRequest(ref ConvertConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitConversionWorkspaceRequest(ref CommitConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackConversionWorkspaceRequest(ref RollbackConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApplyConversionWorkspaceRequest(ref ApplyConversionWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DescribeDatabaseEntitiesRequest(ref DescribeDatabaseEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchBackgroundJobsRequest(ref SearchBackgroundJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DescribeConversionWorkspaceRevisionsRequest(ref DescribeConversionWorkspaceRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchStaticIpsRequest(ref FetchStaticIpsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMigrationJobsRequest, ListMigrationJobsResponse, MigrationJob>(_callListMigrationJobs, request, callSettings);
        }

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMigrationJobsRequest, ListMigrationJobsResponse, MigrationJob>(_callListMigrationJobs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MigrationJob GetMigrationJob(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationJobRequest(ref request, ref callSettings);
            return _callGetMigrationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MigrationJob> GetMigrationJobAsync(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationJobRequest(ref request, ref callSettings);
            return _callGetMigrationJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMigrationJob</c>.</summary>
        public override lro::OperationsClient CreateMigrationJobOperationsClient { get; }

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callCreateMigrationJob.Sync(request, callSettings), CreateMigrationJobOperationsClient);
        }

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callCreateMigrationJob.Async(request, callSettings).ConfigureAwait(false), CreateMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMigrationJob</c>.</summary>
        public override lro::OperationsClient UpdateMigrationJobOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> UpdateMigrationJob(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callUpdateMigrationJob.Sync(request, callSettings), UpdateMigrationJobOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callUpdateMigrationJob.Async(request, callSettings).ConfigureAwait(false), UpdateMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMigrationJob</c>.</summary>
        public override lro::OperationsClient DeleteMigrationJobOperationsClient { get; }

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMigrationJob.Sync(request, callSettings), DeleteMigrationJobOperationsClient);
        }

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMigrationJob.Async(request, callSettings).ConfigureAwait(false), DeleteMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartMigrationJob</c>.</summary>
        public override lro::OperationsClient StartMigrationJobOperationsClient { get; }

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> StartMigrationJob(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callStartMigrationJob.Sync(request, callSettings), StartMigrationJobOperationsClient);
        }

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StartMigrationJobAsync(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callStartMigrationJob.Async(request, callSettings).ConfigureAwait(false), StartMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopMigrationJob</c>.</summary>
        public override lro::OperationsClient StopMigrationJobOperationsClient { get; }

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> StopMigrationJob(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callStopMigrationJob.Sync(request, callSettings), StopMigrationJobOperationsClient);
        }

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StopMigrationJobAsync(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callStopMigrationJob.Async(request, callSettings).ConfigureAwait(false), StopMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeMigrationJob</c>.</summary>
        public override lro::OperationsClient ResumeMigrationJobOperationsClient { get; }

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> ResumeMigrationJob(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callResumeMigrationJob.Sync(request, callSettings), ResumeMigrationJobOperationsClient);
        }

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> ResumeMigrationJobAsync(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callResumeMigrationJob.Async(request, callSettings).ConfigureAwait(false), ResumeMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PromoteMigrationJob</c>.</summary>
        public override lro::OperationsClient PromoteMigrationJobOperationsClient { get; }

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> PromoteMigrationJob(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callPromoteMigrationJob.Sync(request, callSettings), PromoteMigrationJobOperationsClient);
        }

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PromoteMigrationJobAsync(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callPromoteMigrationJob.Async(request, callSettings).ConfigureAwait(false), PromoteMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>VerifyMigrationJob</c>.</summary>
        public override lro::OperationsClient VerifyMigrationJobOperationsClient { get; }

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> VerifyMigrationJob(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callVerifyMigrationJob.Sync(request, callSettings), VerifyMigrationJobOperationsClient);
        }

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> VerifyMigrationJobAsync(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callVerifyMigrationJob.Async(request, callSettings).ConfigureAwait(false), VerifyMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestartMigrationJob</c>.</summary>
        public override lro::OperationsClient RestartMigrationJobOperationsClient { get; }

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> RestartMigrationJob(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callRestartMigrationJob.Sync(request, callSettings), RestartMigrationJobOperationsClient);
        }

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> RestartMigrationJobAsync(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callRestartMigrationJob.Async(request, callSettings).ConfigureAwait(false), RestartMigrationJobOperationsClient);
        }

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SshScript GenerateSshScript(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSshScriptRequest(ref request, ref callSettings);
            return _callGenerateSshScript.Sync(request, callSettings);
        }

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SshScript> GenerateSshScriptAsync(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSshScriptRequest(ref request, ref callSettings);
            return _callGenerateSshScript.Async(request, callSettings);
        }

        /// <summary>
        /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM
        /// running a TCP Proxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TcpProxyScript GenerateTcpProxyScript(GenerateTcpProxyScriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTcpProxyScriptRequest(ref request, ref callSettings);
            return _callGenerateTcpProxyScript.Sync(request, callSettings);
        }

        /// <summary>
        /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM
        /// running a TCP Proxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TcpProxyScript> GenerateTcpProxyScriptAsync(GenerateTcpProxyScriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTcpProxyScriptRequest(ref request, ref callSettings);
            return _callGenerateTcpProxyScript.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectionProfilesRequest, ListConnectionProfilesResponse, ConnectionProfile>(_callListConnectionProfiles, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of all connection profiles in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectionProfilesRequest, ListConnectionProfilesResponse, ConnectionProfile>(_callListConnectionProfiles, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectionProfile GetConnectionProfile(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionProfileRequest(ref request, ref callSettings);
            return _callGetConnectionProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionProfileRequest(ref request, ref callSettings);
            return _callGetConnectionProfile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConnectionProfile</c>.</summary>
        public override lro::OperationsClient CreateConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(_callCreateConnectionProfile.Sync(request, callSettings), CreateConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(await _callCreateConnectionProfile.Async(request, callSettings).ConfigureAwait(false), CreateConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConnectionProfile</c>.</summary>
        public override lro::OperationsClient UpdateConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(_callUpdateConnectionProfile.Sync(request, callSettings), UpdateConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(await _callUpdateConnectionProfile.Async(request, callSettings).ConfigureAwait(false), UpdateConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnectionProfile</c>.</summary>
        public override lro::OperationsClient DeleteConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnectionProfile.Sync(request, callSettings), DeleteConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnectionProfile.Async(request, callSettings).ConfigureAwait(false), DeleteConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreatePrivateConnection</c>.</summary>
        public override lro::OperationsClient CreatePrivateConnectionOperationsClient { get; }

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateConnection, OperationMetadata>(_callCreatePrivateConnection.Sync(request, callSettings), CreatePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Creates a new private connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateConnection, OperationMetadata>(await _callCreatePrivateConnection.Async(request, callSettings).ConfigureAwait(false), CreatePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateConnection GetPrivateConnection(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateConnectionRequest(ref request, ref callSettings);
            return _callGetPrivateConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateConnection> GetPrivateConnectionAsync(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateConnectionRequest(ref request, ref callSettings);
            return _callGetPrivateConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse, PrivateConnection>(_callListPrivateConnections, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of private connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse, PrivateConnection>(_callListPrivateConnections, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePrivateConnection</c>.</summary>
        public override lro::OperationsClient DeletePrivateConnectionOperationsClient { get; }

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePrivateConnection.Sync(request, callSettings), DeletePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Deletes a single Database Migration Service private connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePrivateConnection.Async(request, callSettings).ConfigureAwait(false), DeletePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionWorkspace GetConversionWorkspace(GetConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionWorkspaceRequest(ref request, ref callSettings);
            return _callGetConversionWorkspace.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionWorkspace> GetConversionWorkspaceAsync(GetConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionWorkspaceRequest(ref request, ref callSettings);
            return _callGetConversionWorkspace.Async(request, callSettings);
        }

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspaces(ListConversionWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionWorkspacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversionWorkspacesRequest, ListConversionWorkspacesResponse, ConversionWorkspace>(_callListConversionWorkspaces, request, callSettings);
        }

        /// <summary>
        /// Lists conversion workspaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionWorkspace"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> ListConversionWorkspacesAsync(ListConversionWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionWorkspacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversionWorkspacesRequest, ListConversionWorkspacesResponse, ConversionWorkspace>(_callListConversionWorkspaces, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConversionWorkspace</c>.</summary>
        public override lro::OperationsClient CreateConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> CreateConversionWorkspace(CreateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callCreateConversionWorkspace.Sync(request, callSettings), CreateConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Creates a new conversion workspace in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CreateConversionWorkspaceAsync(CreateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callCreateConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), CreateConversionWorkspaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConversionWorkspace</c>.</summary>
        public override lro::OperationsClient UpdateConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> UpdateConversionWorkspace(UpdateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callUpdateConversionWorkspace.Sync(request, callSettings), UpdateConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> UpdateConversionWorkspaceAsync(UpdateConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callUpdateConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), UpdateConversionWorkspaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConversionWorkspace</c>.</summary>
        public override lro::OperationsClient DeleteConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConversionWorkspace(DeleteConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConversionWorkspace.Sync(request, callSettings), DeleteConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Deletes a single conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConversionWorkspaceAsync(DeleteConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), DeleteConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MappingRule CreateMappingRule(CreateMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMappingRuleRequest(ref request, ref callSettings);
            return _callCreateMappingRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new mapping rule for a given conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MappingRule> CreateMappingRuleAsync(CreateMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMappingRuleRequest(ref request, ref callSettings);
            return _callCreateMappingRule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMappingRule(DeleteMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMappingRuleRequest(ref request, ref callSettings);
            _callDeleteMappingRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMappingRuleAsync(DeleteMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMappingRuleRequest(ref request, ref callSettings);
            return _callDeleteMappingRule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MappingRule"/> resources.</returns>
        public override gax::PagedEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRules(ListMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMappingRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMappingRulesRequest, ListMappingRulesResponse, MappingRule>(_callListMappingRules, request, callSettings);
        }

        /// <summary>
        /// Lists the mapping rules for a specific conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MappingRule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> ListMappingRulesAsync(ListMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMappingRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMappingRulesRequest, ListMappingRulesResponse, MappingRule>(_callListMappingRules, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MappingRule GetMappingRule(GetMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMappingRuleRequest(ref request, ref callSettings);
            return _callGetMappingRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a mapping rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MappingRule> GetMappingRuleAsync(GetMappingRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMappingRuleRequest(ref request, ref callSettings);
            return _callGetMappingRule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SeedConversionWorkspace</c>.</summary>
        public override lro::OperationsClient SeedConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Imports a snapshot of the source database into the
        /// conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> SeedConversionWorkspace(SeedConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SeedConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callSeedConversionWorkspace.Sync(request, callSettings), SeedConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Imports a snapshot of the source database into the
        /// conversion workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> SeedConversionWorkspaceAsync(SeedConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SeedConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callSeedConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), SeedConversionWorkspaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportMappingRules</c>.</summary>
        public override lro::OperationsClient ImportMappingRulesOperationsClient { get; }

        /// <summary>
        /// Imports the mapping rules for a given conversion workspace.
        /// Supports various formats of external rules files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> ImportMappingRules(ImportMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportMappingRulesRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callImportMappingRules.Sync(request, callSettings), ImportMappingRulesOperationsClient);
        }

        /// <summary>
        /// Imports the mapping rules for a given conversion workspace.
        /// Supports various formats of external rules files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ImportMappingRulesAsync(ImportMappingRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportMappingRulesRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callImportMappingRules.Async(request, callSettings).ConfigureAwait(false), ImportMappingRulesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ConvertConversionWorkspace</c>.</summary>
        public override lro::OperationsClient ConvertConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Creates a draft tree schema for the destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> ConvertConversionWorkspace(ConvertConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConvertConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callConvertConversionWorkspace.Sync(request, callSettings), ConvertConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Creates a draft tree schema for the destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ConvertConversionWorkspaceAsync(ConvertConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConvertConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callConvertConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), ConvertConversionWorkspaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CommitConversionWorkspace</c>.</summary>
        public override lro::OperationsClient CommitConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Marks all the data in the conversion workspace as committed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> CommitConversionWorkspace(CommitConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callCommitConversionWorkspace.Sync(request, callSettings), CommitConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Marks all the data in the conversion workspace as committed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> CommitConversionWorkspaceAsync(CommitConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callCommitConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), CommitConversionWorkspaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RollbackConversionWorkspace</c>.</summary>
        public override lro::OperationsClient RollbackConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Rolls back a conversion workspace to the last committed snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> RollbackConversionWorkspace(RollbackConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callRollbackConversionWorkspace.Sync(request, callSettings), RollbackConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Rolls back a conversion workspace to the last committed snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> RollbackConversionWorkspaceAsync(RollbackConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callRollbackConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), RollbackConversionWorkspaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ApplyConversionWorkspace</c>.</summary>
        public override lro::OperationsClient ApplyConversionWorkspaceOperationsClient { get; }

        /// <summary>
        /// Applies draft tree onto a specific destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversionWorkspace, OperationMetadata> ApplyConversionWorkspace(ApplyConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(_callApplyConversionWorkspace.Sync(request, callSettings), ApplyConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Applies draft tree onto a specific destination database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversionWorkspace, OperationMetadata>> ApplyConversionWorkspaceAsync(ApplyConversionWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyConversionWorkspaceRequest(ref request, ref callSettings);
            return new lro::Operation<ConversionWorkspace, OperationMetadata>(await _callApplyConversionWorkspace.Async(request, callSettings).ConfigureAwait(false), ApplyConversionWorkspaceOperationsClient);
        }

        /// <summary>
        /// Describes the database entities tree for a specific conversion workspace
        /// and a specific tree type.
        /// 
        /// Database entities are not resources like conversion workspaces or mapping
        /// rules, and they can't be created, updated or deleted. Instead, they are
        /// simple data objects describing the structure of the client database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatabaseEntity"/> resources.</returns>
        public override gax::PagedEnumerable<DescribeDatabaseEntitiesResponse, DatabaseEntity> DescribeDatabaseEntities(DescribeDatabaseEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DescribeDatabaseEntitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<DescribeDatabaseEntitiesRequest, DescribeDatabaseEntitiesResponse, DatabaseEntity>(_callDescribeDatabaseEntities, request, callSettings);
        }

        /// <summary>
        /// Describes the database entities tree for a specific conversion workspace
        /// and a specific tree type.
        /// 
        /// Database entities are not resources like conversion workspaces or mapping
        /// rules, and they can't be created, updated or deleted. Instead, they are
        /// simple data objects describing the structure of the client database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatabaseEntity"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<DescribeDatabaseEntitiesResponse, DatabaseEntity> DescribeDatabaseEntitiesAsync(DescribeDatabaseEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DescribeDatabaseEntitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<DescribeDatabaseEntitiesRequest, DescribeDatabaseEntitiesResponse, DatabaseEntity>(_callDescribeDatabaseEntities, request, callSettings);
        }

        /// <summary>
        /// Searches/lists the background jobs for a specific
        /// conversion workspace.
        /// 
        /// The background jobs are not resources like conversion workspaces or
        /// mapping rules, and they can't be created, updated or deleted.
        /// Instead, they are a way to expose the data plane jobs log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchBackgroundJobsResponse SearchBackgroundJobs(SearchBackgroundJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchBackgroundJobsRequest(ref request, ref callSettings);
            return _callSearchBackgroundJobs.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches/lists the background jobs for a specific
        /// conversion workspace.
        /// 
        /// The background jobs are not resources like conversion workspaces or
        /// mapping rules, and they can't be created, updated or deleted.
        /// Instead, they are a way to expose the data plane jobs log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchBackgroundJobsResponse> SearchBackgroundJobsAsync(SearchBackgroundJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchBackgroundJobsRequest(ref request, ref callSettings);
            return _callSearchBackgroundJobs.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of committed revisions of a specific conversion
        /// workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DescribeConversionWorkspaceRevisionsResponse DescribeConversionWorkspaceRevisions(DescribeConversionWorkspaceRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DescribeConversionWorkspaceRevisionsRequest(ref request, ref callSettings);
            return _callDescribeConversionWorkspaceRevisions.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of committed revisions of a specific conversion
        /// workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DescribeConversionWorkspaceRevisionsResponse> DescribeConversionWorkspaceRevisionsAsync(DescribeConversionWorkspaceRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DescribeConversionWorkspaceRevisionsRequest(ref request, ref callSettings);
            return _callDescribeConversionWorkspaceRevisions.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchStaticIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchStaticIpsRequest, FetchStaticIpsResponse, string>(_callFetchStaticIps, request, callSettings);
        }

        /// <summary>
        /// Fetches a set of static IP addresses that need to be allowlisted by the
        /// customer when using the static-IP connectivity method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchStaticIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchStaticIpsRequest, FetchStaticIpsResponse, string>(_callFetchStaticIps, request, callSettings);
        }
    }

    public partial class ListMigrationJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversionWorkspacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMappingRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class DescribeDatabaseEntitiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchStaticIpsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMigrationJobsResponse : gaxgrpc::IPageResponse<MigrationJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MigrationJob> GetEnumerator() => MigrationJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectionProfilesResponse : gaxgrpc::IPageResponse<ConnectionProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConnectionProfile> GetEnumerator() => ConnectionProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPrivateConnectionsResponse : gaxgrpc::IPageResponse<PrivateConnection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateConnection> GetEnumerator() => PrivateConnections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConversionWorkspacesResponse : gaxgrpc::IPageResponse<ConversionWorkspace>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversionWorkspace> GetEnumerator() => ConversionWorkspaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMappingRulesResponse : gaxgrpc::IPageResponse<MappingRule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MappingRule> GetEnumerator() => MappingRules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class DescribeDatabaseEntitiesResponse : gaxgrpc::IPageResponse<DatabaseEntity>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DatabaseEntity> GetEnumerator() => DatabaseEntities.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchStaticIpsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => StaticIps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataMigrationService
    {
        public partial class DataMigrationServiceClient
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

    public static partial class DataMigrationService
    {
        public partial class DataMigrationServiceClient
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
