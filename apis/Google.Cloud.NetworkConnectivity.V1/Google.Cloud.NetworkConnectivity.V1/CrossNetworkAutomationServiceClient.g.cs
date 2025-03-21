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

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Settings for <see cref="CrossNetworkAutomationServiceClient"/> instances.</summary>
    public sealed partial class CrossNetworkAutomationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CrossNetworkAutomationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CrossNetworkAutomationServiceSettings"/>.</returns>
        public static CrossNetworkAutomationServiceSettings GetDefault() => new CrossNetworkAutomationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CrossNetworkAutomationServiceSettings"/> object with default settings.
        /// </summary>
        public CrossNetworkAutomationServiceSettings()
        {
        }

        private CrossNetworkAutomationServiceSettings(CrossNetworkAutomationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServiceConnectionMapsSettings = existing.ListServiceConnectionMapsSettings;
            GetServiceConnectionMapSettings = existing.GetServiceConnectionMapSettings;
            CreateServiceConnectionMapSettings = existing.CreateServiceConnectionMapSettings;
            CreateServiceConnectionMapOperationsSettings = existing.CreateServiceConnectionMapOperationsSettings.Clone();
            UpdateServiceConnectionMapSettings = existing.UpdateServiceConnectionMapSettings;
            UpdateServiceConnectionMapOperationsSettings = existing.UpdateServiceConnectionMapOperationsSettings.Clone();
            DeleteServiceConnectionMapSettings = existing.DeleteServiceConnectionMapSettings;
            DeleteServiceConnectionMapOperationsSettings = existing.DeleteServiceConnectionMapOperationsSettings.Clone();
            ListServiceConnectionPoliciesSettings = existing.ListServiceConnectionPoliciesSettings;
            GetServiceConnectionPolicySettings = existing.GetServiceConnectionPolicySettings;
            CreateServiceConnectionPolicySettings = existing.CreateServiceConnectionPolicySettings;
            CreateServiceConnectionPolicyOperationsSettings = existing.CreateServiceConnectionPolicyOperationsSettings.Clone();
            UpdateServiceConnectionPolicySettings = existing.UpdateServiceConnectionPolicySettings;
            UpdateServiceConnectionPolicyOperationsSettings = existing.UpdateServiceConnectionPolicyOperationsSettings.Clone();
            DeleteServiceConnectionPolicySettings = existing.DeleteServiceConnectionPolicySettings;
            DeleteServiceConnectionPolicyOperationsSettings = existing.DeleteServiceConnectionPolicyOperationsSettings.Clone();
            ListServiceClassesSettings = existing.ListServiceClassesSettings;
            GetServiceClassSettings = existing.GetServiceClassSettings;
            UpdateServiceClassSettings = existing.UpdateServiceClassSettings;
            UpdateServiceClassOperationsSettings = existing.UpdateServiceClassOperationsSettings.Clone();
            DeleteServiceClassSettings = existing.DeleteServiceClassSettings;
            DeleteServiceClassOperationsSettings = existing.DeleteServiceClassOperationsSettings.Clone();
            GetServiceConnectionTokenSettings = existing.GetServiceConnectionTokenSettings;
            ListServiceConnectionTokensSettings = existing.ListServiceConnectionTokensSettings;
            CreateServiceConnectionTokenSettings = existing.CreateServiceConnectionTokenSettings;
            CreateServiceConnectionTokenOperationsSettings = existing.CreateServiceConnectionTokenOperationsSettings.Clone();
            DeleteServiceConnectionTokenSettings = existing.DeleteServiceConnectionTokenSettings;
            DeleteServiceConnectionTokenOperationsSettings = existing.DeleteServiceConnectionTokenOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(CrossNetworkAutomationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.ListServiceConnectionMaps</c> and
        /// <c>CrossNetworkAutomationServiceClient.ListServiceConnectionMapsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceConnectionMapsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.GetServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.GetServiceConnectionMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceConnectionMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceConnectionMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionMapAsync</c>.
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
        public lro::OperationsSettings CreateServiceConnectionMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceConnectionMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionMapAsync</c>.
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
        public lro::OperationsSettings UpdateServiceConnectionMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceConnectionMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionMap</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionMapAsync</c>.
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
        public lro::OperationsSettings DeleteServiceConnectionMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.ListServiceConnectionPolicies</c> and
        /// <c>CrossNetworkAutomationServiceClient.ListServiceConnectionPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceConnectionPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.GetServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.GetServiceConnectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceConnectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceConnectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionPolicyAsync</c>.
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
        public lro::OperationsSettings CreateServiceConnectionPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceConnectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceConnectionPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateServiceConnectionPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceConnectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionPolicy</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteServiceConnectionPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.ListServiceClasses</c> and
        /// <c>CrossNetworkAutomationServiceClient.ListServiceClassesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceClassesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.GetServiceClass</c> and
        /// <c>CrossNetworkAutomationServiceClient.GetServiceClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceClass</c> and
        /// <c>CrossNetworkAutomationServiceClient.UpdateServiceClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CrossNetworkAutomationServiceClient.UpdateServiceClass</c>
        /// and <c>CrossNetworkAutomationServiceClient.UpdateServiceClassAsync</c>.
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
        public lro::OperationsSettings UpdateServiceClassOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceClass</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CrossNetworkAutomationServiceClient.DeleteServiceClass</c>
        /// and <c>CrossNetworkAutomationServiceClient.DeleteServiceClassAsync</c>.
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
        public lro::OperationsSettings DeleteServiceClassOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.GetServiceConnectionToken</c> and
        /// <c>CrossNetworkAutomationServiceClient.GetServiceConnectionTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceConnectionTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.ListServiceConnectionTokens</c> and
        /// <c>CrossNetworkAutomationServiceClient.ListServiceConnectionTokensAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceConnectionTokensSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionToken</c> and
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceConnectionTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionToken</c> and
        /// <c>CrossNetworkAutomationServiceClient.CreateServiceConnectionTokenAsync</c>.
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
        public lro::OperationsSettings CreateServiceConnectionTokenOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionToken</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceConnectionTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionToken</c> and
        /// <c>CrossNetworkAutomationServiceClient.DeleteServiceConnectionTokenAsync</c>.
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
        public lro::OperationsSettings DeleteServiceConnectionTokenOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CrossNetworkAutomationServiceSettings"/> object.</returns>
        public CrossNetworkAutomationServiceSettings Clone() => new CrossNetworkAutomationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CrossNetworkAutomationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CrossNetworkAutomationServiceClientBuilder : gaxgrpc::ClientBuilderBase<CrossNetworkAutomationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CrossNetworkAutomationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CrossNetworkAutomationServiceClientBuilder() : base(CrossNetworkAutomationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CrossNetworkAutomationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CrossNetworkAutomationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CrossNetworkAutomationServiceClient Build()
        {
            CrossNetworkAutomationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CrossNetworkAutomationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CrossNetworkAutomationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CrossNetworkAutomationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CrossNetworkAutomationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CrossNetworkAutomationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CrossNetworkAutomationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CrossNetworkAutomationServiceClient.ChannelPool;
    }

    /// <summary>CrossNetworkAutomationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service for CrossNetworkAutomation resources.
    /// </remarks>
    public abstract partial class CrossNetworkAutomationServiceClient
    {
        /// <summary>
        /// The default endpoint for the CrossNetworkAutomationService service, which is a host of
        /// "networkconnectivity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default CrossNetworkAutomationService scopes.</summary>
        /// <remarks>
        /// The default CrossNetworkAutomationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CrossNetworkAutomationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CrossNetworkAutomationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CrossNetworkAutomationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CrossNetworkAutomationServiceClient"/>.</returns>
        public static stt::Task<CrossNetworkAutomationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CrossNetworkAutomationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CrossNetworkAutomationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CrossNetworkAutomationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CrossNetworkAutomationServiceClient"/>.</returns>
        public static CrossNetworkAutomationServiceClient Create() =>
            new CrossNetworkAutomationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CrossNetworkAutomationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CrossNetworkAutomationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CrossNetworkAutomationServiceClient"/>.</returns>
        internal static CrossNetworkAutomationServiceClient Create(grpccore::CallInvoker callInvoker, CrossNetworkAutomationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CrossNetworkAutomationService.CrossNetworkAutomationServiceClient grpcClient = new CrossNetworkAutomationService.CrossNetworkAutomationServiceClient(callInvoker);
            return new CrossNetworkAutomationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CrossNetworkAutomationService client</summary>
        public virtual CrossNetworkAutomationService.CrossNetworkAutomationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMaps(ListServiceConnectionMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMapsAsync(ListServiceConnectionMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMaps(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionMapsRequest request = new ListServiceConnectionMapsRequest
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
            return ListServiceConnectionMaps(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMapsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionMapsRequest request = new ListServiceConnectionMapsRequest
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
            return ListServiceConnectionMapsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMaps(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionMapsRequest request = new ListServiceConnectionMapsRequest
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
            return ListServiceConnectionMaps(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMapsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionMapsRequest request = new ListServiceConnectionMapsRequest
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
            return ListServiceConnectionMapsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionMap GetServiceConnectionMap(GetServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(GetServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(GetServiceConnectionMapRequest request, st::CancellationToken cancellationToken) =>
            GetServiceConnectionMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionMap to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionMap GetServiceConnectionMap(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionMap(new GetServiceConnectionMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionMap to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionMapAsync(new GetServiceConnectionMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionMap to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceConnectionMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionMap to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionMap GetServiceConnectionMap(ServiceConnectionMapName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionMap(new GetServiceConnectionMapRequest
            {
                ServiceConnectionMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionMap to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(ServiceConnectionMapName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionMapAsync(new GetServiceConnectionMapRequest
            {
                ServiceConnectionMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionMap to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(ServiceConnectionMapName name, st::CancellationToken cancellationToken) =>
            GetServiceConnectionMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> CreateServiceConnectionMap(CreateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(CreateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(CreateServiceConnectionMapRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceConnectionMap</c>.</summary>
        public virtual lro::OperationsClient CreateServiceConnectionMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceConnectionMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> PollOnceCreateServiceConnectionMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionMap, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceConnectionMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceConnectionMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> PollOnceCreateServiceConnectionMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionMap, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceConnectionMapOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionMap. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionMap">
        /// Required. Initial values for a new ServiceConnectionMaps
        /// </param>
        /// <param name="serviceConnectionMapId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/serviceConnectionMaps/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> CreateServiceConnectionMap(string parent, ServiceConnectionMap serviceConnectionMap, string serviceConnectionMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionMap(new CreateServiceConnectionMapRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceConnectionMapId = serviceConnectionMapId ?? "",
                ServiceConnectionMap = gax::GaxPreconditions.CheckNotNull(serviceConnectionMap, nameof(serviceConnectionMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionMap. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionMap">
        /// Required. Initial values for a new ServiceConnectionMaps
        /// </param>
        /// <param name="serviceConnectionMapId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/serviceConnectionMaps/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(string parent, ServiceConnectionMap serviceConnectionMap, string serviceConnectionMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionMapAsync(new CreateServiceConnectionMapRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceConnectionMapId = serviceConnectionMapId ?? "",
                ServiceConnectionMap = gax::GaxPreconditions.CheckNotNull(serviceConnectionMap, nameof(serviceConnectionMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionMap. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionMap">
        /// Required. Initial values for a new ServiceConnectionMaps
        /// </param>
        /// <param name="serviceConnectionMapId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/serviceConnectionMaps/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(string parent, ServiceConnectionMap serviceConnectionMap, string serviceConnectionMapId, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionMapAsync(parent, serviceConnectionMap, serviceConnectionMapId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionMap. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionMap">
        /// Required. Initial values for a new ServiceConnectionMaps
        /// </param>
        /// <param name="serviceConnectionMapId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/serviceConnectionMaps/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> CreateServiceConnectionMap(gagr::LocationName parent, ServiceConnectionMap serviceConnectionMap, string serviceConnectionMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionMap(new CreateServiceConnectionMapRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceConnectionMapId = serviceConnectionMapId ?? "",
                ServiceConnectionMap = gax::GaxPreconditions.CheckNotNull(serviceConnectionMap, nameof(serviceConnectionMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionMap. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionMap">
        /// Required. Initial values for a new ServiceConnectionMaps
        /// </param>
        /// <param name="serviceConnectionMapId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/serviceConnectionMaps/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(gagr::LocationName parent, ServiceConnectionMap serviceConnectionMap, string serviceConnectionMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionMapAsync(new CreateServiceConnectionMapRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceConnectionMapId = serviceConnectionMapId ?? "",
                ServiceConnectionMap = gax::GaxPreconditions.CheckNotNull(serviceConnectionMap, nameof(serviceConnectionMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionMap. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionMap">
        /// Required. Initial values for a new ServiceConnectionMaps
        /// </param>
        /// <param name="serviceConnectionMapId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/serviceConnectionMaps/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(gagr::LocationName parent, ServiceConnectionMap serviceConnectionMap, string serviceConnectionMapId, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionMapAsync(parent, serviceConnectionMap, serviceConnectionMapId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> UpdateServiceConnectionMap(UpdateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> UpdateServiceConnectionMapAsync(UpdateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> UpdateServiceConnectionMapAsync(UpdateServiceConnectionMapRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceConnectionMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServiceConnectionMap</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceConnectionMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceConnectionMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> PollOnceUpdateServiceConnectionMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionMap, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceConnectionMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceConnectionMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> PollOnceUpdateServiceConnectionMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionMap, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceConnectionMapOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="serviceConnectionMap">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceConnectionMap resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionMap, OperationMetadata> UpdateServiceConnectionMap(ServiceConnectionMap serviceConnectionMap, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceConnectionMap(new UpdateServiceConnectionMapRequest
            {
                UpdateMask = updateMask,
                ServiceConnectionMap = gax::GaxPreconditions.CheckNotNull(serviceConnectionMap, nameof(serviceConnectionMap)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="serviceConnectionMap">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceConnectionMap resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> UpdateServiceConnectionMapAsync(ServiceConnectionMap serviceConnectionMap, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceConnectionMapAsync(new UpdateServiceConnectionMapRequest
            {
                UpdateMask = updateMask,
                ServiceConnectionMap = gax::GaxPreconditions.CheckNotNull(serviceConnectionMap, nameof(serviceConnectionMap)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="serviceConnectionMap">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceConnectionMap resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> UpdateServiceConnectionMapAsync(ServiceConnectionMap serviceConnectionMap, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceConnectionMapAsync(serviceConnectionMap, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionMap(DeleteServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(DeleteServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(DeleteServiceConnectionMapRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceConnectionMap</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceConnectionMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceConnectionMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceConnectionMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceConnectionMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceConnectionMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceConnectionMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceConnectionMapOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionMap to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionMap(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionMap(new DeleteServiceConnectionMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionMap to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionMapAsync(new DeleteServiceConnectionMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionMap to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionMap to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionMap(ServiceConnectionMapName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionMap(new DeleteServiceConnectionMapRequest
            {
                ServiceConnectionMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionMap to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(ServiceConnectionMapName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionMapAsync(new DeleteServiceConnectionMapRequest
            {
                ServiceConnectionMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionMap to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(ServiceConnectionMapName name, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPolicies(ListServiceConnectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPoliciesAsync(ListServiceConnectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionPoliciesRequest request = new ListServiceConnectionPoliciesRequest
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
            return ListServiceConnectionPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionPoliciesRequest request = new ListServiceConnectionPoliciesRequest
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
            return ListServiceConnectionPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionPoliciesRequest request = new ListServiceConnectionPoliciesRequest
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
            return ListServiceConnectionPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionPoliciesRequest request = new ListServiceConnectionPoliciesRequest
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
            return ListServiceConnectionPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionPolicy GetServiceConnectionPolicy(GetServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(GetServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(GetServiceConnectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetServiceConnectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionPolicy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionPolicy GetServiceConnectionPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionPolicy(new GetServiceConnectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionPolicy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionPolicyAsync(new GetServiceConnectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionPolicy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceConnectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionPolicy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionPolicy GetServiceConnectionPolicy(ServiceConnectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionPolicy(new GetServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionPolicy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(ServiceConnectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionPolicyAsync(new GetServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionPolicy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(ServiceConnectionPolicyName name, st::CancellationToken cancellationToken) =>
            GetServiceConnectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> CreateServiceConnectionPolicy(CreateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(CreateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(CreateServiceConnectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceConnectionPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateServiceConnectionPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceConnectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> PollOnceCreateServiceConnectionPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceConnectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceConnectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> PollOnceCreateServiceConnectionPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceConnectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionPolicy. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionPolicy">
        /// Required. Initial values for a new ServiceConnectionPolicies
        /// </param>
        /// <param name="serviceConnectionPolicyId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in
        /// '[...]/projects/p/locations/l/serviceConnectionPolicies/foo') See
        /// https://google.aip.dev/122#resource-id-segments Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> CreateServiceConnectionPolicy(string parent, ServiceConnectionPolicy serviceConnectionPolicy, string serviceConnectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionPolicy(new CreateServiceConnectionPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceConnectionPolicyId = serviceConnectionPolicyId ?? "",
                ServiceConnectionPolicy = gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicy, nameof(serviceConnectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionPolicy. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionPolicy">
        /// Required. Initial values for a new ServiceConnectionPolicies
        /// </param>
        /// <param name="serviceConnectionPolicyId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in
        /// '[...]/projects/p/locations/l/serviceConnectionPolicies/foo') See
        /// https://google.aip.dev/122#resource-id-segments Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(string parent, ServiceConnectionPolicy serviceConnectionPolicy, string serviceConnectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionPolicyAsync(new CreateServiceConnectionPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceConnectionPolicyId = serviceConnectionPolicyId ?? "",
                ServiceConnectionPolicy = gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicy, nameof(serviceConnectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionPolicy. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionPolicy">
        /// Required. Initial values for a new ServiceConnectionPolicies
        /// </param>
        /// <param name="serviceConnectionPolicyId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in
        /// '[...]/projects/p/locations/l/serviceConnectionPolicies/foo') See
        /// https://google.aip.dev/122#resource-id-segments Unique per location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(string parent, ServiceConnectionPolicy serviceConnectionPolicy, string serviceConnectionPolicyId, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionPolicyAsync(parent, serviceConnectionPolicy, serviceConnectionPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionPolicy. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionPolicy">
        /// Required. Initial values for a new ServiceConnectionPolicies
        /// </param>
        /// <param name="serviceConnectionPolicyId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in
        /// '[...]/projects/p/locations/l/serviceConnectionPolicies/foo') See
        /// https://google.aip.dev/122#resource-id-segments Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> CreateServiceConnectionPolicy(gagr::LocationName parent, ServiceConnectionPolicy serviceConnectionPolicy, string serviceConnectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionPolicy(new CreateServiceConnectionPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceConnectionPolicyId = serviceConnectionPolicyId ?? "",
                ServiceConnectionPolicy = gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicy, nameof(serviceConnectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionPolicy. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionPolicy">
        /// Required. Initial values for a new ServiceConnectionPolicies
        /// </param>
        /// <param name="serviceConnectionPolicyId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in
        /// '[...]/projects/p/locations/l/serviceConnectionPolicies/foo') See
        /// https://google.aip.dev/122#resource-id-segments Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(gagr::LocationName parent, ServiceConnectionPolicy serviceConnectionPolicy, string serviceConnectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionPolicyAsync(new CreateServiceConnectionPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceConnectionPolicyId = serviceConnectionPolicyId ?? "",
                ServiceConnectionPolicy = gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicy, nameof(serviceConnectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionPolicy. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionPolicy">
        /// Required. Initial values for a new ServiceConnectionPolicies
        /// </param>
        /// <param name="serviceConnectionPolicyId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in
        /// '[...]/projects/p/locations/l/serviceConnectionPolicies/foo') See
        /// https://google.aip.dev/122#resource-id-segments Unique per location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(gagr::LocationName parent, ServiceConnectionPolicy serviceConnectionPolicy, string serviceConnectionPolicyId, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionPolicyAsync(parent, serviceConnectionPolicy, serviceConnectionPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> UpdateServiceConnectionPolicy(UpdateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> UpdateServiceConnectionPolicyAsync(UpdateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> UpdateServiceConnectionPolicyAsync(UpdateServiceConnectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceConnectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServiceConnectionPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceConnectionPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceConnectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> PollOnceUpdateServiceConnectionPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceConnectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceConnectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> PollOnceUpdateServiceConnectionPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceConnectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="serviceConnectionPolicy">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceConnectionPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionPolicy, OperationMetadata> UpdateServiceConnectionPolicy(ServiceConnectionPolicy serviceConnectionPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceConnectionPolicy(new UpdateServiceConnectionPolicyRequest
            {
                UpdateMask = updateMask,
                ServiceConnectionPolicy = gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicy, nameof(serviceConnectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="serviceConnectionPolicy">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceConnectionPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> UpdateServiceConnectionPolicyAsync(ServiceConnectionPolicy serviceConnectionPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceConnectionPolicyAsync(new UpdateServiceConnectionPolicyRequest
            {
                UpdateMask = updateMask,
                ServiceConnectionPolicy = gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicy, nameof(serviceConnectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="serviceConnectionPolicy">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceConnectionPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> UpdateServiceConnectionPolicyAsync(ServiceConnectionPolicy serviceConnectionPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceConnectionPolicyAsync(serviceConnectionPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionPolicy(DeleteServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(DeleteServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(DeleteServiceConnectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceConnectionPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceConnectionPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceConnectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceConnectionPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceConnectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceConnectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceConnectionPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceConnectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionPolicy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionPolicy(new DeleteServiceConnectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionPolicy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionPolicyAsync(new DeleteServiceConnectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionPolicy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionPolicy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionPolicy(ServiceConnectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionPolicy(new DeleteServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionPolicy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(ServiceConnectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionPolicyAsync(new DeleteServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionPolicy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(ServiceConnectionPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClasses(ListServiceClassesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClassesAsync(ListServiceClassesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClasses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceClassesRequest request = new ListServiceClassesRequest
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
            return ListServiceClasses(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClassesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceClassesRequest request = new ListServiceClassesRequest
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
            return ListServiceClassesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClasses(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceClassesRequest request = new ListServiceClassesRequest
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
            return ListServiceClasses(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClassesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceClassesRequest request = new ListServiceClassesRequest
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
            return ListServiceClassesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceClass GetServiceClass(GetServiceClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceClass> GetServiceClassAsync(GetServiceClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceClass> GetServiceClassAsync(GetServiceClassRequest request, st::CancellationToken cancellationToken) =>
            GetServiceClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceClass to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceClass GetServiceClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceClass(new GetServiceClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceClass to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceClass> GetServiceClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceClassAsync(new GetServiceClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceClass to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceClass> GetServiceClassAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceClass to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceClass GetServiceClass(ServiceClassName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceClass(new GetServiceClassRequest
            {
                ServiceClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceClass to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceClass> GetServiceClassAsync(ServiceClassName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceClassAsync(new GetServiceClassRequest
            {
                ServiceClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceClass to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceClass> GetServiceClassAsync(ServiceClassName name, st::CancellationToken cancellationToken) =>
            GetServiceClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceClass, OperationMetadata> UpdateServiceClass(UpdateServiceClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceClass, OperationMetadata>> UpdateServiceClassAsync(UpdateServiceClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceClass, OperationMetadata>> UpdateServiceClassAsync(UpdateServiceClassRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServiceClass</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceClassOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateServiceClass</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceClass, OperationMetadata> PollOnceUpdateServiceClass(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceClass, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceClassOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceClass</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceClass, OperationMetadata>> PollOnceUpdateServiceClassAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceClass, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceClassOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="serviceClass">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceClass resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceClass, OperationMetadata> UpdateServiceClass(ServiceClass serviceClass, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceClass(new UpdateServiceClassRequest
            {
                UpdateMask = updateMask,
                ServiceClass = gax::GaxPreconditions.CheckNotNull(serviceClass, nameof(serviceClass)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="serviceClass">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceClass resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceClass, OperationMetadata>> UpdateServiceClassAsync(ServiceClass serviceClass, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceClassAsync(new UpdateServiceClassRequest
            {
                UpdateMask = updateMask,
                ServiceClass = gax::GaxPreconditions.CheckNotNull(serviceClass, nameof(serviceClass)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="serviceClass">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceClass resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceClass, OperationMetadata>> UpdateServiceClassAsync(ServiceClass serviceClass, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceClassAsync(serviceClass, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceClass(DeleteServiceClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(DeleteServiceClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(DeleteServiceClassRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceClass</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceClassOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteServiceClass</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceClass(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceClassOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceClass</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceClassAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceClassOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceClass to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceClass(new DeleteServiceClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceClass to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceClassAsync(new DeleteServiceClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceClass to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceClass to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceClass(ServiceClassName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceClass(new DeleteServiceClassRequest
            {
                ServiceClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceClass to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(ServiceClassName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceClassAsync(new DeleteServiceClassRequest
            {
                ServiceClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceClass to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(ServiceClassName name, st::CancellationToken cancellationToken) =>
            DeleteServiceClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionToken GetServiceConnectionToken(GetServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(GetServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(GetServiceConnectionTokenRequest request, st::CancellationToken cancellationToken) =>
            GetServiceConnectionTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionToken to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionToken GetServiceConnectionToken(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionToken(new GetServiceConnectionTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionToken to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionTokenAsync(new GetServiceConnectionTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionToken to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceConnectionTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionToken to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceConnectionToken GetServiceConnectionToken(ServiceConnectionTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionToken(new GetServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionToken to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(ServiceConnectionTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConnectionTokenAsync(new GetServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ServiceConnectionToken to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(ServiceConnectionTokenName name, st::CancellationToken cancellationToken) =>
            GetServiceConnectionTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokens(ListServiceConnectionTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokensAsync(ListServiceConnectionTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokens(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionTokensRequest request = new ListServiceConnectionTokensRequest
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
            return ListServiceConnectionTokens(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokensAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionTokensRequest request = new ListServiceConnectionTokensRequest
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
            return ListServiceConnectionTokensAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokens(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionTokensRequest request = new ListServiceConnectionTokensRequest
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
            return ListServiceConnectionTokens(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name. ex. projects/123/locations/us-east1
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokensAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConnectionTokensRequest request = new ListServiceConnectionTokensRequest
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
            return ListServiceConnectionTokensAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionToken, OperationMetadata> CreateServiceConnectionToken(CreateServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(CreateServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(CreateServiceConnectionTokenRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceConnectionToken</c>.</summary>
        public virtual lro::OperationsClient CreateServiceConnectionTokenOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceConnectionToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceConnectionToken, OperationMetadata> PollOnceCreateServiceConnectionToken(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionToken, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceConnectionTokenOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceConnectionToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> PollOnceCreateServiceConnectionTokenAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceConnectionToken, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceConnectionTokenOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionToken. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionToken">
        /// Required. Initial values for a new ServiceConnectionTokens
        /// </param>
        /// <param name="serviceConnectionTokenId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/ServiceConnectionTokens/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionToken, OperationMetadata> CreateServiceConnectionToken(string parent, ServiceConnectionToken serviceConnectionToken, string serviceConnectionTokenId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionToken(new CreateServiceConnectionTokenRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceConnectionTokenId = serviceConnectionTokenId ?? "",
                ServiceConnectionToken = gax::GaxPreconditions.CheckNotNull(serviceConnectionToken, nameof(serviceConnectionToken)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionToken. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionToken">
        /// Required. Initial values for a new ServiceConnectionTokens
        /// </param>
        /// <param name="serviceConnectionTokenId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/ServiceConnectionTokens/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(string parent, ServiceConnectionToken serviceConnectionToken, string serviceConnectionTokenId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionTokenAsync(new CreateServiceConnectionTokenRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceConnectionTokenId = serviceConnectionTokenId ?? "",
                ServiceConnectionToken = gax::GaxPreconditions.CheckNotNull(serviceConnectionToken, nameof(serviceConnectionToken)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionToken. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionToken">
        /// Required. Initial values for a new ServiceConnectionTokens
        /// </param>
        /// <param name="serviceConnectionTokenId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/ServiceConnectionTokens/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(string parent, ServiceConnectionToken serviceConnectionToken, string serviceConnectionTokenId, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionTokenAsync(parent, serviceConnectionToken, serviceConnectionTokenId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionToken. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionToken">
        /// Required. Initial values for a new ServiceConnectionTokens
        /// </param>
        /// <param name="serviceConnectionTokenId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/ServiceConnectionTokens/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceConnectionToken, OperationMetadata> CreateServiceConnectionToken(gagr::LocationName parent, ServiceConnectionToken serviceConnectionToken, string serviceConnectionTokenId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionToken(new CreateServiceConnectionTokenRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceConnectionTokenId = serviceConnectionTokenId ?? "",
                ServiceConnectionToken = gax::GaxPreconditions.CheckNotNull(serviceConnectionToken, nameof(serviceConnectionToken)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionToken. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionToken">
        /// Required. Initial values for a new ServiceConnectionTokens
        /// </param>
        /// <param name="serviceConnectionTokenId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/ServiceConnectionTokens/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(gagr::LocationName parent, ServiceConnectionToken serviceConnectionToken, string serviceConnectionTokenId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConnectionTokenAsync(new CreateServiceConnectionTokenRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceConnectionTokenId = serviceConnectionTokenId ?? "",
                ServiceConnectionToken = gax::GaxPreconditions.CheckNotNull(serviceConnectionToken, nameof(serviceConnectionToken)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the ServiceConnectionToken. ex.
        /// projects/123/locations/us-east1
        /// </param>
        /// <param name="serviceConnectionToken">
        /// Required. Initial values for a new ServiceConnectionTokens
        /// </param>
        /// <param name="serviceConnectionTokenId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/ServiceConnectionTokens/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// If one is not provided, one will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(gagr::LocationName parent, ServiceConnectionToken serviceConnectionToken, string serviceConnectionTokenId, st::CancellationToken cancellationToken) =>
            CreateServiceConnectionTokenAsync(parent, serviceConnectionToken, serviceConnectionTokenId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionToken(DeleteServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(DeleteServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(DeleteServiceConnectionTokenRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceConnectionToken</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceConnectionTokenOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceConnectionToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceConnectionToken(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceConnectionTokenOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceConnectionToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceConnectionTokenAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceConnectionTokenOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionToken to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionToken(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionToken(new DeleteServiceConnectionTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionToken to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionTokenAsync(new DeleteServiceConnectionTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionToken to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionToken to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionToken(ServiceConnectionTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionToken(new DeleteServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionToken to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(ServiceConnectionTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceConnectionTokenAsync(new DeleteServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ServiceConnectionToken to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(ServiceConnectionTokenName name, st::CancellationToken cancellationToken) =>
            DeleteServiceConnectionTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CrossNetworkAutomationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service for CrossNetworkAutomation resources.
    /// </remarks>
    public sealed partial class CrossNetworkAutomationServiceClientImpl : CrossNetworkAutomationServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListServiceConnectionMapsRequest, ListServiceConnectionMapsResponse> _callListServiceConnectionMaps;

        private readonly gaxgrpc::ApiCall<GetServiceConnectionMapRequest, ServiceConnectionMap> _callGetServiceConnectionMap;

        private readonly gaxgrpc::ApiCall<CreateServiceConnectionMapRequest, lro::Operation> _callCreateServiceConnectionMap;

        private readonly gaxgrpc::ApiCall<UpdateServiceConnectionMapRequest, lro::Operation> _callUpdateServiceConnectionMap;

        private readonly gaxgrpc::ApiCall<DeleteServiceConnectionMapRequest, lro::Operation> _callDeleteServiceConnectionMap;

        private readonly gaxgrpc::ApiCall<ListServiceConnectionPoliciesRequest, ListServiceConnectionPoliciesResponse> _callListServiceConnectionPolicies;

        private readonly gaxgrpc::ApiCall<GetServiceConnectionPolicyRequest, ServiceConnectionPolicy> _callGetServiceConnectionPolicy;

        private readonly gaxgrpc::ApiCall<CreateServiceConnectionPolicyRequest, lro::Operation> _callCreateServiceConnectionPolicy;

        private readonly gaxgrpc::ApiCall<UpdateServiceConnectionPolicyRequest, lro::Operation> _callUpdateServiceConnectionPolicy;

        private readonly gaxgrpc::ApiCall<DeleteServiceConnectionPolicyRequest, lro::Operation> _callDeleteServiceConnectionPolicy;

        private readonly gaxgrpc::ApiCall<ListServiceClassesRequest, ListServiceClassesResponse> _callListServiceClasses;

        private readonly gaxgrpc::ApiCall<GetServiceClassRequest, ServiceClass> _callGetServiceClass;

        private readonly gaxgrpc::ApiCall<UpdateServiceClassRequest, lro::Operation> _callUpdateServiceClass;

        private readonly gaxgrpc::ApiCall<DeleteServiceClassRequest, lro::Operation> _callDeleteServiceClass;

        private readonly gaxgrpc::ApiCall<GetServiceConnectionTokenRequest, ServiceConnectionToken> _callGetServiceConnectionToken;

        private readonly gaxgrpc::ApiCall<ListServiceConnectionTokensRequest, ListServiceConnectionTokensResponse> _callListServiceConnectionTokens;

        private readonly gaxgrpc::ApiCall<CreateServiceConnectionTokenRequest, lro::Operation> _callCreateServiceConnectionToken;

        private readonly gaxgrpc::ApiCall<DeleteServiceConnectionTokenRequest, lro::Operation> _callDeleteServiceConnectionToken;

        /// <summary>
        /// Constructs a client wrapper for the CrossNetworkAutomationService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CrossNetworkAutomationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CrossNetworkAutomationServiceClientImpl(CrossNetworkAutomationService.CrossNetworkAutomationServiceClient grpcClient, CrossNetworkAutomationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CrossNetworkAutomationServiceSettings effectiveSettings = settings ?? CrossNetworkAutomationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateServiceConnectionMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceConnectionMapOperationsSettings, logger);
            UpdateServiceConnectionMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceConnectionMapOperationsSettings, logger);
            DeleteServiceConnectionMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceConnectionMapOperationsSettings, logger);
            CreateServiceConnectionPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceConnectionPolicyOperationsSettings, logger);
            UpdateServiceConnectionPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceConnectionPolicyOperationsSettings, logger);
            DeleteServiceConnectionPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceConnectionPolicyOperationsSettings, logger);
            UpdateServiceClassOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceClassOperationsSettings, logger);
            DeleteServiceClassOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceClassOperationsSettings, logger);
            CreateServiceConnectionTokenOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceConnectionTokenOperationsSettings, logger);
            DeleteServiceConnectionTokenOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceConnectionTokenOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListServiceConnectionMaps = clientHelper.BuildApiCall<ListServiceConnectionMapsRequest, ListServiceConnectionMapsResponse>("ListServiceConnectionMaps", grpcClient.ListServiceConnectionMapsAsync, grpcClient.ListServiceConnectionMaps, effectiveSettings.ListServiceConnectionMapsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceConnectionMaps);
            Modify_ListServiceConnectionMapsApiCall(ref _callListServiceConnectionMaps);
            _callGetServiceConnectionMap = clientHelper.BuildApiCall<GetServiceConnectionMapRequest, ServiceConnectionMap>("GetServiceConnectionMap", grpcClient.GetServiceConnectionMapAsync, grpcClient.GetServiceConnectionMap, effectiveSettings.GetServiceConnectionMapSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceConnectionMap);
            Modify_GetServiceConnectionMapApiCall(ref _callGetServiceConnectionMap);
            _callCreateServiceConnectionMap = clientHelper.BuildApiCall<CreateServiceConnectionMapRequest, lro::Operation>("CreateServiceConnectionMap", grpcClient.CreateServiceConnectionMapAsync, grpcClient.CreateServiceConnectionMap, effectiveSettings.CreateServiceConnectionMapSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceConnectionMap);
            Modify_CreateServiceConnectionMapApiCall(ref _callCreateServiceConnectionMap);
            _callUpdateServiceConnectionMap = clientHelper.BuildApiCall<UpdateServiceConnectionMapRequest, lro::Operation>("UpdateServiceConnectionMap", grpcClient.UpdateServiceConnectionMapAsync, grpcClient.UpdateServiceConnectionMap, effectiveSettings.UpdateServiceConnectionMapSettings).WithGoogleRequestParam("service_connection_map.name", request => request.ServiceConnectionMap?.Name);
            Modify_ApiCall(ref _callUpdateServiceConnectionMap);
            Modify_UpdateServiceConnectionMapApiCall(ref _callUpdateServiceConnectionMap);
            _callDeleteServiceConnectionMap = clientHelper.BuildApiCall<DeleteServiceConnectionMapRequest, lro::Operation>("DeleteServiceConnectionMap", grpcClient.DeleteServiceConnectionMapAsync, grpcClient.DeleteServiceConnectionMap, effectiveSettings.DeleteServiceConnectionMapSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceConnectionMap);
            Modify_DeleteServiceConnectionMapApiCall(ref _callDeleteServiceConnectionMap);
            _callListServiceConnectionPolicies = clientHelper.BuildApiCall<ListServiceConnectionPoliciesRequest, ListServiceConnectionPoliciesResponse>("ListServiceConnectionPolicies", grpcClient.ListServiceConnectionPoliciesAsync, grpcClient.ListServiceConnectionPolicies, effectiveSettings.ListServiceConnectionPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceConnectionPolicies);
            Modify_ListServiceConnectionPoliciesApiCall(ref _callListServiceConnectionPolicies);
            _callGetServiceConnectionPolicy = clientHelper.BuildApiCall<GetServiceConnectionPolicyRequest, ServiceConnectionPolicy>("GetServiceConnectionPolicy", grpcClient.GetServiceConnectionPolicyAsync, grpcClient.GetServiceConnectionPolicy, effectiveSettings.GetServiceConnectionPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceConnectionPolicy);
            Modify_GetServiceConnectionPolicyApiCall(ref _callGetServiceConnectionPolicy);
            _callCreateServiceConnectionPolicy = clientHelper.BuildApiCall<CreateServiceConnectionPolicyRequest, lro::Operation>("CreateServiceConnectionPolicy", grpcClient.CreateServiceConnectionPolicyAsync, grpcClient.CreateServiceConnectionPolicy, effectiveSettings.CreateServiceConnectionPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceConnectionPolicy);
            Modify_CreateServiceConnectionPolicyApiCall(ref _callCreateServiceConnectionPolicy);
            _callUpdateServiceConnectionPolicy = clientHelper.BuildApiCall<UpdateServiceConnectionPolicyRequest, lro::Operation>("UpdateServiceConnectionPolicy", grpcClient.UpdateServiceConnectionPolicyAsync, grpcClient.UpdateServiceConnectionPolicy, effectiveSettings.UpdateServiceConnectionPolicySettings).WithGoogleRequestParam("service_connection_policy.name", request => request.ServiceConnectionPolicy?.Name);
            Modify_ApiCall(ref _callUpdateServiceConnectionPolicy);
            Modify_UpdateServiceConnectionPolicyApiCall(ref _callUpdateServiceConnectionPolicy);
            _callDeleteServiceConnectionPolicy = clientHelper.BuildApiCall<DeleteServiceConnectionPolicyRequest, lro::Operation>("DeleteServiceConnectionPolicy", grpcClient.DeleteServiceConnectionPolicyAsync, grpcClient.DeleteServiceConnectionPolicy, effectiveSettings.DeleteServiceConnectionPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceConnectionPolicy);
            Modify_DeleteServiceConnectionPolicyApiCall(ref _callDeleteServiceConnectionPolicy);
            _callListServiceClasses = clientHelper.BuildApiCall<ListServiceClassesRequest, ListServiceClassesResponse>("ListServiceClasses", grpcClient.ListServiceClassesAsync, grpcClient.ListServiceClasses, effectiveSettings.ListServiceClassesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceClasses);
            Modify_ListServiceClassesApiCall(ref _callListServiceClasses);
            _callGetServiceClass = clientHelper.BuildApiCall<GetServiceClassRequest, ServiceClass>("GetServiceClass", grpcClient.GetServiceClassAsync, grpcClient.GetServiceClass, effectiveSettings.GetServiceClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceClass);
            Modify_GetServiceClassApiCall(ref _callGetServiceClass);
            _callUpdateServiceClass = clientHelper.BuildApiCall<UpdateServiceClassRequest, lro::Operation>("UpdateServiceClass", grpcClient.UpdateServiceClassAsync, grpcClient.UpdateServiceClass, effectiveSettings.UpdateServiceClassSettings).WithGoogleRequestParam("service_class.name", request => request.ServiceClass?.Name);
            Modify_ApiCall(ref _callUpdateServiceClass);
            Modify_UpdateServiceClassApiCall(ref _callUpdateServiceClass);
            _callDeleteServiceClass = clientHelper.BuildApiCall<DeleteServiceClassRequest, lro::Operation>("DeleteServiceClass", grpcClient.DeleteServiceClassAsync, grpcClient.DeleteServiceClass, effectiveSettings.DeleteServiceClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceClass);
            Modify_DeleteServiceClassApiCall(ref _callDeleteServiceClass);
            _callGetServiceConnectionToken = clientHelper.BuildApiCall<GetServiceConnectionTokenRequest, ServiceConnectionToken>("GetServiceConnectionToken", grpcClient.GetServiceConnectionTokenAsync, grpcClient.GetServiceConnectionToken, effectiveSettings.GetServiceConnectionTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceConnectionToken);
            Modify_GetServiceConnectionTokenApiCall(ref _callGetServiceConnectionToken);
            _callListServiceConnectionTokens = clientHelper.BuildApiCall<ListServiceConnectionTokensRequest, ListServiceConnectionTokensResponse>("ListServiceConnectionTokens", grpcClient.ListServiceConnectionTokensAsync, grpcClient.ListServiceConnectionTokens, effectiveSettings.ListServiceConnectionTokensSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceConnectionTokens);
            Modify_ListServiceConnectionTokensApiCall(ref _callListServiceConnectionTokens);
            _callCreateServiceConnectionToken = clientHelper.BuildApiCall<CreateServiceConnectionTokenRequest, lro::Operation>("CreateServiceConnectionToken", grpcClient.CreateServiceConnectionTokenAsync, grpcClient.CreateServiceConnectionToken, effectiveSettings.CreateServiceConnectionTokenSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceConnectionToken);
            Modify_CreateServiceConnectionTokenApiCall(ref _callCreateServiceConnectionToken);
            _callDeleteServiceConnectionToken = clientHelper.BuildApiCall<DeleteServiceConnectionTokenRequest, lro::Operation>("DeleteServiceConnectionToken", grpcClient.DeleteServiceConnectionTokenAsync, grpcClient.DeleteServiceConnectionToken, effectiveSettings.DeleteServiceConnectionTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceConnectionToken);
            Modify_DeleteServiceConnectionTokenApiCall(ref _callDeleteServiceConnectionToken);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServiceConnectionMapsApiCall(ref gaxgrpc::ApiCall<ListServiceConnectionMapsRequest, ListServiceConnectionMapsResponse> call);

        partial void Modify_GetServiceConnectionMapApiCall(ref gaxgrpc::ApiCall<GetServiceConnectionMapRequest, ServiceConnectionMap> call);

        partial void Modify_CreateServiceConnectionMapApiCall(ref gaxgrpc::ApiCall<CreateServiceConnectionMapRequest, lro::Operation> call);

        partial void Modify_UpdateServiceConnectionMapApiCall(ref gaxgrpc::ApiCall<UpdateServiceConnectionMapRequest, lro::Operation> call);

        partial void Modify_DeleteServiceConnectionMapApiCall(ref gaxgrpc::ApiCall<DeleteServiceConnectionMapRequest, lro::Operation> call);

        partial void Modify_ListServiceConnectionPoliciesApiCall(ref gaxgrpc::ApiCall<ListServiceConnectionPoliciesRequest, ListServiceConnectionPoliciesResponse> call);

        partial void Modify_GetServiceConnectionPolicyApiCall(ref gaxgrpc::ApiCall<GetServiceConnectionPolicyRequest, ServiceConnectionPolicy> call);

        partial void Modify_CreateServiceConnectionPolicyApiCall(ref gaxgrpc::ApiCall<CreateServiceConnectionPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateServiceConnectionPolicyApiCall(ref gaxgrpc::ApiCall<UpdateServiceConnectionPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteServiceConnectionPolicyApiCall(ref gaxgrpc::ApiCall<DeleteServiceConnectionPolicyRequest, lro::Operation> call);

        partial void Modify_ListServiceClassesApiCall(ref gaxgrpc::ApiCall<ListServiceClassesRequest, ListServiceClassesResponse> call);

        partial void Modify_GetServiceClassApiCall(ref gaxgrpc::ApiCall<GetServiceClassRequest, ServiceClass> call);

        partial void Modify_UpdateServiceClassApiCall(ref gaxgrpc::ApiCall<UpdateServiceClassRequest, lro::Operation> call);

        partial void Modify_DeleteServiceClassApiCall(ref gaxgrpc::ApiCall<DeleteServiceClassRequest, lro::Operation> call);

        partial void Modify_GetServiceConnectionTokenApiCall(ref gaxgrpc::ApiCall<GetServiceConnectionTokenRequest, ServiceConnectionToken> call);

        partial void Modify_ListServiceConnectionTokensApiCall(ref gaxgrpc::ApiCall<ListServiceConnectionTokensRequest, ListServiceConnectionTokensResponse> call);

        partial void Modify_CreateServiceConnectionTokenApiCall(ref gaxgrpc::ApiCall<CreateServiceConnectionTokenRequest, lro::Operation> call);

        partial void Modify_DeleteServiceConnectionTokenApiCall(ref gaxgrpc::ApiCall<DeleteServiceConnectionTokenRequest, lro::Operation> call);

        partial void OnConstruction(CrossNetworkAutomationService.CrossNetworkAutomationServiceClient grpcClient, CrossNetworkAutomationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CrossNetworkAutomationService client</summary>
        public override CrossNetworkAutomationService.CrossNetworkAutomationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListServiceConnectionMapsRequest(ref ListServiceConnectionMapsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceConnectionMapRequest(ref GetServiceConnectionMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceConnectionMapRequest(ref CreateServiceConnectionMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceConnectionMapRequest(ref UpdateServiceConnectionMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceConnectionMapRequest(ref DeleteServiceConnectionMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceConnectionPoliciesRequest(ref ListServiceConnectionPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceConnectionPolicyRequest(ref GetServiceConnectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceConnectionPolicyRequest(ref CreateServiceConnectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceConnectionPolicyRequest(ref UpdateServiceConnectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceConnectionPolicyRequest(ref DeleteServiceConnectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceClassesRequest(ref ListServiceClassesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceClassRequest(ref GetServiceClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceClassRequest(ref UpdateServiceClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceClassRequest(ref DeleteServiceClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceConnectionTokenRequest(ref GetServiceConnectionTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceConnectionTokensRequest(ref ListServiceConnectionTokensRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceConnectionTokenRequest(ref CreateServiceConnectionTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceConnectionTokenRequest(ref DeleteServiceConnectionTokenRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMaps(ListServiceConnectionMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConnectionMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceConnectionMapsRequest, ListServiceConnectionMapsResponse, ServiceConnectionMap>(_callListServiceConnectionMaps, request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionMap"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> ListServiceConnectionMapsAsync(ListServiceConnectionMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConnectionMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceConnectionMapsRequest, ListServiceConnectionMapsResponse, ServiceConnectionMap>(_callListServiceConnectionMaps, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceConnectionMap GetServiceConnectionMap(GetServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConnectionMapRequest(ref request, ref callSettings);
            return _callGetServiceConnectionMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceConnectionMap> GetServiceConnectionMapAsync(GetServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConnectionMapRequest(ref request, ref callSettings);
            return _callGetServiceConnectionMap.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceConnectionMap</c>.</summary>
        public override lro::OperationsClient CreateServiceConnectionMapOperationsClient { get; }

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceConnectionMap, OperationMetadata> CreateServiceConnectionMap(CreateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConnectionMapRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionMap, OperationMetadata>(_callCreateServiceConnectionMap.Sync(request, callSettings), CreateServiceConnectionMapOperationsClient);
        }

        /// <summary>
        /// Creates a new ServiceConnectionMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> CreateServiceConnectionMapAsync(CreateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConnectionMapRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionMap, OperationMetadata>(await _callCreateServiceConnectionMap.Async(request, callSettings).ConfigureAwait(false), CreateServiceConnectionMapOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServiceConnectionMap</c>.</summary>
        public override lro::OperationsClient UpdateServiceConnectionMapOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceConnectionMap, OperationMetadata> UpdateServiceConnectionMap(UpdateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceConnectionMapRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionMap, OperationMetadata>(_callUpdateServiceConnectionMap.Sync(request, callSettings), UpdateServiceConnectionMapOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceConnectionMap, OperationMetadata>> UpdateServiceConnectionMapAsync(UpdateServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceConnectionMapRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionMap, OperationMetadata>(await _callUpdateServiceConnectionMap.Async(request, callSettings).ConfigureAwait(false), UpdateServiceConnectionMapOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceConnectionMap</c>.</summary>
        public override lro::OperationsClient DeleteServiceConnectionMapOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionMap(DeleteServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceConnectionMapRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceConnectionMap.Sync(request, callSettings), DeleteServiceConnectionMapOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServiceConnectionMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionMapAsync(DeleteServiceConnectionMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceConnectionMapRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceConnectionMap.Async(request, callSettings).ConfigureAwait(false), DeleteServiceConnectionMapOperationsClient);
        }

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPolicies(ListServiceConnectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConnectionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceConnectionPoliciesRequest, ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy>(_callListServiceConnectionPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> ListServiceConnectionPoliciesAsync(ListServiceConnectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConnectionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceConnectionPoliciesRequest, ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy>(_callListServiceConnectionPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceConnectionPolicy GetServiceConnectionPolicy(GetServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConnectionPolicyRequest(ref request, ref callSettings);
            return _callGetServiceConnectionPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceConnectionPolicy> GetServiceConnectionPolicyAsync(GetServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConnectionPolicyRequest(ref request, ref callSettings);
            return _callGetServiceConnectionPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceConnectionPolicy</c>.</summary>
        public override lro::OperationsClient CreateServiceConnectionPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceConnectionPolicy, OperationMetadata> CreateServiceConnectionPolicy(CreateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConnectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionPolicy, OperationMetadata>(_callCreateServiceConnectionPolicy.Sync(request, callSettings), CreateServiceConnectionPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new ServiceConnectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> CreateServiceConnectionPolicyAsync(CreateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConnectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionPolicy, OperationMetadata>(await _callCreateServiceConnectionPolicy.Async(request, callSettings).ConfigureAwait(false), CreateServiceConnectionPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServiceConnectionPolicy</c>.</summary>
        public override lro::OperationsClient UpdateServiceConnectionPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceConnectionPolicy, OperationMetadata> UpdateServiceConnectionPolicy(UpdateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceConnectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionPolicy, OperationMetadata>(_callUpdateServiceConnectionPolicy.Sync(request, callSettings), UpdateServiceConnectionPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceConnectionPolicy, OperationMetadata>> UpdateServiceConnectionPolicyAsync(UpdateServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceConnectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionPolicy, OperationMetadata>(await _callUpdateServiceConnectionPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateServiceConnectionPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceConnectionPolicy</c>.</summary>
        public override lro::OperationsClient DeleteServiceConnectionPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionPolicy(DeleteServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceConnectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceConnectionPolicy.Sync(request, callSettings), DeleteServiceConnectionPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServiceConnectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionPolicyAsync(DeleteServiceConnectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceConnectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceConnectionPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteServiceConnectionPolicyOperationsClient);
        }

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceClass"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClasses(ListServiceClassesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceClassesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceClassesRequest, ListServiceClassesResponse, ServiceClass>(_callListServiceClasses, request, callSettings);
        }

        /// <summary>
        /// Lists ServiceClasses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceClass"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> ListServiceClassesAsync(ListServiceClassesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceClassesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceClassesRequest, ListServiceClassesResponse, ServiceClass>(_callListServiceClasses, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceClass GetServiceClass(GetServiceClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceClassRequest(ref request, ref callSettings);
            return _callGetServiceClass.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceClass> GetServiceClassAsync(GetServiceClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceClassRequest(ref request, ref callSettings);
            return _callGetServiceClass.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateServiceClass</c>.</summary>
        public override lro::OperationsClient UpdateServiceClassOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceClass, OperationMetadata> UpdateServiceClass(UpdateServiceClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceClassRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceClass, OperationMetadata>(_callUpdateServiceClass.Sync(request, callSettings), UpdateServiceClassOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceClass, OperationMetadata>> UpdateServiceClassAsync(UpdateServiceClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceClassRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceClass, OperationMetadata>(await _callUpdateServiceClass.Async(request, callSettings).ConfigureAwait(false), UpdateServiceClassOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceClass</c>.</summary>
        public override lro::OperationsClient DeleteServiceClassOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceClass(DeleteServiceClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceClassRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceClass.Sync(request, callSettings), DeleteServiceClassOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServiceClass.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceClassAsync(DeleteServiceClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceClassRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceClass.Async(request, callSettings).ConfigureAwait(false), DeleteServiceClassOperationsClient);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceConnectionToken GetServiceConnectionToken(GetServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConnectionTokenRequest(ref request, ref callSettings);
            return _callGetServiceConnectionToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceConnectionToken> GetServiceConnectionTokenAsync(GetServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConnectionTokenRequest(ref request, ref callSettings);
            return _callGetServiceConnectionToken.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokens(ListServiceConnectionTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConnectionTokensRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceConnectionTokensRequest, ListServiceConnectionTokensResponse, ServiceConnectionToken>(_callListServiceConnectionTokens, request, callSettings);
        }

        /// <summary>
        /// Lists ServiceConnectionTokens in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceConnectionToken"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> ListServiceConnectionTokensAsync(ListServiceConnectionTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConnectionTokensRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceConnectionTokensRequest, ListServiceConnectionTokensResponse, ServiceConnectionToken>(_callListServiceConnectionTokens, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceConnectionToken</c>.</summary>
        public override lro::OperationsClient CreateServiceConnectionTokenOperationsClient { get; }

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceConnectionToken, OperationMetadata> CreateServiceConnectionToken(CreateServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConnectionTokenRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionToken, OperationMetadata>(_callCreateServiceConnectionToken.Sync(request, callSettings), CreateServiceConnectionTokenOperationsClient);
        }

        /// <summary>
        /// Creates a new ServiceConnectionToken in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceConnectionToken, OperationMetadata>> CreateServiceConnectionTokenAsync(CreateServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConnectionTokenRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceConnectionToken, OperationMetadata>(await _callCreateServiceConnectionToken.Async(request, callSettings).ConfigureAwait(false), CreateServiceConnectionTokenOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceConnectionToken</c>.</summary>
        public override lro::OperationsClient DeleteServiceConnectionTokenOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceConnectionToken(DeleteServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceConnectionTokenRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceConnectionToken.Sync(request, callSettings), DeleteServiceConnectionTokenOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServiceConnectionToken.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceConnectionTokenAsync(DeleteServiceConnectionTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceConnectionTokenRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceConnectionToken.Async(request, callSettings).ConfigureAwait(false), DeleteServiceConnectionTokenOperationsClient);
        }
    }

    public partial class ListServiceConnectionMapsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceConnectionPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceClassesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceConnectionTokensRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceConnectionMapsResponse : gaxgrpc::IPageResponse<ServiceConnectionMap>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceConnectionMap> GetEnumerator() => ServiceConnectionMaps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceConnectionPoliciesResponse : gaxgrpc::IPageResponse<ServiceConnectionPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceConnectionPolicy> GetEnumerator() => ServiceConnectionPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceClassesResponse : gaxgrpc::IPageResponse<ServiceClass>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceClass> GetEnumerator() => ServiceClasses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceConnectionTokensResponse : gaxgrpc::IPageResponse<ServiceConnectionToken>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceConnectionToken> GetEnumerator() => ServiceConnectionTokens.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CrossNetworkAutomationService
    {
        public partial class CrossNetworkAutomationServiceClient
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

    public static partial class CrossNetworkAutomationService
    {
        public partial class CrossNetworkAutomationServiceClient
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
