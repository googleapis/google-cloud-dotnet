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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Orchestration.Airflow.Service.V1
{
    /// <summary>Settings for <see cref="EnvironmentsClient"/> instances.</summary>
    public sealed partial class EnvironmentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EnvironmentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EnvironmentsSettings"/>.</returns>
        public static EnvironmentsSettings GetDefault() => new EnvironmentsSettings();

        /// <summary>Constructs a new <see cref="EnvironmentsSettings"/> object with default settings.</summary>
        public EnvironmentsSettings()
        {
        }

        private EnvironmentsSettings(EnvironmentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEnvironmentSettings = existing.CreateEnvironmentSettings;
            CreateEnvironmentOperationsSettings = existing.CreateEnvironmentOperationsSettings.Clone();
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            ListEnvironmentsSettings = existing.ListEnvironmentsSettings;
            UpdateEnvironmentSettings = existing.UpdateEnvironmentSettings;
            UpdateEnvironmentOperationsSettings = existing.UpdateEnvironmentOperationsSettings.Clone();
            DeleteEnvironmentSettings = existing.DeleteEnvironmentSettings;
            DeleteEnvironmentOperationsSettings = existing.DeleteEnvironmentOperationsSettings.Clone();
            ExecuteAirflowCommandSettings = existing.ExecuteAirflowCommandSettings;
            StopAirflowCommandSettings = existing.StopAirflowCommandSettings;
            PollAirflowCommandSettings = existing.PollAirflowCommandSettings;
            ListWorkloadsSettings = existing.ListWorkloadsSettings;
            CheckUpgradeSettings = existing.CheckUpgradeSettings;
            CheckUpgradeOperationsSettings = existing.CheckUpgradeOperationsSettings.Clone();
            CreateUserWorkloadsSecretSettings = existing.CreateUserWorkloadsSecretSettings;
            GetUserWorkloadsSecretSettings = existing.GetUserWorkloadsSecretSettings;
            ListUserWorkloadsSecretsSettings = existing.ListUserWorkloadsSecretsSettings;
            UpdateUserWorkloadsSecretSettings = existing.UpdateUserWorkloadsSecretSettings;
            DeleteUserWorkloadsSecretSettings = existing.DeleteUserWorkloadsSecretSettings;
            CreateUserWorkloadsConfigMapSettings = existing.CreateUserWorkloadsConfigMapSettings;
            GetUserWorkloadsConfigMapSettings = existing.GetUserWorkloadsConfigMapSettings;
            ListUserWorkloadsConfigMapsSettings = existing.ListUserWorkloadsConfigMapsSettings;
            UpdateUserWorkloadsConfigMapSettings = existing.UpdateUserWorkloadsConfigMapSettings;
            DeleteUserWorkloadsConfigMapSettings = existing.DeleteUserWorkloadsConfigMapSettings;
            SaveSnapshotSettings = existing.SaveSnapshotSettings;
            SaveSnapshotOperationsSettings = existing.SaveSnapshotOperationsSettings.Clone();
            LoadSnapshotSettings = existing.LoadSnapshotSettings;
            LoadSnapshotOperationsSettings = existing.LoadSnapshotOperationsSettings.Clone();
            DatabaseFailoverSettings = existing.DatabaseFailoverSettings;
            DatabaseFailoverOperationsSettings = existing.DatabaseFailoverOperationsSettings.Clone();
            FetchDatabasePropertiesSettings = existing.FetchDatabasePropertiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EnvironmentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CreateEnvironment</c> and <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.CreateEnvironment</c> and
        /// <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
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
        public lro::OperationsSettings CreateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetEnvironment</c> and <c>EnvironmentsClient.GetEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListEnvironments</c> and <c>EnvironmentsClient.ListEnvironmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEnvironmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.UpdateEnvironment</c> and <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.UpdateEnvironment</c> and
        /// <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
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
        public lro::OperationsSettings UpdateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeleteEnvironment</c> and <c>EnvironmentsClient.DeleteEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.DeleteEnvironment</c> and
        /// <c>EnvironmentsClient.DeleteEnvironmentAsync</c>.
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
        public lro::OperationsSettings DeleteEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ExecuteAirflowCommand</c> and <c>EnvironmentsClient.ExecuteAirflowCommandAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteAirflowCommandSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.StopAirflowCommand</c> and <c>EnvironmentsClient.StopAirflowCommandAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopAirflowCommandSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.PollAirflowCommand</c> and <c>EnvironmentsClient.PollAirflowCommandAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PollAirflowCommandSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListWorkloads</c> and <c>EnvironmentsClient.ListWorkloadsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkloadsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CheckUpgrade</c> and <c>EnvironmentsClient.CheckUpgradeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckUpgradeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.CheckUpgrade</c> and
        /// <c>EnvironmentsClient.CheckUpgradeAsync</c>.
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
        public lro::OperationsSettings CheckUpgradeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CreateUserWorkloadsSecret</c> and <c>EnvironmentsClient.CreateUserWorkloadsSecretAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserWorkloadsSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetUserWorkloadsSecret</c> and <c>EnvironmentsClient.GetUserWorkloadsSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserWorkloadsSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListUserWorkloadsSecrets</c> and <c>EnvironmentsClient.ListUserWorkloadsSecretsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserWorkloadsSecretsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.UpdateUserWorkloadsSecret</c> and <c>EnvironmentsClient.UpdateUserWorkloadsSecretAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserWorkloadsSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeleteUserWorkloadsSecret</c> and <c>EnvironmentsClient.DeleteUserWorkloadsSecretAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUserWorkloadsSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CreateUserWorkloadsConfigMap</c> and
        /// <c>EnvironmentsClient.CreateUserWorkloadsConfigMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserWorkloadsConfigMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetUserWorkloadsConfigMap</c> and <c>EnvironmentsClient.GetUserWorkloadsConfigMapAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserWorkloadsConfigMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListUserWorkloadsConfigMaps</c> and
        /// <c>EnvironmentsClient.ListUserWorkloadsConfigMapsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserWorkloadsConfigMapsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.UpdateUserWorkloadsConfigMap</c> and
        /// <c>EnvironmentsClient.UpdateUserWorkloadsConfigMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserWorkloadsConfigMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeleteUserWorkloadsConfigMap</c> and
        /// <c>EnvironmentsClient.DeleteUserWorkloadsConfigMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUserWorkloadsConfigMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.SaveSnapshot</c> and <c>EnvironmentsClient.SaveSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SaveSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.SaveSnapshot</c> and
        /// <c>EnvironmentsClient.SaveSnapshotAsync</c>.
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
        public lro::OperationsSettings SaveSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.LoadSnapshot</c> and <c>EnvironmentsClient.LoadSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LoadSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.LoadSnapshot</c> and
        /// <c>EnvironmentsClient.LoadSnapshotAsync</c>.
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
        public lro::OperationsSettings LoadSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DatabaseFailover</c> and <c>EnvironmentsClient.DatabaseFailoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DatabaseFailoverSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.DatabaseFailover</c> and
        /// <c>EnvironmentsClient.DatabaseFailoverAsync</c>.
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
        public lro::OperationsSettings DatabaseFailoverOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.FetchDatabaseProperties</c> and <c>EnvironmentsClient.FetchDatabasePropertiesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchDatabasePropertiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EnvironmentsSettings"/> object.</returns>
        public EnvironmentsSettings Clone() => new EnvironmentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EnvironmentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EnvironmentsClientBuilder : gaxgrpc::ClientBuilderBase<EnvironmentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EnvironmentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EnvironmentsClientBuilder() : base(EnvironmentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EnvironmentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EnvironmentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EnvironmentsClient Build()
        {
            EnvironmentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EnvironmentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EnvironmentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EnvironmentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EnvironmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EnvironmentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EnvironmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EnvironmentsClient.ChannelPool;
    }

    /// <summary>Environments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Managed Apache Airflow Environments.
    /// </remarks>
    public abstract partial class EnvironmentsClient
    {
        /// <summary>
        /// The default endpoint for the Environments service, which is a host of "composer.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "composer.googleapis.com:443";

        /// <summary>The default Environments scopes.</summary>
        /// <remarks>
        /// The default Environments scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Environments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EnvironmentsClient"/>.</returns>
        public static stt::Task<EnvironmentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EnvironmentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        public static EnvironmentsClient Create() => new EnvironmentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EnvironmentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EnvironmentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        internal static EnvironmentsClient Create(grpccore::CallInvoker callInvoker, EnvironmentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Environments.EnvironmentsClient grpcClient = new Environments.EnvironmentsClient(callInvoker);
            return new EnvironmentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Environments client</summary>
        public virtual Environments.EnvironmentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public virtual lro::OperationsClient CreateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceCreateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceCreateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="parent">
        /// The parent must be of the form
        /// "projects/{projectId}/locations/{locationId}".
        /// </param>
        /// <param name="environment">
        /// The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(string parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                Parent = parent ?? "",
                Environment = environment,
            }, callSettings);

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="parent">
        /// The parent must be of the form
        /// "projects/{projectId}/locations/{locationId}".
        /// </param>
        /// <param name="environment">
        /// The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                Parent = parent ?? "",
                Environment = environment,
            }, callSettings);

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="parent">
        /// The parent must be of the form
        /// "projects/{projectId}/locations/{locationId}".
        /// </param>
        /// <param name="environment">
        /// The environment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="name">
        /// The resource name of the environment to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="name">
        /// The resource name of the environment to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="name">
        /// The resource name of the environment to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="parent">
        /// List environments in the given project and location, in the form:
        /// "projects/{projectId}/locations/{locationId}"
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="parent">
        /// List environments in the given project and location, in the form:
        /// "projects/{projectId}/locations/{locationId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public virtual lro::OperationsClient UpdateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceUpdateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceUpdateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the environment to update, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="environment">
        /// A patch environment. Fields specified by the `updateMask` will be copied
        /// from the patch environment into the environment under update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A comma-separated list of paths, relative to `Environment`, of
        /// fields to update.
        /// For example, to set the version of scikit-learn to install in the
        /// environment to 0.19.0 and to remove an existing installation of
        /// numpy, the `updateMask` parameter would include the following two
        /// `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
        /// "config.softwareConfig.pypiPackages.numpy". The included patch
        /// environment would specify the scikit-learn version as follows:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "scikit-learn":"==0.19.0"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing PyPI packages
        /// other than scikit-learn and numpy will be unaffected.
        /// 
        /// Only one update type may be included in a single request's `updateMask`.
        /// For example, one cannot update both the PyPI packages and
        /// labels in the same request. However, it is possible to update multiple
        /// members of a map field simultaneously in the same request. For example,
        /// to set the labels "label1" and "label2" while clearing "label3" (assuming
        /// it already exists), one can
        /// provide the paths "labels.label1", "labels.label2", and "labels.label3"
        /// and populate the patch environment as follows:
        /// 
        /// {
        /// "labels":{
        /// "label1":"new-label1-value"
        /// "label2":"new-label2-value"
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing labels that are not
        /// included in the `updateMask` will be unaffected.
        /// 
        /// It is also possible to replace an entire map field by providing the
        /// map field's path in the `updateMask`. The new value of the field will
        /// be that which is provided in the patch environment. For example, to
        /// delete all pre-existing user-specified PyPI packages and
        /// install botocore at version 1.7.14, the `updateMask` would contain
        /// the path "config.softwareConfig.pypiPackages", and
        /// the patch environment would be the following:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "botocore":"==1.7.14"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// **Note:** Only the following fields can be updated:
        /// 
        /// * `config.softwareConfig.pypiPackages`
        /// * Replace all custom custom PyPI packages. If a replacement
        /// package map is not included in `environment`, all custom
        /// PyPI packages are cleared. It is an error to provide both
        /// this mask and a mask specifying an individual package.
        /// * `config.softwareConfig.pypiPackages.`packagename
        /// * Update the custom PyPI package *packagename*,
        /// preserving other packages. To delete the package, include it in
        /// `updateMask`, and omit the mapping for it in
        /// `environment.config.softwareConfig.pypiPackages`. It is an error
        /// to provide both a mask of this form and the
        /// `config.softwareConfig.pypiPackages` mask.
        /// * `labels`
        /// * Replace all environment labels. If a replacement labels map is not
        /// included in `environment`, all labels are cleared. It is an error to
        /// provide both this mask and a mask specifying one or more individual
        /// labels.
        /// * `labels.`labelName
        /// * Set the label named *labelName*, while preserving other
        /// labels. To delete the label, include it in `updateMask` and omit its
        /// mapping in `environment.labels`. It is an error to provide both a
        /// mask of this form and the `labels` mask.
        /// * `config.nodeCount`
        /// * Horizontally scale the number of nodes in the environment. An integer
        /// greater than or equal to 3 must be provided in the `config.nodeCount`
        /// field. Supported for Cloud Composer environments in versions
        /// composer-1.*.*-airflow-*.*.*.
        /// * `config.webServerNetworkAccessControl`
        /// * Replace the environment's current `WebServerNetworkAccessControl`.
        /// * `config.softwareConfig.airflowConfigOverrides`
        /// * Replace all Apache Airflow config overrides. If a replacement config
        /// overrides map is not included in `environment`, all config overrides
        /// are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual config overrides.
        /// * `config.softwareConfig.airflowConfigOverrides.`section-name
        /// * Override the Apache Airflow config property *name* in the
        /// section named *section*, preserving other properties. To
        /// delete the property override, include it in `updateMask` and omit its
        /// mapping in
        /// `environment.config.softwareConfig.airflowConfigOverrides`.
        /// It is an error to provide both a mask of this form and the
        /// `config.softwareConfig.airflowConfigOverrides` mask.
        /// * `config.softwareConfig.envVariables`
        /// * Replace all environment variables. If a replacement environment
        /// variable map is not included in `environment`, all custom environment
        /// variables are cleared.
        /// * `config.softwareConfig.schedulerCount`
        /// * Horizontally scale the number of schedulers in Airflow. A positive
        /// integer not greater than the number of nodes must be provided in the
        /// `config.softwareConfig.schedulerCount` field. Supported for Cloud
        /// Composer environments in versions composer-1.*.*-airflow-2.*.*.
        /// * `config.databaseConfig.machineType`
        /// * Cloud SQL machine type used by Airflow database.
        /// It has to be one of: db-n1-standard-2, db-n1-standard-4,
        /// db-n1-standard-8 or db-n1-standard-16. Supported for Cloud Composer
        /// environments in versions composer-1.*.*-airflow-*.*.*.
        /// * `config.webServerConfig.machineType`
        /// * Machine type on which Airflow web server is running.
        /// It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4
        /// or composer-n1-webserver-8. Supported for Cloud Composer environments
        /// in versions composer-1.*.*-airflow-*.*.*.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> UpdateEnvironment(string name, Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironment(new UpdateEnvironmentRequest
            {
                Name = name ?? "",
                Environment = environment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the environment to update, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="environment">
        /// A patch environment. Fields specified by the `updateMask` will be copied
        /// from the patch environment into the environment under update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A comma-separated list of paths, relative to `Environment`, of
        /// fields to update.
        /// For example, to set the version of scikit-learn to install in the
        /// environment to 0.19.0 and to remove an existing installation of
        /// numpy, the `updateMask` parameter would include the following two
        /// `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
        /// "config.softwareConfig.pypiPackages.numpy". The included patch
        /// environment would specify the scikit-learn version as follows:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "scikit-learn":"==0.19.0"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing PyPI packages
        /// other than scikit-learn and numpy will be unaffected.
        /// 
        /// Only one update type may be included in a single request's `updateMask`.
        /// For example, one cannot update both the PyPI packages and
        /// labels in the same request. However, it is possible to update multiple
        /// members of a map field simultaneously in the same request. For example,
        /// to set the labels "label1" and "label2" while clearing "label3" (assuming
        /// it already exists), one can
        /// provide the paths "labels.label1", "labels.label2", and "labels.label3"
        /// and populate the patch environment as follows:
        /// 
        /// {
        /// "labels":{
        /// "label1":"new-label1-value"
        /// "label2":"new-label2-value"
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing labels that are not
        /// included in the `updateMask` will be unaffected.
        /// 
        /// It is also possible to replace an entire map field by providing the
        /// map field's path in the `updateMask`. The new value of the field will
        /// be that which is provided in the patch environment. For example, to
        /// delete all pre-existing user-specified PyPI packages and
        /// install botocore at version 1.7.14, the `updateMask` would contain
        /// the path "config.softwareConfig.pypiPackages", and
        /// the patch environment would be the following:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "botocore":"==1.7.14"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// **Note:** Only the following fields can be updated:
        /// 
        /// * `config.softwareConfig.pypiPackages`
        /// * Replace all custom custom PyPI packages. If a replacement
        /// package map is not included in `environment`, all custom
        /// PyPI packages are cleared. It is an error to provide both
        /// this mask and a mask specifying an individual package.
        /// * `config.softwareConfig.pypiPackages.`packagename
        /// * Update the custom PyPI package *packagename*,
        /// preserving other packages. To delete the package, include it in
        /// `updateMask`, and omit the mapping for it in
        /// `environment.config.softwareConfig.pypiPackages`. It is an error
        /// to provide both a mask of this form and the
        /// `config.softwareConfig.pypiPackages` mask.
        /// * `labels`
        /// * Replace all environment labels. If a replacement labels map is not
        /// included in `environment`, all labels are cleared. It is an error to
        /// provide both this mask and a mask specifying one or more individual
        /// labels.
        /// * `labels.`labelName
        /// * Set the label named *labelName*, while preserving other
        /// labels. To delete the label, include it in `updateMask` and omit its
        /// mapping in `environment.labels`. It is an error to provide both a
        /// mask of this form and the `labels` mask.
        /// * `config.nodeCount`
        /// * Horizontally scale the number of nodes in the environment. An integer
        /// greater than or equal to 3 must be provided in the `config.nodeCount`
        /// field. Supported for Cloud Composer environments in versions
        /// composer-1.*.*-airflow-*.*.*.
        /// * `config.webServerNetworkAccessControl`
        /// * Replace the environment's current `WebServerNetworkAccessControl`.
        /// * `config.softwareConfig.airflowConfigOverrides`
        /// * Replace all Apache Airflow config overrides. If a replacement config
        /// overrides map is not included in `environment`, all config overrides
        /// are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual config overrides.
        /// * `config.softwareConfig.airflowConfigOverrides.`section-name
        /// * Override the Apache Airflow config property *name* in the
        /// section named *section*, preserving other properties. To
        /// delete the property override, include it in `updateMask` and omit its
        /// mapping in
        /// `environment.config.softwareConfig.airflowConfigOverrides`.
        /// It is an error to provide both a mask of this form and the
        /// `config.softwareConfig.airflowConfigOverrides` mask.
        /// * `config.softwareConfig.envVariables`
        /// * Replace all environment variables. If a replacement environment
        /// variable map is not included in `environment`, all custom environment
        /// variables are cleared.
        /// * `config.softwareConfig.schedulerCount`
        /// * Horizontally scale the number of schedulers in Airflow. A positive
        /// integer not greater than the number of nodes must be provided in the
        /// `config.softwareConfig.schedulerCount` field. Supported for Cloud
        /// Composer environments in versions composer-1.*.*-airflow-2.*.*.
        /// * `config.databaseConfig.machineType`
        /// * Cloud SQL machine type used by Airflow database.
        /// It has to be one of: db-n1-standard-2, db-n1-standard-4,
        /// db-n1-standard-8 or db-n1-standard-16. Supported for Cloud Composer
        /// environments in versions composer-1.*.*-airflow-*.*.*.
        /// * `config.webServerConfig.machineType`
        /// * Machine type on which Airflow web server is running.
        /// It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4
        /// or composer-n1-webserver-8. Supported for Cloud Composer environments
        /// in versions composer-1.*.*-airflow-*.*.*.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(string name, Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironmentAsync(new UpdateEnvironmentRequest
            {
                Name = name ?? "",
                Environment = environment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the environment to update, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="environment">
        /// A patch environment. Fields specified by the `updateMask` will be copied
        /// from the patch environment into the environment under update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A comma-separated list of paths, relative to `Environment`, of
        /// fields to update.
        /// For example, to set the version of scikit-learn to install in the
        /// environment to 0.19.0 and to remove an existing installation of
        /// numpy, the `updateMask` parameter would include the following two
        /// `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
        /// "config.softwareConfig.pypiPackages.numpy". The included patch
        /// environment would specify the scikit-learn version as follows:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "scikit-learn":"==0.19.0"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing PyPI packages
        /// other than scikit-learn and numpy will be unaffected.
        /// 
        /// Only one update type may be included in a single request's `updateMask`.
        /// For example, one cannot update both the PyPI packages and
        /// labels in the same request. However, it is possible to update multiple
        /// members of a map field simultaneously in the same request. For example,
        /// to set the labels "label1" and "label2" while clearing "label3" (assuming
        /// it already exists), one can
        /// provide the paths "labels.label1", "labels.label2", and "labels.label3"
        /// and populate the patch environment as follows:
        /// 
        /// {
        /// "labels":{
        /// "label1":"new-label1-value"
        /// "label2":"new-label2-value"
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing labels that are not
        /// included in the `updateMask` will be unaffected.
        /// 
        /// It is also possible to replace an entire map field by providing the
        /// map field's path in the `updateMask`. The new value of the field will
        /// be that which is provided in the patch environment. For example, to
        /// delete all pre-existing user-specified PyPI packages and
        /// install botocore at version 1.7.14, the `updateMask` would contain
        /// the path "config.softwareConfig.pypiPackages", and
        /// the patch environment would be the following:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "botocore":"==1.7.14"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// **Note:** Only the following fields can be updated:
        /// 
        /// * `config.softwareConfig.pypiPackages`
        /// * Replace all custom custom PyPI packages. If a replacement
        /// package map is not included in `environment`, all custom
        /// PyPI packages are cleared. It is an error to provide both
        /// this mask and a mask specifying an individual package.
        /// * `config.softwareConfig.pypiPackages.`packagename
        /// * Update the custom PyPI package *packagename*,
        /// preserving other packages. To delete the package, include it in
        /// `updateMask`, and omit the mapping for it in
        /// `environment.config.softwareConfig.pypiPackages`. It is an error
        /// to provide both a mask of this form and the
        /// `config.softwareConfig.pypiPackages` mask.
        /// * `labels`
        /// * Replace all environment labels. If a replacement labels map is not
        /// included in `environment`, all labels are cleared. It is an error to
        /// provide both this mask and a mask specifying one or more individual
        /// labels.
        /// * `labels.`labelName
        /// * Set the label named *labelName*, while preserving other
        /// labels. To delete the label, include it in `updateMask` and omit its
        /// mapping in `environment.labels`. It is an error to provide both a
        /// mask of this form and the `labels` mask.
        /// * `config.nodeCount`
        /// * Horizontally scale the number of nodes in the environment. An integer
        /// greater than or equal to 3 must be provided in the `config.nodeCount`
        /// field. Supported for Cloud Composer environments in versions
        /// composer-1.*.*-airflow-*.*.*.
        /// * `config.webServerNetworkAccessControl`
        /// * Replace the environment's current `WebServerNetworkAccessControl`.
        /// * `config.softwareConfig.airflowConfigOverrides`
        /// * Replace all Apache Airflow config overrides. If a replacement config
        /// overrides map is not included in `environment`, all config overrides
        /// are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual config overrides.
        /// * `config.softwareConfig.airflowConfigOverrides.`section-name
        /// * Override the Apache Airflow config property *name* in the
        /// section named *section*, preserving other properties. To
        /// delete the property override, include it in `updateMask` and omit its
        /// mapping in
        /// `environment.config.softwareConfig.airflowConfigOverrides`.
        /// It is an error to provide both a mask of this form and the
        /// `config.softwareConfig.airflowConfigOverrides` mask.
        /// * `config.softwareConfig.envVariables`
        /// * Replace all environment variables. If a replacement environment
        /// variable map is not included in `environment`, all custom environment
        /// variables are cleared.
        /// * `config.softwareConfig.schedulerCount`
        /// * Horizontally scale the number of schedulers in Airflow. A positive
        /// integer not greater than the number of nodes must be provided in the
        /// `config.softwareConfig.schedulerCount` field. Supported for Cloud
        /// Composer environments in versions composer-1.*.*-airflow-2.*.*.
        /// * `config.databaseConfig.machineType`
        /// * Cloud SQL machine type used by Airflow database.
        /// It has to be one of: db-n1-standard-2, db-n1-standard-4,
        /// db-n1-standard-8 or db-n1-standard-16. Supported for Cloud Composer
        /// environments in versions composer-1.*.*-airflow-*.*.*.
        /// * `config.webServerConfig.machineType`
        /// * Machine type on which Airflow web server is running.
        /// It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4
        /// or composer-n1-webserver-8. Supported for Cloud Composer environments
        /// in versions composer-1.*.*-airflow-*.*.*.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(string name, Environment environment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(name, environment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public virtual lro::OperationsClient DeleteEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="name">
        /// The environment to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="name">
        /// The environment to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="name">
        /// The environment to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes Airflow CLI command.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteAirflowCommandResponse ExecuteAirflowCommand(ExecuteAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes Airflow CLI command.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteAirflowCommandResponse> ExecuteAirflowCommandAsync(ExecuteAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes Airflow CLI command.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteAirflowCommandResponse> ExecuteAirflowCommandAsync(ExecuteAirflowCommandRequest request, st::CancellationToken cancellationToken) =>
            ExecuteAirflowCommandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops Airflow CLI command execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopAirflowCommandResponse StopAirflowCommand(StopAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops Airflow CLI command execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopAirflowCommandResponse> StopAirflowCommandAsync(StopAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops Airflow CLI command execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopAirflowCommandResponse> StopAirflowCommandAsync(StopAirflowCommandRequest request, st::CancellationToken cancellationToken) =>
            StopAirflowCommandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Polls Airflow CLI command execution and fetches logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PollAirflowCommandResponse PollAirflowCommand(PollAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Polls Airflow CLI command execution and fetches logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PollAirflowCommandResponse> PollAirflowCommandAsync(PollAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Polls Airflow CLI command execution and fetches logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PollAirflowCommandResponse> PollAirflowCommandAsync(PollAirflowCommandRequest request, st::CancellationToken cancellationToken) =>
            PollAirflowCommandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to get workloads for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// A pageable sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloads(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to get workloads for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// A pageable asynchronous sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloadsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to get workloads for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// A pageable sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloads(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to get workloads for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// A pageable asynchronous sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloadsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Check if an upgrade operation on the environment will succeed.
        /// 
        /// In case of problems detailed info can be found in the returned Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CheckUpgradeResponse, OperationMetadata> CheckUpgrade(CheckUpgradeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check if an upgrade operation on the environment will succeed.
        /// 
        /// In case of problems detailed info can be found in the returned Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CheckUpgradeResponse, OperationMetadata>> CheckUpgradeAsync(CheckUpgradeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check if an upgrade operation on the environment will succeed.
        /// 
        /// In case of problems detailed info can be found in the returned Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CheckUpgradeResponse, OperationMetadata>> CheckUpgradeAsync(CheckUpgradeRequest request, st::CancellationToken cancellationToken) =>
            CheckUpgradeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CheckUpgrade</c>.</summary>
        public virtual lro::OperationsClient CheckUpgradeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CheckUpgrade</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CheckUpgradeResponse, OperationMetadata> PollOnceCheckUpgrade(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CheckUpgradeResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CheckUpgradeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CheckUpgrade</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CheckUpgradeResponse, OperationMetadata>> PollOnceCheckUpgradeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CheckUpgradeResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CheckUpgradeOperationsClient, callSettings);

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret CreateUserWorkloadsSecret(CreateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(CreateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(CreateUserWorkloadsSecretRequest request, st::CancellationToken cancellationToken) =>
            CreateUserWorkloadsSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a Secret for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsSecret">
        /// Required. User workloads Secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret CreateUserWorkloadsSecret(string parent, UserWorkloadsSecret userWorkloadsSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsSecret(new CreateUserWorkloadsSecretRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserWorkloadsSecret = gax::GaxPreconditions.CheckNotNull(userWorkloadsSecret, nameof(userWorkloadsSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a Secret for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsSecret">
        /// Required. User workloads Secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(string parent, UserWorkloadsSecret userWorkloadsSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsSecretAsync(new CreateUserWorkloadsSecretRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserWorkloadsSecret = gax::GaxPreconditions.CheckNotNull(userWorkloadsSecret, nameof(userWorkloadsSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a Secret for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsSecret">
        /// Required. User workloads Secret to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(string parent, UserWorkloadsSecret userWorkloadsSecret, st::CancellationToken cancellationToken) =>
            CreateUserWorkloadsSecretAsync(parent, userWorkloadsSecret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a Secret for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsSecret">
        /// Required. User workloads Secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret CreateUserWorkloadsSecret(EnvironmentName parent, UserWorkloadsSecret userWorkloadsSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsSecret(new CreateUserWorkloadsSecretRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserWorkloadsSecret = gax::GaxPreconditions.CheckNotNull(userWorkloadsSecret, nameof(userWorkloadsSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a Secret for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsSecret">
        /// Required. User workloads Secret to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(EnvironmentName parent, UserWorkloadsSecret userWorkloadsSecret, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsSecretAsync(new CreateUserWorkloadsSecretRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserWorkloadsSecret = gax::GaxPreconditions.CheckNotNull(userWorkloadsSecret, nameof(userWorkloadsSecret)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a Secret for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsSecret">
        /// Required. User workloads Secret to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(EnvironmentName parent, UserWorkloadsSecret userWorkloadsSecret, st::CancellationToken cancellationToken) =>
            CreateUserWorkloadsSecretAsync(parent, userWorkloadsSecret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret GetUserWorkloadsSecret(GetUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(GetUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(GetUserWorkloadsSecretRequest request, st::CancellationToken cancellationToken) =>
            GetUserWorkloadsSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Secret to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret GetUserWorkloadsSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsSecret(new GetUserWorkloadsSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Secret to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsSecretAsync(new GetUserWorkloadsSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Secret to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserWorkloadsSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Secret to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret GetUserWorkloadsSecret(UserWorkloadsSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsSecret(new GetUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Secret to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(UserWorkloadsSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsSecretAsync(new GetUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Secret to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(UserWorkloadsSecretName name, st::CancellationToken cancellationToken) =>
            GetUserWorkloadsSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecrets(ListUserWorkloadsSecretsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecretsAsync(ListUserWorkloadsSecretsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List Secrets in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecrets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsSecretsRequest request = new ListUserWorkloadsSecretsRequest
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
            return ListUserWorkloadsSecrets(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List Secrets in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecretsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsSecretsRequest request = new ListUserWorkloadsSecretsRequest
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
            return ListUserWorkloadsSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List Secrets in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecrets(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsSecretsRequest request = new ListUserWorkloadsSecretsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserWorkloadsSecrets(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List Secrets in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecretsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsSecretsRequest request = new ListUserWorkloadsSecretsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserWorkloadsSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret UpdateUserWorkloadsSecret(UpdateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> UpdateUserWorkloadsSecretAsync(UpdateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> UpdateUserWorkloadsSecretAsync(UpdateUserWorkloadsSecretRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserWorkloadsSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="userWorkloadsSecret">
        /// Optional. User workloads Secret to override.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsSecret UpdateUserWorkloadsSecret(UserWorkloadsSecret userWorkloadsSecret, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserWorkloadsSecret(new UpdateUserWorkloadsSecretRequest
            {
                UserWorkloadsSecret = userWorkloadsSecret,
            }, callSettings);

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="userWorkloadsSecret">
        /// Optional. User workloads Secret to override.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> UpdateUserWorkloadsSecretAsync(UserWorkloadsSecret userWorkloadsSecret, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserWorkloadsSecretAsync(new UpdateUserWorkloadsSecretRequest
            {
                UserWorkloadsSecret = userWorkloadsSecret,
            }, callSettings);

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="userWorkloadsSecret">
        /// Optional. User workloads Secret to override.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsSecret> UpdateUserWorkloadsSecretAsync(UserWorkloadsSecret userWorkloadsSecret, st::CancellationToken cancellationToken) =>
            UpdateUserWorkloadsSecretAsync(userWorkloadsSecret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserWorkloadsSecret(DeleteUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsSecretAsync(DeleteUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsSecretAsync(DeleteUserWorkloadsSecretRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserWorkloadsSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The Secret to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserWorkloadsSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsSecret(new DeleteUserWorkloadsSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The Secret to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsSecretAsync(new DeleteUserWorkloadsSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The Secret to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsSecretAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserWorkloadsSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The Secret to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserWorkloadsSecret(UserWorkloadsSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsSecret(new DeleteUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The Secret to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsSecretAsync(UserWorkloadsSecretName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsSecretAsync(new DeleteUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The Secret to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsSecretAsync(UserWorkloadsSecretName name, st::CancellationToken cancellationToken) =>
            DeleteUserWorkloadsSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap CreateUserWorkloadsConfigMap(CreateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(CreateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(CreateUserWorkloadsConfigMapRequest request, st::CancellationToken cancellationToken) =>
            CreateUserWorkloadsConfigMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a ConfigMap for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsConfigMap">
        /// Required. User workloads ConfigMap to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap CreateUserWorkloadsConfigMap(string parent, UserWorkloadsConfigMap userWorkloadsConfigMap, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsConfigMap(new CreateUserWorkloadsConfigMapRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserWorkloadsConfigMap = gax::GaxPreconditions.CheckNotNull(userWorkloadsConfigMap, nameof(userWorkloadsConfigMap)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a ConfigMap for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsConfigMap">
        /// Required. User workloads ConfigMap to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(string parent, UserWorkloadsConfigMap userWorkloadsConfigMap, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsConfigMapAsync(new CreateUserWorkloadsConfigMapRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserWorkloadsConfigMap = gax::GaxPreconditions.CheckNotNull(userWorkloadsConfigMap, nameof(userWorkloadsConfigMap)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a ConfigMap for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsConfigMap">
        /// Required. User workloads ConfigMap to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(string parent, UserWorkloadsConfigMap userWorkloadsConfigMap, st::CancellationToken cancellationToken) =>
            CreateUserWorkloadsConfigMapAsync(parent, userWorkloadsConfigMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a ConfigMap for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsConfigMap">
        /// Required. User workloads ConfigMap to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap CreateUserWorkloadsConfigMap(EnvironmentName parent, UserWorkloadsConfigMap userWorkloadsConfigMap, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsConfigMap(new CreateUserWorkloadsConfigMapRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserWorkloadsConfigMap = gax::GaxPreconditions.CheckNotNull(userWorkloadsConfigMap, nameof(userWorkloadsConfigMap)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a ConfigMap for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsConfigMap">
        /// Required. User workloads ConfigMap to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(EnvironmentName parent, UserWorkloadsConfigMap userWorkloadsConfigMap, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserWorkloadsConfigMapAsync(new CreateUserWorkloadsConfigMapRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserWorkloadsConfigMap = gax::GaxPreconditions.CheckNotNull(userWorkloadsConfigMap, nameof(userWorkloadsConfigMap)),
            }, callSettings);

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment name to create a ConfigMap for, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="userWorkloadsConfigMap">
        /// Required. User workloads ConfigMap to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(EnvironmentName parent, UserWorkloadsConfigMap userWorkloadsConfigMap, st::CancellationToken cancellationToken) =>
            CreateUserWorkloadsConfigMapAsync(parent, userWorkloadsConfigMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap GetUserWorkloadsConfigMap(GetUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(GetUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(GetUserWorkloadsConfigMapRequest request, st::CancellationToken cancellationToken) =>
            GetUserWorkloadsConfigMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ConfigMap to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap GetUserWorkloadsConfigMap(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsConfigMap(new GetUserWorkloadsConfigMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ConfigMap to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsConfigMapAsync(new GetUserWorkloadsConfigMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ConfigMap to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserWorkloadsConfigMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ConfigMap to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap GetUserWorkloadsConfigMap(UserWorkloadsConfigMapName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsConfigMap(new GetUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ConfigMap to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserWorkloadsConfigMapAsync(new GetUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ConfigMap to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName name, st::CancellationToken cancellationToken) =>
            GetUserWorkloadsConfigMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMaps(ListUserWorkloadsConfigMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMapsAsync(ListUserWorkloadsConfigMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List ConfigMaps in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMaps(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsConfigMapsRequest request = new ListUserWorkloadsConfigMapsRequest
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
            return ListUserWorkloadsConfigMaps(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List ConfigMaps in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMapsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsConfigMapsRequest request = new ListUserWorkloadsConfigMapsRequest
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
            return ListUserWorkloadsConfigMapsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List ConfigMaps in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMaps(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsConfigMapsRequest request = new ListUserWorkloadsConfigMapsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserWorkloadsConfigMaps(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="parent">
        /// Required. List ConfigMaps in the given environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMapsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserWorkloadsConfigMapsRequest request = new ListUserWorkloadsConfigMapsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserWorkloadsConfigMapsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap UpdateUserWorkloadsConfigMap(UpdateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> UpdateUserWorkloadsConfigMapAsync(UpdateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> UpdateUserWorkloadsConfigMapAsync(UpdateUserWorkloadsConfigMapRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserWorkloadsConfigMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="userWorkloadsConfigMap">
        /// Optional. User workloads ConfigMap to override.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserWorkloadsConfigMap UpdateUserWorkloadsConfigMap(UserWorkloadsConfigMap userWorkloadsConfigMap, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserWorkloadsConfigMap(new UpdateUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMap = userWorkloadsConfigMap,
            }, callSettings);

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="userWorkloadsConfigMap">
        /// Optional. User workloads ConfigMap to override.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> UpdateUserWorkloadsConfigMapAsync(UserWorkloadsConfigMap userWorkloadsConfigMap, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserWorkloadsConfigMapAsync(new UpdateUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMap = userWorkloadsConfigMap,
            }, callSettings);

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="userWorkloadsConfigMap">
        /// Optional. User workloads ConfigMap to override.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserWorkloadsConfigMap> UpdateUserWorkloadsConfigMapAsync(UserWorkloadsConfigMap userWorkloadsConfigMap, st::CancellationToken cancellationToken) =>
            UpdateUserWorkloadsConfigMapAsync(userWorkloadsConfigMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserWorkloadsConfigMap(DeleteUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsConfigMapAsync(DeleteUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsConfigMapAsync(DeleteUserWorkloadsConfigMapRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserWorkloadsConfigMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The ConfigMap to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserWorkloadsConfigMap(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsConfigMap(new DeleteUserWorkloadsConfigMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The ConfigMap to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsConfigMapAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsConfigMapAsync(new DeleteUserWorkloadsConfigMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The ConfigMap to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsConfigMapAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserWorkloadsConfigMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The ConfigMap to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserWorkloadsConfigMap(UserWorkloadsConfigMapName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsConfigMap(new DeleteUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The ConfigMap to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserWorkloadsConfigMapAsync(new DeleteUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="name">
        /// Required. The ConfigMap to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName name, st::CancellationToken cancellationToken) =>
            DeleteUserWorkloadsConfigMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshots of a Cloud Composer environment.
        /// 
        /// As a result of this operation, snapshot of environment's state is stored
        /// in a location specified in the SaveSnapshotRequest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SaveSnapshotResponse, OperationMetadata> SaveSnapshot(SaveSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshots of a Cloud Composer environment.
        /// 
        /// As a result of this operation, snapshot of environment's state is stored
        /// in a location specified in the SaveSnapshotRequest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SaveSnapshotResponse, OperationMetadata>> SaveSnapshotAsync(SaveSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshots of a Cloud Composer environment.
        /// 
        /// As a result of this operation, snapshot of environment's state is stored
        /// in a location specified in the SaveSnapshotRequest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SaveSnapshotResponse, OperationMetadata>> SaveSnapshotAsync(SaveSnapshotRequest request, st::CancellationToken cancellationToken) =>
            SaveSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SaveSnapshot</c>.</summary>
        public virtual lro::OperationsClient SaveSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SaveSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SaveSnapshotResponse, OperationMetadata> PollOnceSaveSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SaveSnapshotResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SaveSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SaveSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SaveSnapshotResponse, OperationMetadata>> PollOnceSaveSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SaveSnapshotResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SaveSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Loads a snapshot of a Cloud Composer environment.
        /// 
        /// As a result of this operation, a snapshot of environment's specified in
        /// LoadSnapshotRequest is loaded into the environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LoadSnapshotResponse, OperationMetadata> LoadSnapshot(LoadSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Loads a snapshot of a Cloud Composer environment.
        /// 
        /// As a result of this operation, a snapshot of environment's specified in
        /// LoadSnapshotRequest is loaded into the environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LoadSnapshotResponse, OperationMetadata>> LoadSnapshotAsync(LoadSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Loads a snapshot of a Cloud Composer environment.
        /// 
        /// As a result of this operation, a snapshot of environment's specified in
        /// LoadSnapshotRequest is loaded into the environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LoadSnapshotResponse, OperationMetadata>> LoadSnapshotAsync(LoadSnapshotRequest request, st::CancellationToken cancellationToken) =>
            LoadSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LoadSnapshot</c>.</summary>
        public virtual lro::OperationsClient LoadSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LoadSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LoadSnapshotResponse, OperationMetadata> PollOnceLoadSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LoadSnapshotResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LoadSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LoadSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LoadSnapshotResponse, OperationMetadata>> PollOnceLoadSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LoadSnapshotResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LoadSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Triggers database failover (only for highly resilient environments).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatabaseFailoverResponse, OperationMetadata> DatabaseFailover(DatabaseFailoverRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers database failover (only for highly resilient environments).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatabaseFailoverResponse, OperationMetadata>> DatabaseFailoverAsync(DatabaseFailoverRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers database failover (only for highly resilient environments).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatabaseFailoverResponse, OperationMetadata>> DatabaseFailoverAsync(DatabaseFailoverRequest request, st::CancellationToken cancellationToken) =>
            DatabaseFailoverAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DatabaseFailover</c>.</summary>
        public virtual lro::OperationsClient DatabaseFailoverOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DatabaseFailover</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DatabaseFailoverResponse, OperationMetadata> PollOnceDatabaseFailover(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatabaseFailoverResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DatabaseFailoverOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DatabaseFailover</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DatabaseFailoverResponse, OperationMetadata>> PollOnceDatabaseFailoverAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatabaseFailoverResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DatabaseFailoverOperationsClient, callSettings);

        /// <summary>
        /// Fetches database properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchDatabasePropertiesResponse FetchDatabaseProperties(FetchDatabasePropertiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches database properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchDatabasePropertiesResponse> FetchDatabasePropertiesAsync(FetchDatabasePropertiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches database properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchDatabasePropertiesResponse> FetchDatabasePropertiesAsync(FetchDatabasePropertiesRequest request, st::CancellationToken cancellationToken) =>
            FetchDatabasePropertiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Environments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Managed Apache Airflow Environments.
    /// </remarks>
    public sealed partial class EnvironmentsClientImpl : EnvironmentsClient
    {
        private readonly gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> _callCreateEnvironment;

        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> _callListEnvironments;

        private readonly gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> _callUpdateEnvironment;

        private readonly gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> _callDeleteEnvironment;

        private readonly gaxgrpc::ApiCall<ExecuteAirflowCommandRequest, ExecuteAirflowCommandResponse> _callExecuteAirflowCommand;

        private readonly gaxgrpc::ApiCall<StopAirflowCommandRequest, StopAirflowCommandResponse> _callStopAirflowCommand;

        private readonly gaxgrpc::ApiCall<PollAirflowCommandRequest, PollAirflowCommandResponse> _callPollAirflowCommand;

        private readonly gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> _callListWorkloads;

        private readonly gaxgrpc::ApiCall<CheckUpgradeRequest, lro::Operation> _callCheckUpgrade;

        private readonly gaxgrpc::ApiCall<CreateUserWorkloadsSecretRequest, UserWorkloadsSecret> _callCreateUserWorkloadsSecret;

        private readonly gaxgrpc::ApiCall<GetUserWorkloadsSecretRequest, UserWorkloadsSecret> _callGetUserWorkloadsSecret;

        private readonly gaxgrpc::ApiCall<ListUserWorkloadsSecretsRequest, ListUserWorkloadsSecretsResponse> _callListUserWorkloadsSecrets;

        private readonly gaxgrpc::ApiCall<UpdateUserWorkloadsSecretRequest, UserWorkloadsSecret> _callUpdateUserWorkloadsSecret;

        private readonly gaxgrpc::ApiCall<DeleteUserWorkloadsSecretRequest, wkt::Empty> _callDeleteUserWorkloadsSecret;

        private readonly gaxgrpc::ApiCall<CreateUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap> _callCreateUserWorkloadsConfigMap;

        private readonly gaxgrpc::ApiCall<GetUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap> _callGetUserWorkloadsConfigMap;

        private readonly gaxgrpc::ApiCall<ListUserWorkloadsConfigMapsRequest, ListUserWorkloadsConfigMapsResponse> _callListUserWorkloadsConfigMaps;

        private readonly gaxgrpc::ApiCall<UpdateUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap> _callUpdateUserWorkloadsConfigMap;

        private readonly gaxgrpc::ApiCall<DeleteUserWorkloadsConfigMapRequest, wkt::Empty> _callDeleteUserWorkloadsConfigMap;

        private readonly gaxgrpc::ApiCall<SaveSnapshotRequest, lro::Operation> _callSaveSnapshot;

        private readonly gaxgrpc::ApiCall<LoadSnapshotRequest, lro::Operation> _callLoadSnapshot;

        private readonly gaxgrpc::ApiCall<DatabaseFailoverRequest, lro::Operation> _callDatabaseFailover;

        private readonly gaxgrpc::ApiCall<FetchDatabasePropertiesRequest, FetchDatabasePropertiesResponse> _callFetchDatabaseProperties;

        /// <summary>
        /// Constructs a client wrapper for the Environments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EnvironmentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EnvironmentsClientImpl(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EnvironmentsSettings effectiveSettings = settings ?? EnvironmentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEnvironmentOperationsSettings, logger);
            UpdateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEnvironmentOperationsSettings, logger);
            DeleteEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEnvironmentOperationsSettings, logger);
            CheckUpgradeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CheckUpgradeOperationsSettings, logger);
            SaveSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SaveSnapshotOperationsSettings, logger);
            LoadSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LoadSnapshotOperationsSettings, logger);
            DatabaseFailoverOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DatabaseFailoverOperationsSettings, logger);
            _callCreateEnvironment = clientHelper.BuildApiCall<CreateEnvironmentRequest, lro::Operation>("CreateEnvironment", grpcClient.CreateEnvironmentAsync, grpcClient.CreateEnvironment, effectiveSettings.CreateEnvironmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnvironment);
            Modify_CreateEnvironmentApiCall(ref _callCreateEnvironment);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>("GetEnvironment", grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callListEnvironments = clientHelper.BuildApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse>("ListEnvironments", grpcClient.ListEnvironmentsAsync, grpcClient.ListEnvironments, effectiveSettings.ListEnvironmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnvironments);
            Modify_ListEnvironmentsApiCall(ref _callListEnvironments);
            _callUpdateEnvironment = clientHelper.BuildApiCall<UpdateEnvironmentRequest, lro::Operation>("UpdateEnvironment", grpcClient.UpdateEnvironmentAsync, grpcClient.UpdateEnvironment, effectiveSettings.UpdateEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateEnvironment);
            Modify_UpdateEnvironmentApiCall(ref _callUpdateEnvironment);
            _callDeleteEnvironment = clientHelper.BuildApiCall<DeleteEnvironmentRequest, lro::Operation>("DeleteEnvironment", grpcClient.DeleteEnvironmentAsync, grpcClient.DeleteEnvironment, effectiveSettings.DeleteEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnvironment);
            Modify_DeleteEnvironmentApiCall(ref _callDeleteEnvironment);
            _callExecuteAirflowCommand = clientHelper.BuildApiCall<ExecuteAirflowCommandRequest, ExecuteAirflowCommandResponse>("ExecuteAirflowCommand", grpcClient.ExecuteAirflowCommandAsync, grpcClient.ExecuteAirflowCommand, effectiveSettings.ExecuteAirflowCommandSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callExecuteAirflowCommand);
            Modify_ExecuteAirflowCommandApiCall(ref _callExecuteAirflowCommand);
            _callStopAirflowCommand = clientHelper.BuildApiCall<StopAirflowCommandRequest, StopAirflowCommandResponse>("StopAirflowCommand", grpcClient.StopAirflowCommandAsync, grpcClient.StopAirflowCommand, effectiveSettings.StopAirflowCommandSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callStopAirflowCommand);
            Modify_StopAirflowCommandApiCall(ref _callStopAirflowCommand);
            _callPollAirflowCommand = clientHelper.BuildApiCall<PollAirflowCommandRequest, PollAirflowCommandResponse>("PollAirflowCommand", grpcClient.PollAirflowCommandAsync, grpcClient.PollAirflowCommand, effectiveSettings.PollAirflowCommandSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callPollAirflowCommand);
            Modify_PollAirflowCommandApiCall(ref _callPollAirflowCommand);
            _callListWorkloads = clientHelper.BuildApiCall<ListWorkloadsRequest, ListWorkloadsResponse>("ListWorkloads", grpcClient.ListWorkloadsAsync, grpcClient.ListWorkloads, effectiveSettings.ListWorkloadsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkloads);
            Modify_ListWorkloadsApiCall(ref _callListWorkloads);
            _callCheckUpgrade = clientHelper.BuildApiCall<CheckUpgradeRequest, lro::Operation>("CheckUpgrade", grpcClient.CheckUpgradeAsync, grpcClient.CheckUpgrade, effectiveSettings.CheckUpgradeSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callCheckUpgrade);
            Modify_CheckUpgradeApiCall(ref _callCheckUpgrade);
            _callCreateUserWorkloadsSecret = clientHelper.BuildApiCall<CreateUserWorkloadsSecretRequest, UserWorkloadsSecret>("CreateUserWorkloadsSecret", grpcClient.CreateUserWorkloadsSecretAsync, grpcClient.CreateUserWorkloadsSecret, effectiveSettings.CreateUserWorkloadsSecretSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserWorkloadsSecret);
            Modify_CreateUserWorkloadsSecretApiCall(ref _callCreateUserWorkloadsSecret);
            _callGetUserWorkloadsSecret = clientHelper.BuildApiCall<GetUserWorkloadsSecretRequest, UserWorkloadsSecret>("GetUserWorkloadsSecret", grpcClient.GetUserWorkloadsSecretAsync, grpcClient.GetUserWorkloadsSecret, effectiveSettings.GetUserWorkloadsSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserWorkloadsSecret);
            Modify_GetUserWorkloadsSecretApiCall(ref _callGetUserWorkloadsSecret);
            _callListUserWorkloadsSecrets = clientHelper.BuildApiCall<ListUserWorkloadsSecretsRequest, ListUserWorkloadsSecretsResponse>("ListUserWorkloadsSecrets", grpcClient.ListUserWorkloadsSecretsAsync, grpcClient.ListUserWorkloadsSecrets, effectiveSettings.ListUserWorkloadsSecretsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserWorkloadsSecrets);
            Modify_ListUserWorkloadsSecretsApiCall(ref _callListUserWorkloadsSecrets);
            _callUpdateUserWorkloadsSecret = clientHelper.BuildApiCall<UpdateUserWorkloadsSecretRequest, UserWorkloadsSecret>("UpdateUserWorkloadsSecret", grpcClient.UpdateUserWorkloadsSecretAsync, grpcClient.UpdateUserWorkloadsSecret, effectiveSettings.UpdateUserWorkloadsSecretSettings).WithGoogleRequestParam("user_workloads_secret.name", request => request.UserWorkloadsSecret?.Name);
            Modify_ApiCall(ref _callUpdateUserWorkloadsSecret);
            Modify_UpdateUserWorkloadsSecretApiCall(ref _callUpdateUserWorkloadsSecret);
            _callDeleteUserWorkloadsSecret = clientHelper.BuildApiCall<DeleteUserWorkloadsSecretRequest, wkt::Empty>("DeleteUserWorkloadsSecret", grpcClient.DeleteUserWorkloadsSecretAsync, grpcClient.DeleteUserWorkloadsSecret, effectiveSettings.DeleteUserWorkloadsSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUserWorkloadsSecret);
            Modify_DeleteUserWorkloadsSecretApiCall(ref _callDeleteUserWorkloadsSecret);
            _callCreateUserWorkloadsConfigMap = clientHelper.BuildApiCall<CreateUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap>("CreateUserWorkloadsConfigMap", grpcClient.CreateUserWorkloadsConfigMapAsync, grpcClient.CreateUserWorkloadsConfigMap, effectiveSettings.CreateUserWorkloadsConfigMapSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserWorkloadsConfigMap);
            Modify_CreateUserWorkloadsConfigMapApiCall(ref _callCreateUserWorkloadsConfigMap);
            _callGetUserWorkloadsConfigMap = clientHelper.BuildApiCall<GetUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap>("GetUserWorkloadsConfigMap", grpcClient.GetUserWorkloadsConfigMapAsync, grpcClient.GetUserWorkloadsConfigMap, effectiveSettings.GetUserWorkloadsConfigMapSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserWorkloadsConfigMap);
            Modify_GetUserWorkloadsConfigMapApiCall(ref _callGetUserWorkloadsConfigMap);
            _callListUserWorkloadsConfigMaps = clientHelper.BuildApiCall<ListUserWorkloadsConfigMapsRequest, ListUserWorkloadsConfigMapsResponse>("ListUserWorkloadsConfigMaps", grpcClient.ListUserWorkloadsConfigMapsAsync, grpcClient.ListUserWorkloadsConfigMaps, effectiveSettings.ListUserWorkloadsConfigMapsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserWorkloadsConfigMaps);
            Modify_ListUserWorkloadsConfigMapsApiCall(ref _callListUserWorkloadsConfigMaps);
            _callUpdateUserWorkloadsConfigMap = clientHelper.BuildApiCall<UpdateUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap>("UpdateUserWorkloadsConfigMap", grpcClient.UpdateUserWorkloadsConfigMapAsync, grpcClient.UpdateUserWorkloadsConfigMap, effectiveSettings.UpdateUserWorkloadsConfigMapSettings).WithGoogleRequestParam("user_workloads_config_map.name", request => request.UserWorkloadsConfigMap?.Name);
            Modify_ApiCall(ref _callUpdateUserWorkloadsConfigMap);
            Modify_UpdateUserWorkloadsConfigMapApiCall(ref _callUpdateUserWorkloadsConfigMap);
            _callDeleteUserWorkloadsConfigMap = clientHelper.BuildApiCall<DeleteUserWorkloadsConfigMapRequest, wkt::Empty>("DeleteUserWorkloadsConfigMap", grpcClient.DeleteUserWorkloadsConfigMapAsync, grpcClient.DeleteUserWorkloadsConfigMap, effectiveSettings.DeleteUserWorkloadsConfigMapSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUserWorkloadsConfigMap);
            Modify_DeleteUserWorkloadsConfigMapApiCall(ref _callDeleteUserWorkloadsConfigMap);
            _callSaveSnapshot = clientHelper.BuildApiCall<SaveSnapshotRequest, lro::Operation>("SaveSnapshot", grpcClient.SaveSnapshotAsync, grpcClient.SaveSnapshot, effectiveSettings.SaveSnapshotSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callSaveSnapshot);
            Modify_SaveSnapshotApiCall(ref _callSaveSnapshot);
            _callLoadSnapshot = clientHelper.BuildApiCall<LoadSnapshotRequest, lro::Operation>("LoadSnapshot", grpcClient.LoadSnapshotAsync, grpcClient.LoadSnapshot, effectiveSettings.LoadSnapshotSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callLoadSnapshot);
            Modify_LoadSnapshotApiCall(ref _callLoadSnapshot);
            _callDatabaseFailover = clientHelper.BuildApiCall<DatabaseFailoverRequest, lro::Operation>("DatabaseFailover", grpcClient.DatabaseFailoverAsync, grpcClient.DatabaseFailover, effectiveSettings.DatabaseFailoverSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callDatabaseFailover);
            Modify_DatabaseFailoverApiCall(ref _callDatabaseFailover);
            _callFetchDatabaseProperties = clientHelper.BuildApiCall<FetchDatabasePropertiesRequest, FetchDatabasePropertiesResponse>("FetchDatabaseProperties", grpcClient.FetchDatabasePropertiesAsync, grpcClient.FetchDatabaseProperties, effectiveSettings.FetchDatabasePropertiesSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callFetchDatabaseProperties);
            Modify_FetchDatabasePropertiesApiCall(ref _callFetchDatabaseProperties);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEnvironmentApiCall(ref gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> call);

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_ListEnvironmentsApiCall(ref gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> call);

        partial void Modify_UpdateEnvironmentApiCall(ref gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> call);

        partial void Modify_DeleteEnvironmentApiCall(ref gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> call);

        partial void Modify_ExecuteAirflowCommandApiCall(ref gaxgrpc::ApiCall<ExecuteAirflowCommandRequest, ExecuteAirflowCommandResponse> call);

        partial void Modify_StopAirflowCommandApiCall(ref gaxgrpc::ApiCall<StopAirflowCommandRequest, StopAirflowCommandResponse> call);

        partial void Modify_PollAirflowCommandApiCall(ref gaxgrpc::ApiCall<PollAirflowCommandRequest, PollAirflowCommandResponse> call);

        partial void Modify_ListWorkloadsApiCall(ref gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> call);

        partial void Modify_CheckUpgradeApiCall(ref gaxgrpc::ApiCall<CheckUpgradeRequest, lro::Operation> call);

        partial void Modify_CreateUserWorkloadsSecretApiCall(ref gaxgrpc::ApiCall<CreateUserWorkloadsSecretRequest, UserWorkloadsSecret> call);

        partial void Modify_GetUserWorkloadsSecretApiCall(ref gaxgrpc::ApiCall<GetUserWorkloadsSecretRequest, UserWorkloadsSecret> call);

        partial void Modify_ListUserWorkloadsSecretsApiCall(ref gaxgrpc::ApiCall<ListUserWorkloadsSecretsRequest, ListUserWorkloadsSecretsResponse> call);

        partial void Modify_UpdateUserWorkloadsSecretApiCall(ref gaxgrpc::ApiCall<UpdateUserWorkloadsSecretRequest, UserWorkloadsSecret> call);

        partial void Modify_DeleteUserWorkloadsSecretApiCall(ref gaxgrpc::ApiCall<DeleteUserWorkloadsSecretRequest, wkt::Empty> call);

        partial void Modify_CreateUserWorkloadsConfigMapApiCall(ref gaxgrpc::ApiCall<CreateUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap> call);

        partial void Modify_GetUserWorkloadsConfigMapApiCall(ref gaxgrpc::ApiCall<GetUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap> call);

        partial void Modify_ListUserWorkloadsConfigMapsApiCall(ref gaxgrpc::ApiCall<ListUserWorkloadsConfigMapsRequest, ListUserWorkloadsConfigMapsResponse> call);

        partial void Modify_UpdateUserWorkloadsConfigMapApiCall(ref gaxgrpc::ApiCall<UpdateUserWorkloadsConfigMapRequest, UserWorkloadsConfigMap> call);

        partial void Modify_DeleteUserWorkloadsConfigMapApiCall(ref gaxgrpc::ApiCall<DeleteUserWorkloadsConfigMapRequest, wkt::Empty> call);

        partial void Modify_SaveSnapshotApiCall(ref gaxgrpc::ApiCall<SaveSnapshotRequest, lro::Operation> call);

        partial void Modify_LoadSnapshotApiCall(ref gaxgrpc::ApiCall<LoadSnapshotRequest, lro::Operation> call);

        partial void Modify_DatabaseFailoverApiCall(ref gaxgrpc::ApiCall<DatabaseFailoverRequest, lro::Operation> call);

        partial void Modify_FetchDatabasePropertiesApiCall(ref gaxgrpc::ApiCall<FetchDatabasePropertiesRequest, FetchDatabasePropertiesResponse> call);

        partial void OnConstruction(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Environments client</summary>
        public override Environments.EnvironmentsClient GrpcClient { get; }

        partial void Modify_CreateEnvironmentRequest(ref CreateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEnvironmentsRequest(ref ListEnvironmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEnvironmentRequest(ref UpdateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnvironmentRequest(ref DeleteEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteAirflowCommandRequest(ref ExecuteAirflowCommandRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopAirflowCommandRequest(ref StopAirflowCommandRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PollAirflowCommandRequest(ref PollAirflowCommandRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkloadsRequest(ref ListWorkloadsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckUpgradeRequest(ref CheckUpgradeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserWorkloadsSecretRequest(ref CreateUserWorkloadsSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserWorkloadsSecretRequest(ref GetUserWorkloadsSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserWorkloadsSecretsRequest(ref ListUserWorkloadsSecretsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserWorkloadsSecretRequest(ref UpdateUserWorkloadsSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserWorkloadsSecretRequest(ref DeleteUserWorkloadsSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserWorkloadsConfigMapRequest(ref CreateUserWorkloadsConfigMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserWorkloadsConfigMapRequest(ref GetUserWorkloadsConfigMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserWorkloadsConfigMapsRequest(ref ListUserWorkloadsConfigMapsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserWorkloadsConfigMapRequest(ref UpdateUserWorkloadsConfigMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserWorkloadsConfigMapRequest(ref DeleteUserWorkloadsConfigMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SaveSnapshotRequest(ref SaveSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LoadSnapshotRequest(ref LoadSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DatabaseFailoverRequest(ref DatabaseFailoverRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchDatabasePropertiesRequest(ref FetchDatabasePropertiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public override lro::OperationsClient CreateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callCreateEnvironment.Sync(request, callSettings), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callCreateEnvironment.Async(request, callSettings).ConfigureAwait(false), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public override lro::OperationsClient UpdateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callUpdateEnvironment.Sync(request, callSettings), UpdateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callUpdateEnvironment.Async(request, callSettings).ConfigureAwait(false), UpdateEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public override lro::OperationsClient DeleteEnvironmentOperationsClient { get; }

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEnvironment.Sync(request, callSettings), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEnvironment.Async(request, callSettings).ConfigureAwait(false), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Executes Airflow CLI command.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteAirflowCommandResponse ExecuteAirflowCommand(ExecuteAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteAirflowCommandRequest(ref request, ref callSettings);
            return _callExecuteAirflowCommand.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes Airflow CLI command.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteAirflowCommandResponse> ExecuteAirflowCommandAsync(ExecuteAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteAirflowCommandRequest(ref request, ref callSettings);
            return _callExecuteAirflowCommand.Async(request, callSettings);
        }

        /// <summary>
        /// Stops Airflow CLI command execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StopAirflowCommandResponse StopAirflowCommand(StopAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAirflowCommandRequest(ref request, ref callSettings);
            return _callStopAirflowCommand.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops Airflow CLI command execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StopAirflowCommandResponse> StopAirflowCommandAsync(StopAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAirflowCommandRequest(ref request, ref callSettings);
            return _callStopAirflowCommand.Async(request, callSettings);
        }

        /// <summary>
        /// Polls Airflow CLI command execution and fetches logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PollAirflowCommandResponse PollAirflowCommand(PollAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PollAirflowCommandRequest(ref request, ref callSettings);
            return _callPollAirflowCommand.Sync(request, callSettings);
        }

        /// <summary>
        /// Polls Airflow CLI command execution and fetches logs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PollAirflowCommandResponse> PollAirflowCommandAsync(PollAirflowCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PollAirflowCommandRequest(ref request, ref callSettings);
            return _callPollAirflowCommand.Async(request, callSettings);
        }

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>
        /// Lists workloads in a Cloud Composer environment. Workload is a unit that
        /// runs a single Composer component.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListWorkloadsResponse.Types.ComposerWorkload"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, ListWorkloadsResponse.Types.ComposerWorkload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CheckUpgrade</c>.</summary>
        public override lro::OperationsClient CheckUpgradeOperationsClient { get; }

        /// <summary>
        /// Check if an upgrade operation on the environment will succeed.
        /// 
        /// In case of problems detailed info can be found in the returned Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CheckUpgradeResponse, OperationMetadata> CheckUpgrade(CheckUpgradeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckUpgradeRequest(ref request, ref callSettings);
            return new lro::Operation<CheckUpgradeResponse, OperationMetadata>(_callCheckUpgrade.Sync(request, callSettings), CheckUpgradeOperationsClient);
        }

        /// <summary>
        /// Check if an upgrade operation on the environment will succeed.
        /// 
        /// In case of problems detailed info can be found in the returned Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CheckUpgradeResponse, OperationMetadata>> CheckUpgradeAsync(CheckUpgradeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckUpgradeRequest(ref request, ref callSettings);
            return new lro::Operation<CheckUpgradeResponse, OperationMetadata>(await _callCheckUpgrade.Async(request, callSettings).ConfigureAwait(false), CheckUpgradeOperationsClient);
        }

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserWorkloadsSecret CreateUserWorkloadsSecret(CreateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callCreateUserWorkloadsSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserWorkloadsSecret> CreateUserWorkloadsSecretAsync(CreateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callCreateUserWorkloadsSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserWorkloadsSecret GetUserWorkloadsSecret(GetUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callGetUserWorkloadsSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an existing user workloads Secret.
        /// Values of the "data" field in the response are cleared.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserWorkloadsSecret> GetUserWorkloadsSecretAsync(GetUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callGetUserWorkloadsSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecrets(ListUserWorkloadsSecretsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserWorkloadsSecretsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserWorkloadsSecretsRequest, ListUserWorkloadsSecretsResponse, UserWorkloadsSecret>(_callListUserWorkloadsSecrets, request, callSettings);
        }

        /// <summary>
        /// Lists user workloads Secrets.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsSecret"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserWorkloadsSecretsResponse, UserWorkloadsSecret> ListUserWorkloadsSecretsAsync(ListUserWorkloadsSecretsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserWorkloadsSecretsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserWorkloadsSecretsRequest, ListUserWorkloadsSecretsResponse, UserWorkloadsSecret>(_callListUserWorkloadsSecrets, request, callSettings);
        }

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserWorkloadsSecret UpdateUserWorkloadsSecret(UpdateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callUpdateUserWorkloadsSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserWorkloadsSecret> UpdateUserWorkloadsSecretAsync(UpdateUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callUpdateUserWorkloadsSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUserWorkloadsSecret(DeleteUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserWorkloadsSecretRequest(ref request, ref callSettings);
            _callDeleteUserWorkloadsSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a user workloads Secret.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserWorkloadsSecretAsync(DeleteUserWorkloadsSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserWorkloadsSecretRequest(ref request, ref callSettings);
            return _callDeleteUserWorkloadsSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserWorkloadsConfigMap CreateUserWorkloadsConfigMap(CreateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callCreateUserWorkloadsConfigMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserWorkloadsConfigMap> CreateUserWorkloadsConfigMapAsync(CreateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callCreateUserWorkloadsConfigMap.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserWorkloadsConfigMap GetUserWorkloadsConfigMap(GetUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callGetUserWorkloadsConfigMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an existing user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserWorkloadsConfigMap> GetUserWorkloadsConfigMapAsync(GetUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callGetUserWorkloadsConfigMap.Async(request, callSettings);
        }

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMaps(ListUserWorkloadsConfigMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserWorkloadsConfigMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserWorkloadsConfigMapsRequest, ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap>(_callListUserWorkloadsConfigMaps, request, callSettings);
        }

        /// <summary>
        /// Lists user workloads ConfigMaps.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserWorkloadsConfigMap"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap> ListUserWorkloadsConfigMapsAsync(ListUserWorkloadsConfigMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserWorkloadsConfigMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserWorkloadsConfigMapsRequest, ListUserWorkloadsConfigMapsResponse, UserWorkloadsConfigMap>(_callListUserWorkloadsConfigMaps, request, callSettings);
        }

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserWorkloadsConfigMap UpdateUserWorkloadsConfigMap(UpdateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callUpdateUserWorkloadsConfigMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserWorkloadsConfigMap> UpdateUserWorkloadsConfigMapAsync(UpdateUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callUpdateUserWorkloadsConfigMap.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUserWorkloadsConfigMap(DeleteUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            _callDeleteUserWorkloadsConfigMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a user workloads ConfigMap.
        /// 
        /// This method is supported for Cloud Composer environments in versions
        /// composer-3.*.*-airflow-*.*.* and newer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserWorkloadsConfigMapAsync(DeleteUserWorkloadsConfigMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserWorkloadsConfigMapRequest(ref request, ref callSettings);
            return _callDeleteUserWorkloadsConfigMap.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SaveSnapshot</c>.</summary>
        public override lro::OperationsClient SaveSnapshotOperationsClient { get; }

        /// <summary>
        /// Creates a snapshots of a Cloud Composer environment.
        /// 
        /// As a result of this operation, snapshot of environment's state is stored
        /// in a location specified in the SaveSnapshotRequest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SaveSnapshotResponse, OperationMetadata> SaveSnapshot(SaveSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SaveSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<SaveSnapshotResponse, OperationMetadata>(_callSaveSnapshot.Sync(request, callSettings), SaveSnapshotOperationsClient);
        }

        /// <summary>
        /// Creates a snapshots of a Cloud Composer environment.
        /// 
        /// As a result of this operation, snapshot of environment's state is stored
        /// in a location specified in the SaveSnapshotRequest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SaveSnapshotResponse, OperationMetadata>> SaveSnapshotAsync(SaveSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SaveSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<SaveSnapshotResponse, OperationMetadata>(await _callSaveSnapshot.Async(request, callSettings).ConfigureAwait(false), SaveSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>LoadSnapshot</c>.</summary>
        public override lro::OperationsClient LoadSnapshotOperationsClient { get; }

        /// <summary>
        /// Loads a snapshot of a Cloud Composer environment.
        /// 
        /// As a result of this operation, a snapshot of environment's specified in
        /// LoadSnapshotRequest is loaded into the environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LoadSnapshotResponse, OperationMetadata> LoadSnapshot(LoadSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LoadSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<LoadSnapshotResponse, OperationMetadata>(_callLoadSnapshot.Sync(request, callSettings), LoadSnapshotOperationsClient);
        }

        /// <summary>
        /// Loads a snapshot of a Cloud Composer environment.
        /// 
        /// As a result of this operation, a snapshot of environment's specified in
        /// LoadSnapshotRequest is loaded into the environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LoadSnapshotResponse, OperationMetadata>> LoadSnapshotAsync(LoadSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LoadSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<LoadSnapshotResponse, OperationMetadata>(await _callLoadSnapshot.Async(request, callSettings).ConfigureAwait(false), LoadSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DatabaseFailover</c>.</summary>
        public override lro::OperationsClient DatabaseFailoverOperationsClient { get; }

        /// <summary>
        /// Triggers database failover (only for highly resilient environments).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DatabaseFailoverResponse, OperationMetadata> DatabaseFailover(DatabaseFailoverRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DatabaseFailoverRequest(ref request, ref callSettings);
            return new lro::Operation<DatabaseFailoverResponse, OperationMetadata>(_callDatabaseFailover.Sync(request, callSettings), DatabaseFailoverOperationsClient);
        }

        /// <summary>
        /// Triggers database failover (only for highly resilient environments).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DatabaseFailoverResponse, OperationMetadata>> DatabaseFailoverAsync(DatabaseFailoverRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DatabaseFailoverRequest(ref request, ref callSettings);
            return new lro::Operation<DatabaseFailoverResponse, OperationMetadata>(await _callDatabaseFailover.Async(request, callSettings).ConfigureAwait(false), DatabaseFailoverOperationsClient);
        }

        /// <summary>
        /// Fetches database properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchDatabasePropertiesResponse FetchDatabaseProperties(FetchDatabasePropertiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDatabasePropertiesRequest(ref request, ref callSettings);
            return _callFetchDatabaseProperties.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches database properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchDatabasePropertiesResponse> FetchDatabasePropertiesAsync(FetchDatabasePropertiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDatabasePropertiesRequest(ref request, ref callSettings);
            return _callFetchDatabaseProperties.Async(request, callSettings);
        }
    }

    public partial class ListEnvironmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkloadsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserWorkloadsSecretsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserWorkloadsConfigMapsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnvironmentsResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkloadsResponse : gaxgrpc::IPageResponse<ListWorkloadsResponse.Types.ComposerWorkload>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.ComposerWorkload> GetEnumerator() => Workloads.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUserWorkloadsSecretsResponse : gaxgrpc::IPageResponse<UserWorkloadsSecret>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserWorkloadsSecret> GetEnumerator() => UserWorkloadsSecrets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUserWorkloadsConfigMapsResponse : gaxgrpc::IPageResponse<UserWorkloadsConfigMap>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserWorkloadsConfigMap> GetEnumerator() => UserWorkloadsConfigMaps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Environments
    {
        public partial class EnvironmentsClient
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
}
