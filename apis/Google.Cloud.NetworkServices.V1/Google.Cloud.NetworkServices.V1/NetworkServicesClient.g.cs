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

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Settings for <see cref="NetworkServicesClient"/> instances.</summary>
    public sealed partial class NetworkServicesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetworkServicesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetworkServicesSettings"/>.</returns>
        public static NetworkServicesSettings GetDefault() => new NetworkServicesSettings();

        /// <summary>Constructs a new <see cref="NetworkServicesSettings"/> object with default settings.</summary>
        public NetworkServicesSettings()
        {
        }

        private NetworkServicesSettings(NetworkServicesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEndpointPoliciesSettings = existing.ListEndpointPoliciesSettings;
            GetEndpointPolicySettings = existing.GetEndpointPolicySettings;
            CreateEndpointPolicySettings = existing.CreateEndpointPolicySettings;
            CreateEndpointPolicyOperationsSettings = existing.CreateEndpointPolicyOperationsSettings.Clone();
            UpdateEndpointPolicySettings = existing.UpdateEndpointPolicySettings;
            UpdateEndpointPolicyOperationsSettings = existing.UpdateEndpointPolicyOperationsSettings.Clone();
            DeleteEndpointPolicySettings = existing.DeleteEndpointPolicySettings;
            DeleteEndpointPolicyOperationsSettings = existing.DeleteEndpointPolicyOperationsSettings.Clone();
            ListGatewaysSettings = existing.ListGatewaysSettings;
            GetGatewaySettings = existing.GetGatewaySettings;
            CreateGatewaySettings = existing.CreateGatewaySettings;
            CreateGatewayOperationsSettings = existing.CreateGatewayOperationsSettings.Clone();
            UpdateGatewaySettings = existing.UpdateGatewaySettings;
            UpdateGatewayOperationsSettings = existing.UpdateGatewayOperationsSettings.Clone();
            DeleteGatewaySettings = existing.DeleteGatewaySettings;
            DeleteGatewayOperationsSettings = existing.DeleteGatewayOperationsSettings.Clone();
            ListGrpcRoutesSettings = existing.ListGrpcRoutesSettings;
            GetGrpcRouteSettings = existing.GetGrpcRouteSettings;
            CreateGrpcRouteSettings = existing.CreateGrpcRouteSettings;
            CreateGrpcRouteOperationsSettings = existing.CreateGrpcRouteOperationsSettings.Clone();
            UpdateGrpcRouteSettings = existing.UpdateGrpcRouteSettings;
            UpdateGrpcRouteOperationsSettings = existing.UpdateGrpcRouteOperationsSettings.Clone();
            DeleteGrpcRouteSettings = existing.DeleteGrpcRouteSettings;
            DeleteGrpcRouteOperationsSettings = existing.DeleteGrpcRouteOperationsSettings.Clone();
            ListHttpRoutesSettings = existing.ListHttpRoutesSettings;
            GetHttpRouteSettings = existing.GetHttpRouteSettings;
            CreateHttpRouteSettings = existing.CreateHttpRouteSettings;
            CreateHttpRouteOperationsSettings = existing.CreateHttpRouteOperationsSettings.Clone();
            UpdateHttpRouteSettings = existing.UpdateHttpRouteSettings;
            UpdateHttpRouteOperationsSettings = existing.UpdateHttpRouteOperationsSettings.Clone();
            DeleteHttpRouteSettings = existing.DeleteHttpRouteSettings;
            DeleteHttpRouteOperationsSettings = existing.DeleteHttpRouteOperationsSettings.Clone();
            ListTcpRoutesSettings = existing.ListTcpRoutesSettings;
            GetTcpRouteSettings = existing.GetTcpRouteSettings;
            CreateTcpRouteSettings = existing.CreateTcpRouteSettings;
            CreateTcpRouteOperationsSettings = existing.CreateTcpRouteOperationsSettings.Clone();
            UpdateTcpRouteSettings = existing.UpdateTcpRouteSettings;
            UpdateTcpRouteOperationsSettings = existing.UpdateTcpRouteOperationsSettings.Clone();
            DeleteTcpRouteSettings = existing.DeleteTcpRouteSettings;
            DeleteTcpRouteOperationsSettings = existing.DeleteTcpRouteOperationsSettings.Clone();
            ListTlsRoutesSettings = existing.ListTlsRoutesSettings;
            GetTlsRouteSettings = existing.GetTlsRouteSettings;
            CreateTlsRouteSettings = existing.CreateTlsRouteSettings;
            CreateTlsRouteOperationsSettings = existing.CreateTlsRouteOperationsSettings.Clone();
            UpdateTlsRouteSettings = existing.UpdateTlsRouteSettings;
            UpdateTlsRouteOperationsSettings = existing.UpdateTlsRouteOperationsSettings.Clone();
            DeleteTlsRouteSettings = existing.DeleteTlsRouteSettings;
            DeleteTlsRouteOperationsSettings = existing.DeleteTlsRouteOperationsSettings.Clone();
            ListServiceBindingsSettings = existing.ListServiceBindingsSettings;
            GetServiceBindingSettings = existing.GetServiceBindingSettings;
            CreateServiceBindingSettings = existing.CreateServiceBindingSettings;
            CreateServiceBindingOperationsSettings = existing.CreateServiceBindingOperationsSettings.Clone();
            UpdateServiceBindingSettings = existing.UpdateServiceBindingSettings;
            UpdateServiceBindingOperationsSettings = existing.UpdateServiceBindingOperationsSettings.Clone();
            DeleteServiceBindingSettings = existing.DeleteServiceBindingSettings;
            DeleteServiceBindingOperationsSettings = existing.DeleteServiceBindingOperationsSettings.Clone();
            ListMeshesSettings = existing.ListMeshesSettings;
            GetMeshSettings = existing.GetMeshSettings;
            CreateMeshSettings = existing.CreateMeshSettings;
            CreateMeshOperationsSettings = existing.CreateMeshOperationsSettings.Clone();
            UpdateMeshSettings = existing.UpdateMeshSettings;
            UpdateMeshOperationsSettings = existing.UpdateMeshOperationsSettings.Clone();
            DeleteMeshSettings = existing.DeleteMeshSettings;
            DeleteMeshOperationsSettings = existing.DeleteMeshOperationsSettings.Clone();
            ListServiceLbPoliciesSettings = existing.ListServiceLbPoliciesSettings;
            GetServiceLbPolicySettings = existing.GetServiceLbPolicySettings;
            CreateServiceLbPolicySettings = existing.CreateServiceLbPolicySettings;
            CreateServiceLbPolicyOperationsSettings = existing.CreateServiceLbPolicyOperationsSettings.Clone();
            UpdateServiceLbPolicySettings = existing.UpdateServiceLbPolicySettings;
            UpdateServiceLbPolicyOperationsSettings = existing.UpdateServiceLbPolicyOperationsSettings.Clone();
            DeleteServiceLbPolicySettings = existing.DeleteServiceLbPolicySettings;
            DeleteServiceLbPolicyOperationsSettings = existing.DeleteServiceLbPolicyOperationsSettings.Clone();
            GetGatewayRouteViewSettings = existing.GetGatewayRouteViewSettings;
            GetMeshRouteViewSettings = existing.GetMeshRouteViewSettings;
            ListGatewayRouteViewsSettings = existing.ListGatewayRouteViewsSettings;
            ListMeshRouteViewsSettings = existing.ListMeshRouteViewsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetworkServicesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListEndpointPolicies</c> and <c>NetworkServicesClient.ListEndpointPoliciesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEndpointPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetEndpointPolicy</c> and <c>NetworkServicesClient.GetEndpointPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateEndpointPolicy</c> and <c>NetworkServicesClient.CreateEndpointPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateEndpointPolicy</c> and
        /// <c>NetworkServicesClient.CreateEndpointPolicyAsync</c>.
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
        public lro::OperationsSettings CreateEndpointPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateEndpointPolicy</c> and <c>NetworkServicesClient.UpdateEndpointPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateEndpointPolicy</c> and
        /// <c>NetworkServicesClient.UpdateEndpointPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateEndpointPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteEndpointPolicy</c> and <c>NetworkServicesClient.DeleteEndpointPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteEndpointPolicy</c> and
        /// <c>NetworkServicesClient.DeleteEndpointPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteEndpointPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListGateways</c> and <c>NetworkServicesClient.ListGatewaysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGatewaysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetGateway</c> and <c>NetworkServicesClient.GetGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateGateway</c> and <c>NetworkServicesClient.CreateGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateGateway</c> and
        /// <c>NetworkServicesClient.CreateGatewayAsync</c>.
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
        public lro::OperationsSettings CreateGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateGateway</c> and <c>NetworkServicesClient.UpdateGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateGateway</c> and
        /// <c>NetworkServicesClient.UpdateGatewayAsync</c>.
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
        public lro::OperationsSettings UpdateGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteGateway</c> and <c>NetworkServicesClient.DeleteGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteGateway</c> and
        /// <c>NetworkServicesClient.DeleteGatewayAsync</c>.
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
        public lro::OperationsSettings DeleteGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListGrpcRoutes</c> and <c>NetworkServicesClient.ListGrpcRoutesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGrpcRoutesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetGrpcRoute</c> and <c>NetworkServicesClient.GetGrpcRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGrpcRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateGrpcRoute</c> and <c>NetworkServicesClient.CreateGrpcRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGrpcRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateGrpcRoute</c> and
        /// <c>NetworkServicesClient.CreateGrpcRouteAsync</c>.
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
        public lro::OperationsSettings CreateGrpcRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateGrpcRoute</c> and <c>NetworkServicesClient.UpdateGrpcRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGrpcRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateGrpcRoute</c> and
        /// <c>NetworkServicesClient.UpdateGrpcRouteAsync</c>.
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
        public lro::OperationsSettings UpdateGrpcRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteGrpcRoute</c> and <c>NetworkServicesClient.DeleteGrpcRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGrpcRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteGrpcRoute</c> and
        /// <c>NetworkServicesClient.DeleteGrpcRouteAsync</c>.
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
        public lro::OperationsSettings DeleteGrpcRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListHttpRoutes</c> and <c>NetworkServicesClient.ListHttpRoutesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHttpRoutesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetHttpRoute</c> and <c>NetworkServicesClient.GetHttpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHttpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateHttpRoute</c> and <c>NetworkServicesClient.CreateHttpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHttpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateHttpRoute</c> and
        /// <c>NetworkServicesClient.CreateHttpRouteAsync</c>.
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
        public lro::OperationsSettings CreateHttpRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateHttpRoute</c> and <c>NetworkServicesClient.UpdateHttpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateHttpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateHttpRoute</c> and
        /// <c>NetworkServicesClient.UpdateHttpRouteAsync</c>.
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
        public lro::OperationsSettings UpdateHttpRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteHttpRoute</c> and <c>NetworkServicesClient.DeleteHttpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteHttpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteHttpRoute</c> and
        /// <c>NetworkServicesClient.DeleteHttpRouteAsync</c>.
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
        public lro::OperationsSettings DeleteHttpRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListTcpRoutes</c> and <c>NetworkServicesClient.ListTcpRoutesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTcpRoutesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetTcpRoute</c> and <c>NetworkServicesClient.GetTcpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTcpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateTcpRoute</c> and <c>NetworkServicesClient.CreateTcpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTcpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateTcpRoute</c> and
        /// <c>NetworkServicesClient.CreateTcpRouteAsync</c>.
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
        public lro::OperationsSettings CreateTcpRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateTcpRoute</c> and <c>NetworkServicesClient.UpdateTcpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTcpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateTcpRoute</c> and
        /// <c>NetworkServicesClient.UpdateTcpRouteAsync</c>.
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
        public lro::OperationsSettings UpdateTcpRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteTcpRoute</c> and <c>NetworkServicesClient.DeleteTcpRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTcpRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteTcpRoute</c> and
        /// <c>NetworkServicesClient.DeleteTcpRouteAsync</c>.
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
        public lro::OperationsSettings DeleteTcpRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListTlsRoutes</c> and <c>NetworkServicesClient.ListTlsRoutesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTlsRoutesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetTlsRoute</c> and <c>NetworkServicesClient.GetTlsRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTlsRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateTlsRoute</c> and <c>NetworkServicesClient.CreateTlsRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTlsRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateTlsRoute</c> and
        /// <c>NetworkServicesClient.CreateTlsRouteAsync</c>.
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
        public lro::OperationsSettings CreateTlsRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateTlsRoute</c> and <c>NetworkServicesClient.UpdateTlsRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTlsRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateTlsRoute</c> and
        /// <c>NetworkServicesClient.UpdateTlsRouteAsync</c>.
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
        public lro::OperationsSettings UpdateTlsRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteTlsRoute</c> and <c>NetworkServicesClient.DeleteTlsRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTlsRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteTlsRoute</c> and
        /// <c>NetworkServicesClient.DeleteTlsRouteAsync</c>.
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
        public lro::OperationsSettings DeleteTlsRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListServiceBindings</c> and <c>NetworkServicesClient.ListServiceBindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceBindingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetServiceBinding</c> and <c>NetworkServicesClient.GetServiceBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateServiceBinding</c> and <c>NetworkServicesClient.CreateServiceBindingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateServiceBinding</c> and
        /// <c>NetworkServicesClient.CreateServiceBindingAsync</c>.
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
        public lro::OperationsSettings CreateServiceBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateServiceBinding</c> and <c>NetworkServicesClient.UpdateServiceBindingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateServiceBinding</c> and
        /// <c>NetworkServicesClient.UpdateServiceBindingAsync</c>.
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
        public lro::OperationsSettings UpdateServiceBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteServiceBinding</c> and <c>NetworkServicesClient.DeleteServiceBindingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteServiceBinding</c> and
        /// <c>NetworkServicesClient.DeleteServiceBindingAsync</c>.
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
        public lro::OperationsSettings DeleteServiceBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListMeshes</c> and <c>NetworkServicesClient.ListMeshesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMeshesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetMesh</c> and <c>NetworkServicesClient.GetMeshAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMeshSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateMesh</c> and <c>NetworkServicesClient.CreateMeshAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMeshSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateMesh</c> and
        /// <c>NetworkServicesClient.CreateMeshAsync</c>.
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
        public lro::OperationsSettings CreateMeshOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateMesh</c> and <c>NetworkServicesClient.UpdateMeshAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMeshSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateMesh</c> and
        /// <c>NetworkServicesClient.UpdateMeshAsync</c>.
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
        public lro::OperationsSettings UpdateMeshOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteMesh</c> and <c>NetworkServicesClient.DeleteMeshAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMeshSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteMesh</c> and
        /// <c>NetworkServicesClient.DeleteMeshAsync</c>.
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
        public lro::OperationsSettings DeleteMeshOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListServiceLbPolicies</c> and <c>NetworkServicesClient.ListServiceLbPoliciesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceLbPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetServiceLbPolicy</c> and <c>NetworkServicesClient.GetServiceLbPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceLbPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateServiceLbPolicy</c> and <c>NetworkServicesClient.CreateServiceLbPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceLbPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateServiceLbPolicy</c> and
        /// <c>NetworkServicesClient.CreateServiceLbPolicyAsync</c>.
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
        public lro::OperationsSettings CreateServiceLbPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateServiceLbPolicy</c> and <c>NetworkServicesClient.UpdateServiceLbPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceLbPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateServiceLbPolicy</c> and
        /// <c>NetworkServicesClient.UpdateServiceLbPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateServiceLbPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteServiceLbPolicy</c> and <c>NetworkServicesClient.DeleteServiceLbPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceLbPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteServiceLbPolicy</c> and
        /// <c>NetworkServicesClient.DeleteServiceLbPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteServiceLbPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetGatewayRouteView</c> and <c>NetworkServicesClient.GetGatewayRouteViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGatewayRouteViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetMeshRouteView</c> and <c>NetworkServicesClient.GetMeshRouteViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMeshRouteViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListGatewayRouteViews</c> and <c>NetworkServicesClient.ListGatewayRouteViewsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGatewayRouteViewsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListMeshRouteViews</c> and <c>NetworkServicesClient.ListMeshRouteViewsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMeshRouteViewsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetworkServicesSettings"/> object.</returns>
        public NetworkServicesSettings Clone() => new NetworkServicesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetworkServicesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NetworkServicesClientBuilder : gaxgrpc::ClientBuilderBase<NetworkServicesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetworkServicesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetworkServicesClientBuilder() : base(NetworkServicesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetworkServicesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetworkServicesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetworkServicesClient Build()
        {
            NetworkServicesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetworkServicesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetworkServicesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetworkServicesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetworkServicesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetworkServicesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetworkServicesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetworkServicesClient.ChannelPool;
    }

    /// <summary>NetworkServices client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public abstract partial class NetworkServicesClient
    {
        /// <summary>
        /// The default endpoint for the NetworkServices service, which is a host of "networkservices.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkservices.googleapis.com:443";

        /// <summary>The default NetworkServices scopes.</summary>
        /// <remarks>
        /// The default NetworkServices scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkServices.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetworkServicesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkServicesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetworkServicesClient"/>.</returns>
        public static stt::Task<NetworkServicesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetworkServicesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetworkServicesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkServicesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetworkServicesClient"/>.</returns>
        public static NetworkServicesClient Create() => new NetworkServicesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetworkServicesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetworkServicesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetworkServicesClient"/>.</returns>
        internal static NetworkServicesClient Create(grpccore::CallInvoker callInvoker, NetworkServicesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetworkServices.NetworkServicesClient grpcClient = new NetworkServices.NetworkServicesClient(callInvoker);
            return new NetworkServicesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetworkServices client</summary>
        public virtual NetworkServices.NetworkServicesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EndpointPolicy GetEndpointPolicy(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(GetEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EndpointPolicy GetEndpointPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicy(new GetEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicyAsync(new GetEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EndpointPolicy GetEndpointPolicy(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicy(new GetEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicyAsync(new GetEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(EndpointPolicyName name, st::CancellationToken cancellationToken) =>
            GetEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(CreateEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEndpointPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateEndpointPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEndpointPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> PollOnceCreateEndpointPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEndpointPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> PollOnceCreateEndpointPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(string parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicy(new CreateEndpointPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(string parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicyAsync(new CreateEndpointPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(string parent, EndpointPolicy endpointPolicy, string endpointPolicyId, st::CancellationToken cancellationToken) =>
            CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(gagr::LocationName parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicy(new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(gagr::LocationName parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicyAsync(new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(gagr::LocationName parent, EndpointPolicy endpointPolicy, string endpointPolicyId, st::CancellationToken cancellationToken) =>
            CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> UpdateEndpointPolicy(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEndpointPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateEndpointPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEndpointPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> PollOnceUpdateEndpointPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEndpointPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> PollOnceUpdateEndpointPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="endpointPolicy">
        /// Required. Updated EndpointPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EndpointPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> UpdateEndpointPolicy(EndpointPolicy endpointPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointPolicy(new UpdateEndpointPolicyRequest
            {
                UpdateMask = updateMask,
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="endpointPolicy">
        /// Required. Updated EndpointPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EndpointPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(EndpointPolicy endpointPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointPolicyAsync(new UpdateEndpointPolicyRequest
            {
                UpdateMask = updateMask,
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="endpointPolicy">
        /// Required. Updated EndpointPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EndpointPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(EndpointPolicy endpointPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEndpointPolicyAsync(endpointPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEndpointPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteEndpointPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEndpointPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEndpointPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEndpointPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEndpointPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicy(new DeleteEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicyAsync(new DeleteEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicy(new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicyAsync(new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(EndpointPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Gateways should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGateways(request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Gateways should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Gateways should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGateways(request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Gateways should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Gateway GetGateway(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GetGatewayRequest request, st::CancellationToken cancellationToken) =>
            GetGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to get. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Gateway GetGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGateway(new GetGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to get. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayAsync(new GetGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to get. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            GetGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to get. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Gateway GetGateway(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGateway(new GetGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to get. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayAsync(new GetGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to get. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GatewayName name, st::CancellationToken cancellationToken) =>
            GetGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> CreateGateway(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(CreateGatewayRequest request, st::CancellationToken cancellationToken) =>
            CreateGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGateway</c>.</summary>
        public virtual lro::OperationsClient CreateGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> PollOnceCreateGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> PollOnceCreateGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Gateway. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource to be created.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Short name of the Gateway resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> CreateGateway(string parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGateway(new CreateGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Gateway. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource to be created.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Short name of the Gateway resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(string parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewayAsync(new CreateGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Gateway. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource to be created.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Short name of the Gateway resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(string parent, Gateway gateway, string gatewayId, st::CancellationToken cancellationToken) =>
            CreateGatewayAsync(parent, gateway, gatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Gateway. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource to be created.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Short name of the Gateway resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> CreateGateway(gagr::LocationName parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGateway(new CreateGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Gateway. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource to be created.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Short name of the Gateway resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(gagr::LocationName parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewayAsync(new CreateGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Gateway. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource to be created.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Short name of the Gateway resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(gagr::LocationName parent, Gateway gateway, string gatewayId, st::CancellationToken cancellationToken) =>
            CreateGatewayAsync(parent, gateway, gatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> UpdateGateway(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(UpdateGatewayRequest request, st::CancellationToken cancellationToken) =>
            UpdateGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGateway</c>.</summary>
        public virtual lro::OperationsClient UpdateGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> PollOnceUpdateGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> PollOnceUpdateGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="gateway">
        /// Required. Updated Gateway resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Gateway resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> UpdateGateway(Gateway gateway, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGateway(new UpdateGatewayRequest
            {
                UpdateMask = updateMask,
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="gateway">
        /// Required. Updated Gateway resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Gateway resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(Gateway gateway, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGatewayAsync(new UpdateGatewayRequest
            {
                UpdateMask = updateMask,
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="gateway">
        /// Required. Updated Gateway resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Gateway resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(Gateway gateway, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGatewayAsync(gateway, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(DeleteGatewayRequest request, st::CancellationToken cancellationToken) =>
            DeleteGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGateway</c>.</summary>
        public virtual lro::OperationsClient DeleteGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewayOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to delete. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGateway(new DeleteGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to delete. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewayAsync(new DeleteGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to delete. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to delete. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGateway(new DeleteGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to delete. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewayAsync(new DeleteGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Gateway to delete. Must be in the format
        /// `projects/*/locations/*/gateways/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(GatewayName name, st::CancellationToken cancellationToken) =>
            DeleteGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GrpcRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutes(ListGrpcRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GrpcRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutesAsync(ListGrpcRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GrpcRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="GrpcRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrpcRoutesRequest request = new ListGrpcRoutesRequest
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
            return ListGrpcRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GrpcRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GrpcRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrpcRoutesRequest request = new ListGrpcRoutesRequest
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
            return ListGrpcRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GrpcRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="GrpcRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrpcRoutesRequest request = new ListGrpcRoutesRequest
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
            return ListGrpcRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GrpcRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GrpcRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrpcRoutesRequest request = new ListGrpcRoutesRequest
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
            return ListGrpcRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GrpcRoute GetGrpcRoute(GetGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GrpcRoute> GetGrpcRouteAsync(GetGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GrpcRoute> GetGrpcRouteAsync(GetGrpcRouteRequest request, st::CancellationToken cancellationToken) =>
            GetGrpcRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to get. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GrpcRoute GetGrpcRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrpcRoute(new GetGrpcRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to get. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GrpcRoute> GetGrpcRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrpcRouteAsync(new GetGrpcRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to get. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GrpcRoute> GetGrpcRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetGrpcRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to get. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GrpcRoute GetGrpcRoute(GrpcRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrpcRoute(new GetGrpcRouteRequest
            {
                GrpcRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to get. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GrpcRoute> GetGrpcRouteAsync(GrpcRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrpcRouteAsync(new GetGrpcRouteRequest
            {
                GrpcRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to get. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GrpcRoute> GetGrpcRouteAsync(GrpcRouteName name, st::CancellationToken cancellationToken) =>
            GetGrpcRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> CreateGrpcRoute(CreateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(CreateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(CreateGrpcRouteRequest request, st::CancellationToken cancellationToken) =>
            CreateGrpcRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGrpcRoute</c>.</summary>
        public virtual lro::OperationsClient CreateGrpcRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGrpcRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> PollOnceCreateGrpcRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GrpcRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGrpcRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGrpcRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> PollOnceCreateGrpcRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GrpcRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGrpcRouteOperationsClient, callSettings);

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GrpcRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="grpcRoute">
        /// Required. GrpcRoute resource to be created.
        /// </param>
        /// <param name="grpcRouteId">
        /// Required. Short name of the GrpcRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> CreateGrpcRoute(string parent, GrpcRoute grpcRoute, string grpcRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrpcRoute(new CreateGrpcRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GrpcRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)),
                GrpcRoute = gax::GaxPreconditions.CheckNotNull(grpcRoute, nameof(grpcRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GrpcRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="grpcRoute">
        /// Required. GrpcRoute resource to be created.
        /// </param>
        /// <param name="grpcRouteId">
        /// Required. Short name of the GrpcRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(string parent, GrpcRoute grpcRoute, string grpcRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrpcRouteAsync(new CreateGrpcRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GrpcRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)),
                GrpcRoute = gax::GaxPreconditions.CheckNotNull(grpcRoute, nameof(grpcRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GrpcRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="grpcRoute">
        /// Required. GrpcRoute resource to be created.
        /// </param>
        /// <param name="grpcRouteId">
        /// Required. Short name of the GrpcRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(string parent, GrpcRoute grpcRoute, string grpcRouteId, st::CancellationToken cancellationToken) =>
            CreateGrpcRouteAsync(parent, grpcRoute, grpcRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GrpcRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="grpcRoute">
        /// Required. GrpcRoute resource to be created.
        /// </param>
        /// <param name="grpcRouteId">
        /// Required. Short name of the GrpcRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> CreateGrpcRoute(gagr::LocationName parent, GrpcRoute grpcRoute, string grpcRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrpcRoute(new CreateGrpcRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GrpcRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)),
                GrpcRoute = gax::GaxPreconditions.CheckNotNull(grpcRoute, nameof(grpcRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GrpcRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="grpcRoute">
        /// Required. GrpcRoute resource to be created.
        /// </param>
        /// <param name="grpcRouteId">
        /// Required. Short name of the GrpcRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(gagr::LocationName parent, GrpcRoute grpcRoute, string grpcRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrpcRouteAsync(new CreateGrpcRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GrpcRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)),
                GrpcRoute = gax::GaxPreconditions.CheckNotNull(grpcRoute, nameof(grpcRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GrpcRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="grpcRoute">
        /// Required. GrpcRoute resource to be created.
        /// </param>
        /// <param name="grpcRouteId">
        /// Required. Short name of the GrpcRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(gagr::LocationName parent, GrpcRoute grpcRoute, string grpcRouteId, st::CancellationToken cancellationToken) =>
            CreateGrpcRouteAsync(parent, grpcRoute, grpcRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> UpdateGrpcRoute(UpdateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> UpdateGrpcRouteAsync(UpdateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> UpdateGrpcRouteAsync(UpdateGrpcRouteRequest request, st::CancellationToken cancellationToken) =>
            UpdateGrpcRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGrpcRoute</c>.</summary>
        public virtual lro::OperationsClient UpdateGrpcRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGrpcRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> PollOnceUpdateGrpcRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GrpcRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGrpcRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGrpcRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> PollOnceUpdateGrpcRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GrpcRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGrpcRouteOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="grpcRoute">
        /// Required. Updated GrpcRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GrpcRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GrpcRoute, OperationMetadata> UpdateGrpcRoute(GrpcRoute grpcRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGrpcRoute(new UpdateGrpcRouteRequest
            {
                UpdateMask = updateMask,
                GrpcRoute = gax::GaxPreconditions.CheckNotNull(grpcRoute, nameof(grpcRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="grpcRoute">
        /// Required. Updated GrpcRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GrpcRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> UpdateGrpcRouteAsync(GrpcRoute grpcRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGrpcRouteAsync(new UpdateGrpcRouteRequest
            {
                UpdateMask = updateMask,
                GrpcRoute = gax::GaxPreconditions.CheckNotNull(grpcRoute, nameof(grpcRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="grpcRoute">
        /// Required. Updated GrpcRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GrpcRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> UpdateGrpcRouteAsync(GrpcRoute grpcRoute, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGrpcRouteAsync(grpcRoute, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGrpcRoute(DeleteGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(DeleteGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(DeleteGrpcRouteRequest request, st::CancellationToken cancellationToken) =>
            DeleteGrpcRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGrpcRoute</c>.</summary>
        public virtual lro::OperationsClient DeleteGrpcRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGrpcRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGrpcRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGrpcRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGrpcRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGrpcRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGrpcRouteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to delete. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGrpcRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGrpcRoute(new DeleteGrpcRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to delete. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGrpcRouteAsync(new DeleteGrpcRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to delete. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGrpcRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to delete. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGrpcRoute(GrpcRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGrpcRoute(new DeleteGrpcRouteRequest
            {
                GrpcRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to delete. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(GrpcRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGrpcRouteAsync(new DeleteGrpcRouteRequest
            {
                GrpcRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GrpcRoute to delete. Must be in the format
        /// `projects/*/locations/global/grpcRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(GrpcRouteName name, st::CancellationToken cancellationToken) =>
            DeleteGrpcRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HttpRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutes(ListHttpRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HttpRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutesAsync(ListHttpRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the HttpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="HttpRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHttpRoutesRequest request = new ListHttpRoutesRequest
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
            return ListHttpRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the HttpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HttpRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHttpRoutesRequest request = new ListHttpRoutesRequest
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
            return ListHttpRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the HttpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="HttpRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHttpRoutesRequest request = new ListHttpRoutesRequest
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
            return ListHttpRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the HttpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HttpRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHttpRoutesRequest request = new ListHttpRoutesRequest
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
            return ListHttpRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HttpRoute GetHttpRoute(GetHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HttpRoute> GetHttpRouteAsync(GetHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HttpRoute> GetHttpRouteAsync(GetHttpRouteRequest request, st::CancellationToken cancellationToken) =>
            GetHttpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to get. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HttpRoute GetHttpRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHttpRoute(new GetHttpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to get. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HttpRoute> GetHttpRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHttpRouteAsync(new GetHttpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to get. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HttpRoute> GetHttpRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetHttpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to get. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HttpRoute GetHttpRoute(HttpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHttpRoute(new GetHttpRouteRequest
            {
                HttpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to get. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HttpRoute> GetHttpRouteAsync(HttpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHttpRouteAsync(new GetHttpRouteRequest
            {
                HttpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to get. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HttpRoute> GetHttpRouteAsync(HttpRouteName name, st::CancellationToken cancellationToken) =>
            GetHttpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> CreateHttpRoute(CreateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(CreateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(CreateHttpRouteRequest request, st::CancellationToken cancellationToken) =>
            CreateHttpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHttpRoute</c>.</summary>
        public virtual lro::OperationsClient CreateHttpRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateHttpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> PollOnceCreateHttpRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HttpRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHttpRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHttpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> PollOnceCreateHttpRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HttpRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHttpRouteOperationsClient, callSettings);

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the HttpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="httpRoute">
        /// Required. HttpRoute resource to be created.
        /// </param>
        /// <param name="httpRouteId">
        /// Required. Short name of the HttpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> CreateHttpRoute(string parent, HttpRoute httpRoute, string httpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHttpRoute(new CreateHttpRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HttpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)),
                HttpRoute = gax::GaxPreconditions.CheckNotNull(httpRoute, nameof(httpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the HttpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="httpRoute">
        /// Required. HttpRoute resource to be created.
        /// </param>
        /// <param name="httpRouteId">
        /// Required. Short name of the HttpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(string parent, HttpRoute httpRoute, string httpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHttpRouteAsync(new CreateHttpRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HttpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)),
                HttpRoute = gax::GaxPreconditions.CheckNotNull(httpRoute, nameof(httpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the HttpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="httpRoute">
        /// Required. HttpRoute resource to be created.
        /// </param>
        /// <param name="httpRouteId">
        /// Required. Short name of the HttpRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(string parent, HttpRoute httpRoute, string httpRouteId, st::CancellationToken cancellationToken) =>
            CreateHttpRouteAsync(parent, httpRoute, httpRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the HttpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="httpRoute">
        /// Required. HttpRoute resource to be created.
        /// </param>
        /// <param name="httpRouteId">
        /// Required. Short name of the HttpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> CreateHttpRoute(gagr::LocationName parent, HttpRoute httpRoute, string httpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHttpRoute(new CreateHttpRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HttpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)),
                HttpRoute = gax::GaxPreconditions.CheckNotNull(httpRoute, nameof(httpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the HttpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="httpRoute">
        /// Required. HttpRoute resource to be created.
        /// </param>
        /// <param name="httpRouteId">
        /// Required. Short name of the HttpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(gagr::LocationName parent, HttpRoute httpRoute, string httpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHttpRouteAsync(new CreateHttpRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HttpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)),
                HttpRoute = gax::GaxPreconditions.CheckNotNull(httpRoute, nameof(httpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the HttpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="httpRoute">
        /// Required. HttpRoute resource to be created.
        /// </param>
        /// <param name="httpRouteId">
        /// Required. Short name of the HttpRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(gagr::LocationName parent, HttpRoute httpRoute, string httpRouteId, st::CancellationToken cancellationToken) =>
            CreateHttpRouteAsync(parent, httpRoute, httpRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> UpdateHttpRoute(UpdateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> UpdateHttpRouteAsync(UpdateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> UpdateHttpRouteAsync(UpdateHttpRouteRequest request, st::CancellationToken cancellationToken) =>
            UpdateHttpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateHttpRoute</c>.</summary>
        public virtual lro::OperationsClient UpdateHttpRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateHttpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> PollOnceUpdateHttpRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HttpRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHttpRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateHttpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> PollOnceUpdateHttpRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<HttpRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHttpRouteOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="httpRoute">
        /// Required. Updated HttpRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// HttpRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<HttpRoute, OperationMetadata> UpdateHttpRoute(HttpRoute httpRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHttpRoute(new UpdateHttpRouteRequest
            {
                UpdateMask = updateMask,
                HttpRoute = gax::GaxPreconditions.CheckNotNull(httpRoute, nameof(httpRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="httpRoute">
        /// Required. Updated HttpRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// HttpRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> UpdateHttpRouteAsync(HttpRoute httpRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHttpRouteAsync(new UpdateHttpRouteRequest
            {
                UpdateMask = updateMask,
                HttpRoute = gax::GaxPreconditions.CheckNotNull(httpRoute, nameof(httpRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="httpRoute">
        /// Required. Updated HttpRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// HttpRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<HttpRoute, OperationMetadata>> UpdateHttpRouteAsync(HttpRoute httpRoute, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHttpRouteAsync(httpRoute, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHttpRoute(DeleteHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(DeleteHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(DeleteHttpRouteRequest request, st::CancellationToken cancellationToken) =>
            DeleteHttpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHttpRoute</c>.</summary>
        public virtual lro::OperationsClient DeleteHttpRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteHttpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteHttpRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHttpRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHttpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteHttpRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHttpRouteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to delete. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHttpRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHttpRoute(new DeleteHttpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to delete. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHttpRouteAsync(new DeleteHttpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to delete. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHttpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to delete. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHttpRoute(HttpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHttpRoute(new DeleteHttpRouteRequest
            {
                HttpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to delete. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(HttpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHttpRouteAsync(new DeleteHttpRouteRequest
            {
                HttpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the HttpRoute to delete. Must be in the format
        /// `projects/*/locations/global/httpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(HttpRouteName name, st::CancellationToken cancellationToken) =>
            DeleteHttpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TcpRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutes(ListTcpRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TcpRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutesAsync(ListTcpRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TcpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="TcpRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTcpRoutesRequest request = new ListTcpRoutesRequest
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
            return ListTcpRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TcpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TcpRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTcpRoutesRequest request = new ListTcpRoutesRequest
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
            return ListTcpRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TcpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="TcpRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTcpRoutesRequest request = new ListTcpRoutesRequest
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
            return ListTcpRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TcpRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TcpRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTcpRoutesRequest request = new ListTcpRoutesRequest
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
            return ListTcpRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TcpRoute GetTcpRoute(GetTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpRoute> GetTcpRouteAsync(GetTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpRoute> GetTcpRouteAsync(GetTcpRouteRequest request, st::CancellationToken cancellationToken) =>
            GetTcpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to get. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TcpRoute GetTcpRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTcpRoute(new GetTcpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to get. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpRoute> GetTcpRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTcpRouteAsync(new GetTcpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to get. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpRoute> GetTcpRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetTcpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to get. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TcpRoute GetTcpRoute(TcpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTcpRoute(new GetTcpRouteRequest
            {
                TcpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to get. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpRoute> GetTcpRouteAsync(TcpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTcpRouteAsync(new GetTcpRouteRequest
            {
                TcpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to get. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TcpRoute> GetTcpRouteAsync(TcpRouteName name, st::CancellationToken cancellationToken) =>
            GetTcpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> CreateTcpRoute(CreateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(CreateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(CreateTcpRouteRequest request, st::CancellationToken cancellationToken) =>
            CreateTcpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTcpRoute</c>.</summary>
        public virtual lro::OperationsClient CreateTcpRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTcpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> PollOnceCreateTcpRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TcpRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTcpRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTcpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> PollOnceCreateTcpRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TcpRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTcpRouteOperationsClient, callSettings);

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TcpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tcpRoute">
        /// Required. TcpRoute resource to be created.
        /// </param>
        /// <param name="tcpRouteId">
        /// Required. Short name of the TcpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> CreateTcpRoute(string parent, TcpRoute tcpRoute, string tcpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTcpRoute(new CreateTcpRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TcpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tcpRouteId, nameof(tcpRouteId)),
                TcpRoute = gax::GaxPreconditions.CheckNotNull(tcpRoute, nameof(tcpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TcpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tcpRoute">
        /// Required. TcpRoute resource to be created.
        /// </param>
        /// <param name="tcpRouteId">
        /// Required. Short name of the TcpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(string parent, TcpRoute tcpRoute, string tcpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTcpRouteAsync(new CreateTcpRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TcpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tcpRouteId, nameof(tcpRouteId)),
                TcpRoute = gax::GaxPreconditions.CheckNotNull(tcpRoute, nameof(tcpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TcpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tcpRoute">
        /// Required. TcpRoute resource to be created.
        /// </param>
        /// <param name="tcpRouteId">
        /// Required. Short name of the TcpRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(string parent, TcpRoute tcpRoute, string tcpRouteId, st::CancellationToken cancellationToken) =>
            CreateTcpRouteAsync(parent, tcpRoute, tcpRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TcpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tcpRoute">
        /// Required. TcpRoute resource to be created.
        /// </param>
        /// <param name="tcpRouteId">
        /// Required. Short name of the TcpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> CreateTcpRoute(gagr::LocationName parent, TcpRoute tcpRoute, string tcpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTcpRoute(new CreateTcpRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TcpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tcpRouteId, nameof(tcpRouteId)),
                TcpRoute = gax::GaxPreconditions.CheckNotNull(tcpRoute, nameof(tcpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TcpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tcpRoute">
        /// Required. TcpRoute resource to be created.
        /// </param>
        /// <param name="tcpRouteId">
        /// Required. Short name of the TcpRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(gagr::LocationName parent, TcpRoute tcpRoute, string tcpRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTcpRouteAsync(new CreateTcpRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TcpRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tcpRouteId, nameof(tcpRouteId)),
                TcpRoute = gax::GaxPreconditions.CheckNotNull(tcpRoute, nameof(tcpRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TcpRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tcpRoute">
        /// Required. TcpRoute resource to be created.
        /// </param>
        /// <param name="tcpRouteId">
        /// Required. Short name of the TcpRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(gagr::LocationName parent, TcpRoute tcpRoute, string tcpRouteId, st::CancellationToken cancellationToken) =>
            CreateTcpRouteAsync(parent, tcpRoute, tcpRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> UpdateTcpRoute(UpdateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> UpdateTcpRouteAsync(UpdateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> UpdateTcpRouteAsync(UpdateTcpRouteRequest request, st::CancellationToken cancellationToken) =>
            UpdateTcpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTcpRoute</c>.</summary>
        public virtual lro::OperationsClient UpdateTcpRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTcpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> PollOnceUpdateTcpRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TcpRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTcpRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTcpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> PollOnceUpdateTcpRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TcpRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTcpRouteOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="tcpRoute">
        /// Required. Updated TcpRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TcpRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TcpRoute, OperationMetadata> UpdateTcpRoute(TcpRoute tcpRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTcpRoute(new UpdateTcpRouteRequest
            {
                UpdateMask = updateMask,
                TcpRoute = gax::GaxPreconditions.CheckNotNull(tcpRoute, nameof(tcpRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="tcpRoute">
        /// Required. Updated TcpRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TcpRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> UpdateTcpRouteAsync(TcpRoute tcpRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTcpRouteAsync(new UpdateTcpRouteRequest
            {
                UpdateMask = updateMask,
                TcpRoute = gax::GaxPreconditions.CheckNotNull(tcpRoute, nameof(tcpRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="tcpRoute">
        /// Required. Updated TcpRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TcpRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TcpRoute, OperationMetadata>> UpdateTcpRouteAsync(TcpRoute tcpRoute, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTcpRouteAsync(tcpRoute, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTcpRoute(DeleteTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(DeleteTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(DeleteTcpRouteRequest request, st::CancellationToken cancellationToken) =>
            DeleteTcpRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTcpRoute</c>.</summary>
        public virtual lro::OperationsClient DeleteTcpRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTcpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTcpRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTcpRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTcpRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTcpRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTcpRouteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to delete. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTcpRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTcpRoute(new DeleteTcpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to delete. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTcpRouteAsync(new DeleteTcpRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to delete. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTcpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to delete. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTcpRoute(TcpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTcpRoute(new DeleteTcpRouteRequest
            {
                TcpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to delete. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(TcpRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTcpRouteAsync(new DeleteTcpRouteRequest
            {
                TcpRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TcpRoute to delete. Must be in the format
        /// `projects/*/locations/global/tcpRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(TcpRouteName name, st::CancellationToken cancellationToken) =>
            DeleteTcpRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TlsRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutes(ListTlsRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TlsRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutesAsync(ListTlsRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="TlsRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsRoutesRequest request = new ListTlsRoutesRequest
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
            return ListTlsRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TlsRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsRoutesRequest request = new ListTlsRoutesRequest
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
            return ListTlsRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="TlsRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsRoutesRequest request = new ListTlsRoutesRequest
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
            return ListTlsRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsRoutes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TlsRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsRoutesRequest request = new ListTlsRoutesRequest
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
            return ListTlsRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TlsRoute GetTlsRoute(GetTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsRoute> GetTlsRouteAsync(GetTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsRoute> GetTlsRouteAsync(GetTlsRouteRequest request, st::CancellationToken cancellationToken) =>
            GetTlsRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to get. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TlsRoute GetTlsRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsRoute(new GetTlsRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to get. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsRoute> GetTlsRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsRouteAsync(new GetTlsRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to get. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsRoute> GetTlsRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetTlsRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to get. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TlsRoute GetTlsRoute(TlsRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsRoute(new GetTlsRouteRequest
            {
                TlsRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to get. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsRoute> GetTlsRouteAsync(TlsRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsRouteAsync(new GetTlsRouteRequest
            {
                TlsRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to get. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsRoute> GetTlsRouteAsync(TlsRouteName name, st::CancellationToken cancellationToken) =>
            GetTlsRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> CreateTlsRoute(CreateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(CreateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(CreateTlsRouteRequest request, st::CancellationToken cancellationToken) =>
            CreateTlsRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTlsRoute</c>.</summary>
        public virtual lro::OperationsClient CreateTlsRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTlsRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> PollOnceCreateTlsRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTlsRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTlsRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> PollOnceCreateTlsRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTlsRouteOperationsClient, callSettings);

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tlsRoute">
        /// Required. TlsRoute resource to be created.
        /// </param>
        /// <param name="tlsRouteId">
        /// Required. Short name of the TlsRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> CreateTlsRoute(string parent, TlsRoute tlsRoute, string tlsRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsRoute(new CreateTlsRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TlsRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)),
                TlsRoute = gax::GaxPreconditions.CheckNotNull(tlsRoute, nameof(tlsRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tlsRoute">
        /// Required. TlsRoute resource to be created.
        /// </param>
        /// <param name="tlsRouteId">
        /// Required. Short name of the TlsRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(string parent, TlsRoute tlsRoute, string tlsRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsRouteAsync(new CreateTlsRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TlsRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)),
                TlsRoute = gax::GaxPreconditions.CheckNotNull(tlsRoute, nameof(tlsRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tlsRoute">
        /// Required. TlsRoute resource to be created.
        /// </param>
        /// <param name="tlsRouteId">
        /// Required. Short name of the TlsRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(string parent, TlsRoute tlsRoute, string tlsRouteId, st::CancellationToken cancellationToken) =>
            CreateTlsRouteAsync(parent, tlsRoute, tlsRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tlsRoute">
        /// Required. TlsRoute resource to be created.
        /// </param>
        /// <param name="tlsRouteId">
        /// Required. Short name of the TlsRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> CreateTlsRoute(gagr::LocationName parent, TlsRoute tlsRoute, string tlsRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsRoute(new CreateTlsRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TlsRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)),
                TlsRoute = gax::GaxPreconditions.CheckNotNull(tlsRoute, nameof(tlsRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tlsRoute">
        /// Required. TlsRoute resource to be created.
        /// </param>
        /// <param name="tlsRouteId">
        /// Required. Short name of the TlsRoute resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(gagr::LocationName parent, TlsRoute tlsRoute, string tlsRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsRouteAsync(new CreateTlsRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TlsRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)),
                TlsRoute = gax::GaxPreconditions.CheckNotNull(tlsRoute, nameof(tlsRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsRoute. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="tlsRoute">
        /// Required. TlsRoute resource to be created.
        /// </param>
        /// <param name="tlsRouteId">
        /// Required. Short name of the TlsRoute resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(gagr::LocationName parent, TlsRoute tlsRoute, string tlsRouteId, st::CancellationToken cancellationToken) =>
            CreateTlsRouteAsync(parent, tlsRoute, tlsRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> UpdateTlsRoute(UpdateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> UpdateTlsRouteAsync(UpdateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> UpdateTlsRouteAsync(UpdateTlsRouteRequest request, st::CancellationToken cancellationToken) =>
            UpdateTlsRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTlsRoute</c>.</summary>
        public virtual lro::OperationsClient UpdateTlsRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTlsRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> PollOnceUpdateTlsRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTlsRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTlsRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> PollOnceUpdateTlsRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTlsRouteOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="tlsRoute">
        /// Required. Updated TlsRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TlsRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsRoute, OperationMetadata> UpdateTlsRoute(TlsRoute tlsRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTlsRoute(new UpdateTlsRouteRequest
            {
                UpdateMask = updateMask,
                TlsRoute = gax::GaxPreconditions.CheckNotNull(tlsRoute, nameof(tlsRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="tlsRoute">
        /// Required. Updated TlsRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TlsRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> UpdateTlsRouteAsync(TlsRoute tlsRoute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTlsRouteAsync(new UpdateTlsRouteRequest
            {
                UpdateMask = updateMask,
                TlsRoute = gax::GaxPreconditions.CheckNotNull(tlsRoute, nameof(tlsRoute)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="tlsRoute">
        /// Required. Updated TlsRoute resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TlsRoute resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsRoute, OperationMetadata>> UpdateTlsRouteAsync(TlsRoute tlsRoute, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTlsRouteAsync(tlsRoute, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsRoute(DeleteTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(DeleteTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(DeleteTlsRouteRequest request, st::CancellationToken cancellationToken) =>
            DeleteTlsRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTlsRoute</c>.</summary>
        public virtual lro::OperationsClient DeleteTlsRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTlsRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTlsRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTlsRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTlsRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTlsRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTlsRouteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to delete. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsRoute(new DeleteTlsRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to delete. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsRouteAsync(new DeleteTlsRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to delete. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTlsRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to delete. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsRoute(TlsRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsRoute(new DeleteTlsRouteRequest
            {
                TlsRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to delete. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(TlsRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsRouteAsync(new DeleteTlsRouteRequest
            {
                TlsRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsRoute to delete. Must be in the format
        /// `projects/*/locations/global/tlsRoutes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(TlsRouteName name, st::CancellationToken cancellationToken) =>
            DeleteTlsRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindings(ListServiceBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindingsAsync(ListServiceBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceBindings should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="ServiceBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceBindingsRequest request = new ListServiceBindingsRequest
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
            return ListServiceBindings(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceBindings should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceBindingsRequest request = new ListServiceBindingsRequest
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
            return ListServiceBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceBindings should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="ServiceBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceBindingsRequest request = new ListServiceBindingsRequest
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
            return ListServiceBindings(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceBindings should be
        /// listed, specified in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceBindingsRequest request = new ListServiceBindingsRequest
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
            return ListServiceBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceBinding GetServiceBinding(GetServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceBinding> GetServiceBindingAsync(GetServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceBinding> GetServiceBindingAsync(GetServiceBindingRequest request, st::CancellationToken cancellationToken) =>
            GetServiceBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to get. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceBinding GetServiceBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceBinding(new GetServiceBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to get. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceBinding> GetServiceBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceBindingAsync(new GetServiceBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to get. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceBinding> GetServiceBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to get. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceBinding GetServiceBinding(ServiceBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceBinding(new GetServiceBindingRequest
            {
                ServiceBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to get. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceBinding> GetServiceBindingAsync(ServiceBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceBindingAsync(new GetServiceBindingRequest
            {
                ServiceBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to get. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceBinding> GetServiceBindingAsync(ServiceBindingName name, st::CancellationToken cancellationToken) =>
            GetServiceBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> CreateServiceBinding(CreateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(CreateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(CreateServiceBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceBinding</c>.</summary>
        public virtual lro::OperationsClient CreateServiceBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateServiceBinding</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> PollOnceCreateServiceBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> PollOnceCreateServiceBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceBinding. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="serviceBinding">
        /// Required. ServiceBinding resource to be created.
        /// </param>
        /// <param name="serviceBindingId">
        /// Required. Short name of the ServiceBinding resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> CreateServiceBinding(string parent, ServiceBinding serviceBinding, string serviceBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceBinding(new CreateServiceBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceBindingId, nameof(serviceBindingId)),
                ServiceBinding = gax::GaxPreconditions.CheckNotNull(serviceBinding, nameof(serviceBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceBinding. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="serviceBinding">
        /// Required. ServiceBinding resource to be created.
        /// </param>
        /// <param name="serviceBindingId">
        /// Required. Short name of the ServiceBinding resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(string parent, ServiceBinding serviceBinding, string serviceBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceBindingAsync(new CreateServiceBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceBindingId, nameof(serviceBindingId)),
                ServiceBinding = gax::GaxPreconditions.CheckNotNull(serviceBinding, nameof(serviceBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceBinding. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="serviceBinding">
        /// Required. ServiceBinding resource to be created.
        /// </param>
        /// <param name="serviceBindingId">
        /// Required. Short name of the ServiceBinding resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(string parent, ServiceBinding serviceBinding, string serviceBindingId, st::CancellationToken cancellationToken) =>
            CreateServiceBindingAsync(parent, serviceBinding, serviceBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceBinding. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="serviceBinding">
        /// Required. ServiceBinding resource to be created.
        /// </param>
        /// <param name="serviceBindingId">
        /// Required. Short name of the ServiceBinding resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> CreateServiceBinding(gagr::LocationName parent, ServiceBinding serviceBinding, string serviceBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceBinding(new CreateServiceBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceBindingId, nameof(serviceBindingId)),
                ServiceBinding = gax::GaxPreconditions.CheckNotNull(serviceBinding, nameof(serviceBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceBinding. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="serviceBinding">
        /// Required. ServiceBinding resource to be created.
        /// </param>
        /// <param name="serviceBindingId">
        /// Required. Short name of the ServiceBinding resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(gagr::LocationName parent, ServiceBinding serviceBinding, string serviceBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceBindingAsync(new CreateServiceBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceBindingId, nameof(serviceBindingId)),
                ServiceBinding = gax::GaxPreconditions.CheckNotNull(serviceBinding, nameof(serviceBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceBinding. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="serviceBinding">
        /// Required. ServiceBinding resource to be created.
        /// </param>
        /// <param name="serviceBindingId">
        /// Required. Short name of the ServiceBinding resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(gagr::LocationName parent, ServiceBinding serviceBinding, string serviceBindingId, st::CancellationToken cancellationToken) =>
            CreateServiceBindingAsync(parent, serviceBinding, serviceBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> UpdateServiceBinding(UpdateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> UpdateServiceBindingAsync(UpdateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> UpdateServiceBindingAsync(UpdateServiceBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServiceBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateServiceBinding</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> PollOnceUpdateServiceBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> PollOnceUpdateServiceBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="serviceBinding">
        /// Required. Updated ServiceBinding resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceBinding resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceBinding, OperationMetadata> UpdateServiceBinding(ServiceBinding serviceBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceBinding(new UpdateServiceBindingRequest
            {
                UpdateMask = updateMask,
                ServiceBinding = gax::GaxPreconditions.CheckNotNull(serviceBinding, nameof(serviceBinding)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="serviceBinding">
        /// Required. Updated ServiceBinding resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceBinding resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> UpdateServiceBindingAsync(ServiceBinding serviceBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceBindingAsync(new UpdateServiceBindingRequest
            {
                UpdateMask = updateMask,
                ServiceBinding = gax::GaxPreconditions.CheckNotNull(serviceBinding, nameof(serviceBinding)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="serviceBinding">
        /// Required. Updated ServiceBinding resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceBinding resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> UpdateServiceBindingAsync(ServiceBinding serviceBinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceBindingAsync(serviceBinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceBinding(DeleteServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(DeleteServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(DeleteServiceBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteServiceBinding</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to delete. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceBinding(new DeleteServiceBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to delete. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceBindingAsync(new DeleteServiceBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to delete. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to delete. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceBinding(ServiceBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceBinding(new DeleteServiceBindingRequest
            {
                ServiceBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to delete. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(ServiceBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceBindingAsync(new DeleteServiceBindingRequest
            {
                ServiceBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceBinding to delete. Must be in the format
        /// `projects/*/locations/*/serviceBindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(ServiceBindingName name, st::CancellationToken cancellationToken) =>
            DeleteServiceBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Mesh"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeshesResponse, Mesh> ListMeshes(ListMeshesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Mesh"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeshesResponse, Mesh> ListMeshesAsync(ListMeshesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Meshes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="Mesh"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeshesResponse, Mesh> ListMeshes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshesRequest request = new ListMeshesRequest
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
            return ListMeshes(request, callSettings);
        }

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Meshes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Mesh"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeshesResponse, Mesh> ListMeshesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshesRequest request = new ListMeshesRequest
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
            return ListMeshesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Meshes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="Mesh"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeshesResponse, Mesh> ListMeshes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshesRequest request = new ListMeshesRequest
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
            return ListMeshes(request, callSettings);
        }

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the Meshes should be
        /// listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Mesh"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeshesResponse, Mesh> ListMeshesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshesRequest request = new ListMeshesRequest
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
            return ListMeshesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Mesh GetMesh(GetMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Mesh> GetMeshAsync(GetMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Mesh> GetMeshAsync(GetMeshRequest request, st::CancellationToken cancellationToken) =>
            GetMeshAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to get. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Mesh GetMesh(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMesh(new GetMeshRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to get. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Mesh> GetMeshAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeshAsync(new GetMeshRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to get. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Mesh> GetMeshAsync(string name, st::CancellationToken cancellationToken) =>
            GetMeshAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to get. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Mesh GetMesh(MeshName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMesh(new GetMeshRequest
            {
                MeshName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to get. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Mesh> GetMeshAsync(MeshName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeshAsync(new GetMeshRequest
            {
                MeshName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to get. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Mesh> GetMeshAsync(MeshName name, st::CancellationToken cancellationToken) =>
            GetMeshAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> CreateMesh(CreateMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(CreateMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(CreateMeshRequest request, st::CancellationToken cancellationToken) =>
            CreateMeshAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMesh</c>.</summary>
        public virtual lro::OperationsClient CreateMeshOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMesh</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> PollOnceCreateMesh(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Mesh, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMeshOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMesh</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> PollOnceCreateMeshAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Mesh, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMeshOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Mesh. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="mesh">
        /// Required. Mesh resource to be created.
        /// </param>
        /// <param name="meshId">
        /// Required. Short name of the Mesh resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> CreateMesh(string parent, Mesh mesh, string meshId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMesh(new CreateMeshRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MeshId = gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)),
                Mesh = gax::GaxPreconditions.CheckNotNull(mesh, nameof(mesh)),
            }, callSettings);

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Mesh. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="mesh">
        /// Required. Mesh resource to be created.
        /// </param>
        /// <param name="meshId">
        /// Required. Short name of the Mesh resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(string parent, Mesh mesh, string meshId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMeshAsync(new CreateMeshRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MeshId = gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)),
                Mesh = gax::GaxPreconditions.CheckNotNull(mesh, nameof(mesh)),
            }, callSettings);

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Mesh. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="mesh">
        /// Required. Mesh resource to be created.
        /// </param>
        /// <param name="meshId">
        /// Required. Short name of the Mesh resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(string parent, Mesh mesh, string meshId, st::CancellationToken cancellationToken) =>
            CreateMeshAsync(parent, mesh, meshId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Mesh. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="mesh">
        /// Required. Mesh resource to be created.
        /// </param>
        /// <param name="meshId">
        /// Required. Short name of the Mesh resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> CreateMesh(gagr::LocationName parent, Mesh mesh, string meshId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMesh(new CreateMeshRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MeshId = gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)),
                Mesh = gax::GaxPreconditions.CheckNotNull(mesh, nameof(mesh)),
            }, callSettings);

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Mesh. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="mesh">
        /// Required. Mesh resource to be created.
        /// </param>
        /// <param name="meshId">
        /// Required. Short name of the Mesh resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(gagr::LocationName parent, Mesh mesh, string meshId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMeshAsync(new CreateMeshRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MeshId = gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)),
                Mesh = gax::GaxPreconditions.CheckNotNull(mesh, nameof(mesh)),
            }, callSettings);

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Mesh. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="mesh">
        /// Required. Mesh resource to be created.
        /// </param>
        /// <param name="meshId">
        /// Required. Short name of the Mesh resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(gagr::LocationName parent, Mesh mesh, string meshId, st::CancellationToken cancellationToken) =>
            CreateMeshAsync(parent, mesh, meshId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> UpdateMesh(UpdateMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> UpdateMeshAsync(UpdateMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> UpdateMeshAsync(UpdateMeshRequest request, st::CancellationToken cancellationToken) =>
            UpdateMeshAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMesh</c>.</summary>
        public virtual lro::OperationsClient UpdateMeshOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMesh</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> PollOnceUpdateMesh(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Mesh, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMeshOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMesh</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> PollOnceUpdateMeshAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Mesh, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMeshOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="mesh">
        /// Required. Updated Mesh resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Mesh resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Mesh, OperationMetadata> UpdateMesh(Mesh mesh, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMesh(new UpdateMeshRequest
            {
                UpdateMask = updateMask,
                Mesh = gax::GaxPreconditions.CheckNotNull(mesh, nameof(mesh)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="mesh">
        /// Required. Updated Mesh resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Mesh resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> UpdateMeshAsync(Mesh mesh, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMeshAsync(new UpdateMeshRequest
            {
                UpdateMask = updateMask,
                Mesh = gax::GaxPreconditions.CheckNotNull(mesh, nameof(mesh)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="mesh">
        /// Required. Updated Mesh resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Mesh resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Mesh, OperationMetadata>> UpdateMeshAsync(Mesh mesh, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMeshAsync(mesh, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMesh(DeleteMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(DeleteMeshRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(DeleteMeshRequest request, st::CancellationToken cancellationToken) =>
            DeleteMeshAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMesh</c>.</summary>
        public virtual lro::OperationsClient DeleteMeshOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMesh</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMesh(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMeshOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMesh</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMeshAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMeshOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to delete. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMesh(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMesh(new DeleteMeshRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to delete. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMeshAsync(new DeleteMeshRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to delete. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMeshAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to delete. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMesh(MeshName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMesh(new DeleteMeshRequest
            {
                MeshName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to delete. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(MeshName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMeshAsync(new DeleteMeshRequest
            {
                MeshName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the Mesh to delete. Must be in the format
        /// `projects/*/locations/global/meshes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(MeshName name, st::CancellationToken cancellationToken) =>
            DeleteMeshAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPolicies(ListServiceLbPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPoliciesAsync(ListServiceLbPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceLbPolicies should
        /// be listed, specified in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLbPoliciesRequest request = new ListServiceLbPoliciesRequest
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
            return ListServiceLbPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceLbPolicies should
        /// be listed, specified in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLbPoliciesRequest request = new ListServiceLbPoliciesRequest
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
            return ListServiceLbPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceLbPolicies should
        /// be listed, specified in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLbPoliciesRequest request = new ListServiceLbPoliciesRequest
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
            return ListServiceLbPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServiceLbPolicies should
        /// be listed, specified in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLbPoliciesRequest request = new ListServiceLbPoliciesRequest
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
            return ListServiceLbPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLbPolicy GetServiceLbPolicy(GetServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(GetServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(GetServiceLbPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetServiceLbPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLbPolicy GetServiceLbPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLbPolicy(new GetServiceLbPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLbPolicyAsync(new GetServiceLbPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceLbPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLbPolicy GetServiceLbPolicy(ServiceLbPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLbPolicy(new GetServiceLbPolicyRequest
            {
                ServiceLbPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(ServiceLbPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLbPolicyAsync(new GetServiceLbPolicyRequest
            {
                ServiceLbPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(ServiceLbPolicyName name, st::CancellationToken cancellationToken) =>
            GetServiceLbPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> CreateServiceLbPolicy(CreateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(CreateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(CreateServiceLbPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceLbPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceLbPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateServiceLbPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateServiceLbPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> PollOnceCreateServiceLbPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceLbPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceLbPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceLbPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> PollOnceCreateServiceLbPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceLbPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceLbPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceLbPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceLbPolicy">
        /// Required. ServiceLbPolicy resource to be created.
        /// </param>
        /// <param name="serviceLbPolicyId">
        /// Required. Short name of the ServiceLbPolicy resource to be created.
        /// E.g. for resource name
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// the id is value of {service_lb_policy_name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> CreateServiceLbPolicy(string parent, ServiceLbPolicy serviceLbPolicy, string serviceLbPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLbPolicy(new CreateServiceLbPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceLbPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)),
                ServiceLbPolicy = gax::GaxPreconditions.CheckNotNull(serviceLbPolicy, nameof(serviceLbPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceLbPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceLbPolicy">
        /// Required. ServiceLbPolicy resource to be created.
        /// </param>
        /// <param name="serviceLbPolicyId">
        /// Required. Short name of the ServiceLbPolicy resource to be created.
        /// E.g. for resource name
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// the id is value of {service_lb_policy_name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(string parent, ServiceLbPolicy serviceLbPolicy, string serviceLbPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLbPolicyAsync(new CreateServiceLbPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceLbPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)),
                ServiceLbPolicy = gax::GaxPreconditions.CheckNotNull(serviceLbPolicy, nameof(serviceLbPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceLbPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceLbPolicy">
        /// Required. ServiceLbPolicy resource to be created.
        /// </param>
        /// <param name="serviceLbPolicyId">
        /// Required. Short name of the ServiceLbPolicy resource to be created.
        /// E.g. for resource name
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// the id is value of {service_lb_policy_name}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(string parent, ServiceLbPolicy serviceLbPolicy, string serviceLbPolicyId, st::CancellationToken cancellationToken) =>
            CreateServiceLbPolicyAsync(parent, serviceLbPolicy, serviceLbPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceLbPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceLbPolicy">
        /// Required. ServiceLbPolicy resource to be created.
        /// </param>
        /// <param name="serviceLbPolicyId">
        /// Required. Short name of the ServiceLbPolicy resource to be created.
        /// E.g. for resource name
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// the id is value of {service_lb_policy_name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> CreateServiceLbPolicy(gagr::LocationName parent, ServiceLbPolicy serviceLbPolicy, string serviceLbPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLbPolicy(new CreateServiceLbPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceLbPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)),
                ServiceLbPolicy = gax::GaxPreconditions.CheckNotNull(serviceLbPolicy, nameof(serviceLbPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceLbPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceLbPolicy">
        /// Required. ServiceLbPolicy resource to be created.
        /// </param>
        /// <param name="serviceLbPolicyId">
        /// Required. Short name of the ServiceLbPolicy resource to be created.
        /// E.g. for resource name
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// the id is value of {service_lb_policy_name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(gagr::LocationName parent, ServiceLbPolicy serviceLbPolicy, string serviceLbPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLbPolicyAsync(new CreateServiceLbPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceLbPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)),
                ServiceLbPolicy = gax::GaxPreconditions.CheckNotNull(serviceLbPolicy, nameof(serviceLbPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServiceLbPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceLbPolicy">
        /// Required. ServiceLbPolicy resource to be created.
        /// </param>
        /// <param name="serviceLbPolicyId">
        /// Required. Short name of the ServiceLbPolicy resource to be created.
        /// E.g. for resource name
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// the id is value of {service_lb_policy_name}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(gagr::LocationName parent, ServiceLbPolicy serviceLbPolicy, string serviceLbPolicyId, st::CancellationToken cancellationToken) =>
            CreateServiceLbPolicyAsync(parent, serviceLbPolicy, serviceLbPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> UpdateServiceLbPolicy(UpdateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> UpdateServiceLbPolicyAsync(UpdateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> UpdateServiceLbPolicyAsync(UpdateServiceLbPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceLbPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServiceLbPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceLbPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateServiceLbPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> PollOnceUpdateServiceLbPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceLbPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceLbPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServiceLbPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> PollOnceUpdateServiceLbPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceLbPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceLbPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="serviceLbPolicy">
        /// Required. Updated ServiceLbPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceLbPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceLbPolicy, OperationMetadata> UpdateServiceLbPolicy(ServiceLbPolicy serviceLbPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceLbPolicy(new UpdateServiceLbPolicyRequest
            {
                UpdateMask = updateMask,
                ServiceLbPolicy = gax::GaxPreconditions.CheckNotNull(serviceLbPolicy, nameof(serviceLbPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="serviceLbPolicy">
        /// Required. Updated ServiceLbPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceLbPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> UpdateServiceLbPolicyAsync(ServiceLbPolicy serviceLbPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceLbPolicyAsync(new UpdateServiceLbPolicyRequest
            {
                UpdateMask = updateMask,
                ServiceLbPolicy = gax::GaxPreconditions.CheckNotNull(serviceLbPolicy, nameof(serviceLbPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="serviceLbPolicy">
        /// Required. Updated ServiceLbPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServiceLbPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> UpdateServiceLbPolicyAsync(ServiceLbPolicy serviceLbPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceLbPolicyAsync(serviceLbPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceLbPolicy(DeleteServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(DeleteServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(DeleteServiceLbPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceLbPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceLbPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceLbPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteServiceLbPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceLbPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceLbPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceLbPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceLbPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceLbPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceLbPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLbPolicy(new DeleteServiceLbPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLbPolicyAsync(new DeleteServiceLbPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceLbPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceLbPolicy(ServiceLbPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLbPolicy(new DeleteServiceLbPolicyRequest
            {
                ServiceLbPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(ServiceLbPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLbPolicyAsync(new DeleteServiceLbPolicyRequest
            {
                ServiceLbPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
        /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(ServiceLbPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteServiceLbPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewayRouteView GetGatewayRouteView(GetGatewayRouteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(GetGatewayRouteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(GetGatewayRouteViewRequest request, st::CancellationToken cancellationToken) =>
            GetGatewayRouteViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the GatewayRouteView resource.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewayRouteView GetGatewayRouteView(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayRouteView(new GetGatewayRouteViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the GatewayRouteView resource.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayRouteViewAsync(new GetGatewayRouteViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the GatewayRouteView resource.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(string name, st::CancellationToken cancellationToken) =>
            GetGatewayRouteViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the GatewayRouteView resource.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewayRouteView GetGatewayRouteView(GatewayRouteViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayRouteView(new GetGatewayRouteViewRequest
            {
                GatewayRouteViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the GatewayRouteView resource.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(GatewayRouteViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayRouteViewAsync(new GetGatewayRouteViewRequest
            {
                GatewayRouteViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the GatewayRouteView resource.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(GatewayRouteViewName name, st::CancellationToken cancellationToken) =>
            GetGatewayRouteViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeshRouteView GetMeshRouteView(GetMeshRouteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeshRouteView> GetMeshRouteViewAsync(GetMeshRouteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeshRouteView> GetMeshRouteViewAsync(GetMeshRouteViewRequest request, st::CancellationToken cancellationToken) =>
            GetMeshRouteViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the MeshRouteView resource.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeshRouteView GetMeshRouteView(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeshRouteView(new GetMeshRouteViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the MeshRouteView resource.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeshRouteView> GetMeshRouteViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeshRouteViewAsync(new GetMeshRouteViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the MeshRouteView resource.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeshRouteView> GetMeshRouteViewAsync(string name, st::CancellationToken cancellationToken) =>
            GetMeshRouteViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the MeshRouteView resource.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MeshRouteView GetMeshRouteView(MeshRouteViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeshRouteView(new GetMeshRouteViewRequest
            {
                MeshRouteViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the MeshRouteView resource.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeshRouteView> GetMeshRouteViewAsync(MeshRouteViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMeshRouteViewAsync(new GetMeshRouteViewRequest
            {
                MeshRouteViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the MeshRouteView resource.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MeshRouteView> GetMeshRouteViewAsync(MeshRouteViewName name, st::CancellationToken cancellationToken) =>
            GetMeshRouteViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViews(ListGatewayRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViewsAsync(ListGatewayRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Gateway to which a Route is associated.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}
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
        /// <returns>A pageable sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewayRouteViewsRequest request = new ListGatewayRouteViewsRequest
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
            return ListGatewayRouteViews(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Gateway to which a Route is associated.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}
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
        /// <returns>A pageable asynchronous sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewayRouteViewsRequest request = new ListGatewayRouteViewsRequest
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
            return ListGatewayRouteViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Gateway to which a Route is associated.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}
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
        /// <returns>A pageable sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViews(GatewayName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewayRouteViewsRequest request = new ListGatewayRouteViewsRequest
            {
                ParentAsGatewayName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGatewayRouteViews(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Gateway to which a Route is associated.
        /// Formats:
        /// projects/{project}/locations/{location}/gateways/{gateway}
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
        /// <returns>A pageable asynchronous sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViewsAsync(GatewayName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewayRouteViewsRequest request = new ListGatewayRouteViewsRequest
            {
                ParentAsGatewayName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGatewayRouteViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MeshRouteView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViews(ListMeshRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MeshRouteView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViewsAsync(ListMeshRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Mesh to which a Route is associated.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}
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
        /// <returns>A pageable sequence of <see cref="MeshRouteView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshRouteViewsRequest request = new ListMeshRouteViewsRequest
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
            return ListMeshRouteViews(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Mesh to which a Route is associated.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}
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
        /// <returns>A pageable asynchronous sequence of <see cref="MeshRouteView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshRouteViewsRequest request = new ListMeshRouteViewsRequest
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
            return ListMeshRouteViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Mesh to which a Route is associated.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}
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
        /// <returns>A pageable sequence of <see cref="MeshRouteView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViews(MeshName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshRouteViewsRequest request = new ListMeshRouteViewsRequest
            {
                ParentAsMeshName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMeshRouteViews(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="parent">
        /// Required. The Mesh to which a Route is associated.
        /// Format:
        /// projects/{project}/locations/{location}/meshes/{mesh}
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
        /// <returns>A pageable asynchronous sequence of <see cref="MeshRouteView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViewsAsync(MeshName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMeshRouteViewsRequest request = new ListMeshRouteViewsRequest
            {
                ParentAsMeshName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMeshRouteViewsAsync(request, callSettings);
        }
    }

    /// <summary>NetworkServices client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public sealed partial class NetworkServicesClientImpl : NetworkServicesClient
    {
        private readonly gaxgrpc::ApiCall<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse> _callListEndpointPolicies;

        private readonly gaxgrpc::ApiCall<GetEndpointPolicyRequest, EndpointPolicy> _callGetEndpointPolicy;

        private readonly gaxgrpc::ApiCall<CreateEndpointPolicyRequest, lro::Operation> _callCreateEndpointPolicy;

        private readonly gaxgrpc::ApiCall<UpdateEndpointPolicyRequest, lro::Operation> _callUpdateEndpointPolicy;

        private readonly gaxgrpc::ApiCall<DeleteEndpointPolicyRequest, lro::Operation> _callDeleteEndpointPolicy;

        private readonly gaxgrpc::ApiCall<ListGatewaysRequest, ListGatewaysResponse> _callListGateways;

        private readonly gaxgrpc::ApiCall<GetGatewayRequest, Gateway> _callGetGateway;

        private readonly gaxgrpc::ApiCall<CreateGatewayRequest, lro::Operation> _callCreateGateway;

        private readonly gaxgrpc::ApiCall<UpdateGatewayRequest, lro::Operation> _callUpdateGateway;

        private readonly gaxgrpc::ApiCall<DeleteGatewayRequest, lro::Operation> _callDeleteGateway;

        private readonly gaxgrpc::ApiCall<ListGrpcRoutesRequest, ListGrpcRoutesResponse> _callListGrpcRoutes;

        private readonly gaxgrpc::ApiCall<GetGrpcRouteRequest, GrpcRoute> _callGetGrpcRoute;

        private readonly gaxgrpc::ApiCall<CreateGrpcRouteRequest, lro::Operation> _callCreateGrpcRoute;

        private readonly gaxgrpc::ApiCall<UpdateGrpcRouteRequest, lro::Operation> _callUpdateGrpcRoute;

        private readonly gaxgrpc::ApiCall<DeleteGrpcRouteRequest, lro::Operation> _callDeleteGrpcRoute;

        private readonly gaxgrpc::ApiCall<ListHttpRoutesRequest, ListHttpRoutesResponse> _callListHttpRoutes;

        private readonly gaxgrpc::ApiCall<GetHttpRouteRequest, HttpRoute> _callGetHttpRoute;

        private readonly gaxgrpc::ApiCall<CreateHttpRouteRequest, lro::Operation> _callCreateHttpRoute;

        private readonly gaxgrpc::ApiCall<UpdateHttpRouteRequest, lro::Operation> _callUpdateHttpRoute;

        private readonly gaxgrpc::ApiCall<DeleteHttpRouteRequest, lro::Operation> _callDeleteHttpRoute;

        private readonly gaxgrpc::ApiCall<ListTcpRoutesRequest, ListTcpRoutesResponse> _callListTcpRoutes;

        private readonly gaxgrpc::ApiCall<GetTcpRouteRequest, TcpRoute> _callGetTcpRoute;

        private readonly gaxgrpc::ApiCall<CreateTcpRouteRequest, lro::Operation> _callCreateTcpRoute;

        private readonly gaxgrpc::ApiCall<UpdateTcpRouteRequest, lro::Operation> _callUpdateTcpRoute;

        private readonly gaxgrpc::ApiCall<DeleteTcpRouteRequest, lro::Operation> _callDeleteTcpRoute;

        private readonly gaxgrpc::ApiCall<ListTlsRoutesRequest, ListTlsRoutesResponse> _callListTlsRoutes;

        private readonly gaxgrpc::ApiCall<GetTlsRouteRequest, TlsRoute> _callGetTlsRoute;

        private readonly gaxgrpc::ApiCall<CreateTlsRouteRequest, lro::Operation> _callCreateTlsRoute;

        private readonly gaxgrpc::ApiCall<UpdateTlsRouteRequest, lro::Operation> _callUpdateTlsRoute;

        private readonly gaxgrpc::ApiCall<DeleteTlsRouteRequest, lro::Operation> _callDeleteTlsRoute;

        private readonly gaxgrpc::ApiCall<ListServiceBindingsRequest, ListServiceBindingsResponse> _callListServiceBindings;

        private readonly gaxgrpc::ApiCall<GetServiceBindingRequest, ServiceBinding> _callGetServiceBinding;

        private readonly gaxgrpc::ApiCall<CreateServiceBindingRequest, lro::Operation> _callCreateServiceBinding;

        private readonly gaxgrpc::ApiCall<UpdateServiceBindingRequest, lro::Operation> _callUpdateServiceBinding;

        private readonly gaxgrpc::ApiCall<DeleteServiceBindingRequest, lro::Operation> _callDeleteServiceBinding;

        private readonly gaxgrpc::ApiCall<ListMeshesRequest, ListMeshesResponse> _callListMeshes;

        private readonly gaxgrpc::ApiCall<GetMeshRequest, Mesh> _callGetMesh;

        private readonly gaxgrpc::ApiCall<CreateMeshRequest, lro::Operation> _callCreateMesh;

        private readonly gaxgrpc::ApiCall<UpdateMeshRequest, lro::Operation> _callUpdateMesh;

        private readonly gaxgrpc::ApiCall<DeleteMeshRequest, lro::Operation> _callDeleteMesh;

        private readonly gaxgrpc::ApiCall<ListServiceLbPoliciesRequest, ListServiceLbPoliciesResponse> _callListServiceLbPolicies;

        private readonly gaxgrpc::ApiCall<GetServiceLbPolicyRequest, ServiceLbPolicy> _callGetServiceLbPolicy;

        private readonly gaxgrpc::ApiCall<CreateServiceLbPolicyRequest, lro::Operation> _callCreateServiceLbPolicy;

        private readonly gaxgrpc::ApiCall<UpdateServiceLbPolicyRequest, lro::Operation> _callUpdateServiceLbPolicy;

        private readonly gaxgrpc::ApiCall<DeleteServiceLbPolicyRequest, lro::Operation> _callDeleteServiceLbPolicy;

        private readonly gaxgrpc::ApiCall<GetGatewayRouteViewRequest, GatewayRouteView> _callGetGatewayRouteView;

        private readonly gaxgrpc::ApiCall<GetMeshRouteViewRequest, MeshRouteView> _callGetMeshRouteView;

        private readonly gaxgrpc::ApiCall<ListGatewayRouteViewsRequest, ListGatewayRouteViewsResponse> _callListGatewayRouteViews;

        private readonly gaxgrpc::ApiCall<ListMeshRouteViewsRequest, ListMeshRouteViewsResponse> _callListMeshRouteViews;

        /// <summary>
        /// Constructs a client wrapper for the NetworkServices service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetworkServicesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetworkServicesClientImpl(NetworkServices.NetworkServicesClient grpcClient, NetworkServicesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetworkServicesSettings effectiveSettings = settings ?? NetworkServicesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEndpointPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEndpointPolicyOperationsSettings, logger);
            UpdateEndpointPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEndpointPolicyOperationsSettings, logger);
            DeleteEndpointPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEndpointPolicyOperationsSettings, logger);
            CreateGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGatewayOperationsSettings, logger);
            UpdateGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGatewayOperationsSettings, logger);
            DeleteGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGatewayOperationsSettings, logger);
            CreateGrpcRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGrpcRouteOperationsSettings, logger);
            UpdateGrpcRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGrpcRouteOperationsSettings, logger);
            DeleteGrpcRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGrpcRouteOperationsSettings, logger);
            CreateHttpRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHttpRouteOperationsSettings, logger);
            UpdateHttpRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateHttpRouteOperationsSettings, logger);
            DeleteHttpRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHttpRouteOperationsSettings, logger);
            CreateTcpRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTcpRouteOperationsSettings, logger);
            UpdateTcpRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTcpRouteOperationsSettings, logger);
            DeleteTcpRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTcpRouteOperationsSettings, logger);
            CreateTlsRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTlsRouteOperationsSettings, logger);
            UpdateTlsRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTlsRouteOperationsSettings, logger);
            DeleteTlsRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTlsRouteOperationsSettings, logger);
            CreateServiceBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceBindingOperationsSettings, logger);
            UpdateServiceBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceBindingOperationsSettings, logger);
            DeleteServiceBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceBindingOperationsSettings, logger);
            CreateMeshOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMeshOperationsSettings, logger);
            UpdateMeshOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMeshOperationsSettings, logger);
            DeleteMeshOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMeshOperationsSettings, logger);
            CreateServiceLbPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceLbPolicyOperationsSettings, logger);
            UpdateServiceLbPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceLbPolicyOperationsSettings, logger);
            DeleteServiceLbPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceLbPolicyOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListEndpointPolicies = clientHelper.BuildApiCall<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>("ListEndpointPolicies", grpcClient.ListEndpointPoliciesAsync, grpcClient.ListEndpointPolicies, effectiveSettings.ListEndpointPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEndpointPolicies);
            Modify_ListEndpointPoliciesApiCall(ref _callListEndpointPolicies);
            _callGetEndpointPolicy = clientHelper.BuildApiCall<GetEndpointPolicyRequest, EndpointPolicy>("GetEndpointPolicy", grpcClient.GetEndpointPolicyAsync, grpcClient.GetEndpointPolicy, effectiveSettings.GetEndpointPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEndpointPolicy);
            Modify_GetEndpointPolicyApiCall(ref _callGetEndpointPolicy);
            _callCreateEndpointPolicy = clientHelper.BuildApiCall<CreateEndpointPolicyRequest, lro::Operation>("CreateEndpointPolicy", grpcClient.CreateEndpointPolicyAsync, grpcClient.CreateEndpointPolicy, effectiveSettings.CreateEndpointPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEndpointPolicy);
            Modify_CreateEndpointPolicyApiCall(ref _callCreateEndpointPolicy);
            _callUpdateEndpointPolicy = clientHelper.BuildApiCall<UpdateEndpointPolicyRequest, lro::Operation>("UpdateEndpointPolicy", grpcClient.UpdateEndpointPolicyAsync, grpcClient.UpdateEndpointPolicy, effectiveSettings.UpdateEndpointPolicySettings).WithGoogleRequestParam("endpoint_policy.name", request => request.EndpointPolicy?.Name);
            Modify_ApiCall(ref _callUpdateEndpointPolicy);
            Modify_UpdateEndpointPolicyApiCall(ref _callUpdateEndpointPolicy);
            _callDeleteEndpointPolicy = clientHelper.BuildApiCall<DeleteEndpointPolicyRequest, lro::Operation>("DeleteEndpointPolicy", grpcClient.DeleteEndpointPolicyAsync, grpcClient.DeleteEndpointPolicy, effectiveSettings.DeleteEndpointPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEndpointPolicy);
            Modify_DeleteEndpointPolicyApiCall(ref _callDeleteEndpointPolicy);
            _callListGateways = clientHelper.BuildApiCall<ListGatewaysRequest, ListGatewaysResponse>("ListGateways", grpcClient.ListGatewaysAsync, grpcClient.ListGateways, effectiveSettings.ListGatewaysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGateways);
            Modify_ListGatewaysApiCall(ref _callListGateways);
            _callGetGateway = clientHelper.BuildApiCall<GetGatewayRequest, Gateway>("GetGateway", grpcClient.GetGatewayAsync, grpcClient.GetGateway, effectiveSettings.GetGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGateway);
            Modify_GetGatewayApiCall(ref _callGetGateway);
            _callCreateGateway = clientHelper.BuildApiCall<CreateGatewayRequest, lro::Operation>("CreateGateway", grpcClient.CreateGatewayAsync, grpcClient.CreateGateway, effectiveSettings.CreateGatewaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGateway);
            Modify_CreateGatewayApiCall(ref _callCreateGateway);
            _callUpdateGateway = clientHelper.BuildApiCall<UpdateGatewayRequest, lro::Operation>("UpdateGateway", grpcClient.UpdateGatewayAsync, grpcClient.UpdateGateway, effectiveSettings.UpdateGatewaySettings).WithGoogleRequestParam("gateway.name", request => request.Gateway?.Name);
            Modify_ApiCall(ref _callUpdateGateway);
            Modify_UpdateGatewayApiCall(ref _callUpdateGateway);
            _callDeleteGateway = clientHelper.BuildApiCall<DeleteGatewayRequest, lro::Operation>("DeleteGateway", grpcClient.DeleteGatewayAsync, grpcClient.DeleteGateway, effectiveSettings.DeleteGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGateway);
            Modify_DeleteGatewayApiCall(ref _callDeleteGateway);
            _callListGrpcRoutes = clientHelper.BuildApiCall<ListGrpcRoutesRequest, ListGrpcRoutesResponse>("ListGrpcRoutes", grpcClient.ListGrpcRoutesAsync, grpcClient.ListGrpcRoutes, effectiveSettings.ListGrpcRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGrpcRoutes);
            Modify_ListGrpcRoutesApiCall(ref _callListGrpcRoutes);
            _callGetGrpcRoute = clientHelper.BuildApiCall<GetGrpcRouteRequest, GrpcRoute>("GetGrpcRoute", grpcClient.GetGrpcRouteAsync, grpcClient.GetGrpcRoute, effectiveSettings.GetGrpcRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGrpcRoute);
            Modify_GetGrpcRouteApiCall(ref _callGetGrpcRoute);
            _callCreateGrpcRoute = clientHelper.BuildApiCall<CreateGrpcRouteRequest, lro::Operation>("CreateGrpcRoute", grpcClient.CreateGrpcRouteAsync, grpcClient.CreateGrpcRoute, effectiveSettings.CreateGrpcRouteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGrpcRoute);
            Modify_CreateGrpcRouteApiCall(ref _callCreateGrpcRoute);
            _callUpdateGrpcRoute = clientHelper.BuildApiCall<UpdateGrpcRouteRequest, lro::Operation>("UpdateGrpcRoute", grpcClient.UpdateGrpcRouteAsync, grpcClient.UpdateGrpcRoute, effectiveSettings.UpdateGrpcRouteSettings).WithGoogleRequestParam("grpc_route.name", request => request.GrpcRoute?.Name);
            Modify_ApiCall(ref _callUpdateGrpcRoute);
            Modify_UpdateGrpcRouteApiCall(ref _callUpdateGrpcRoute);
            _callDeleteGrpcRoute = clientHelper.BuildApiCall<DeleteGrpcRouteRequest, lro::Operation>("DeleteGrpcRoute", grpcClient.DeleteGrpcRouteAsync, grpcClient.DeleteGrpcRoute, effectiveSettings.DeleteGrpcRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGrpcRoute);
            Modify_DeleteGrpcRouteApiCall(ref _callDeleteGrpcRoute);
            _callListHttpRoutes = clientHelper.BuildApiCall<ListHttpRoutesRequest, ListHttpRoutesResponse>("ListHttpRoutes", grpcClient.ListHttpRoutesAsync, grpcClient.ListHttpRoutes, effectiveSettings.ListHttpRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHttpRoutes);
            Modify_ListHttpRoutesApiCall(ref _callListHttpRoutes);
            _callGetHttpRoute = clientHelper.BuildApiCall<GetHttpRouteRequest, HttpRoute>("GetHttpRoute", grpcClient.GetHttpRouteAsync, grpcClient.GetHttpRoute, effectiveSettings.GetHttpRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHttpRoute);
            Modify_GetHttpRouteApiCall(ref _callGetHttpRoute);
            _callCreateHttpRoute = clientHelper.BuildApiCall<CreateHttpRouteRequest, lro::Operation>("CreateHttpRoute", grpcClient.CreateHttpRouteAsync, grpcClient.CreateHttpRoute, effectiveSettings.CreateHttpRouteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHttpRoute);
            Modify_CreateHttpRouteApiCall(ref _callCreateHttpRoute);
            _callUpdateHttpRoute = clientHelper.BuildApiCall<UpdateHttpRouteRequest, lro::Operation>("UpdateHttpRoute", grpcClient.UpdateHttpRouteAsync, grpcClient.UpdateHttpRoute, effectiveSettings.UpdateHttpRouteSettings).WithGoogleRequestParam("http_route.name", request => request.HttpRoute?.Name);
            Modify_ApiCall(ref _callUpdateHttpRoute);
            Modify_UpdateHttpRouteApiCall(ref _callUpdateHttpRoute);
            _callDeleteHttpRoute = clientHelper.BuildApiCall<DeleteHttpRouteRequest, lro::Operation>("DeleteHttpRoute", grpcClient.DeleteHttpRouteAsync, grpcClient.DeleteHttpRoute, effectiveSettings.DeleteHttpRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHttpRoute);
            Modify_DeleteHttpRouteApiCall(ref _callDeleteHttpRoute);
            _callListTcpRoutes = clientHelper.BuildApiCall<ListTcpRoutesRequest, ListTcpRoutesResponse>("ListTcpRoutes", grpcClient.ListTcpRoutesAsync, grpcClient.ListTcpRoutes, effectiveSettings.ListTcpRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTcpRoutes);
            Modify_ListTcpRoutesApiCall(ref _callListTcpRoutes);
            _callGetTcpRoute = clientHelper.BuildApiCall<GetTcpRouteRequest, TcpRoute>("GetTcpRoute", grpcClient.GetTcpRouteAsync, grpcClient.GetTcpRoute, effectiveSettings.GetTcpRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTcpRoute);
            Modify_GetTcpRouteApiCall(ref _callGetTcpRoute);
            _callCreateTcpRoute = clientHelper.BuildApiCall<CreateTcpRouteRequest, lro::Operation>("CreateTcpRoute", grpcClient.CreateTcpRouteAsync, grpcClient.CreateTcpRoute, effectiveSettings.CreateTcpRouteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTcpRoute);
            Modify_CreateTcpRouteApiCall(ref _callCreateTcpRoute);
            _callUpdateTcpRoute = clientHelper.BuildApiCall<UpdateTcpRouteRequest, lro::Operation>("UpdateTcpRoute", grpcClient.UpdateTcpRouteAsync, grpcClient.UpdateTcpRoute, effectiveSettings.UpdateTcpRouteSettings).WithGoogleRequestParam("tcp_route.name", request => request.TcpRoute?.Name);
            Modify_ApiCall(ref _callUpdateTcpRoute);
            Modify_UpdateTcpRouteApiCall(ref _callUpdateTcpRoute);
            _callDeleteTcpRoute = clientHelper.BuildApiCall<DeleteTcpRouteRequest, lro::Operation>("DeleteTcpRoute", grpcClient.DeleteTcpRouteAsync, grpcClient.DeleteTcpRoute, effectiveSettings.DeleteTcpRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTcpRoute);
            Modify_DeleteTcpRouteApiCall(ref _callDeleteTcpRoute);
            _callListTlsRoutes = clientHelper.BuildApiCall<ListTlsRoutesRequest, ListTlsRoutesResponse>("ListTlsRoutes", grpcClient.ListTlsRoutesAsync, grpcClient.ListTlsRoutes, effectiveSettings.ListTlsRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTlsRoutes);
            Modify_ListTlsRoutesApiCall(ref _callListTlsRoutes);
            _callGetTlsRoute = clientHelper.BuildApiCall<GetTlsRouteRequest, TlsRoute>("GetTlsRoute", grpcClient.GetTlsRouteAsync, grpcClient.GetTlsRoute, effectiveSettings.GetTlsRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTlsRoute);
            Modify_GetTlsRouteApiCall(ref _callGetTlsRoute);
            _callCreateTlsRoute = clientHelper.BuildApiCall<CreateTlsRouteRequest, lro::Operation>("CreateTlsRoute", grpcClient.CreateTlsRouteAsync, grpcClient.CreateTlsRoute, effectiveSettings.CreateTlsRouteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTlsRoute);
            Modify_CreateTlsRouteApiCall(ref _callCreateTlsRoute);
            _callUpdateTlsRoute = clientHelper.BuildApiCall<UpdateTlsRouteRequest, lro::Operation>("UpdateTlsRoute", grpcClient.UpdateTlsRouteAsync, grpcClient.UpdateTlsRoute, effectiveSettings.UpdateTlsRouteSettings).WithGoogleRequestParam("tls_route.name", request => request.TlsRoute?.Name);
            Modify_ApiCall(ref _callUpdateTlsRoute);
            Modify_UpdateTlsRouteApiCall(ref _callUpdateTlsRoute);
            _callDeleteTlsRoute = clientHelper.BuildApiCall<DeleteTlsRouteRequest, lro::Operation>("DeleteTlsRoute", grpcClient.DeleteTlsRouteAsync, grpcClient.DeleteTlsRoute, effectiveSettings.DeleteTlsRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTlsRoute);
            Modify_DeleteTlsRouteApiCall(ref _callDeleteTlsRoute);
            _callListServiceBindings = clientHelper.BuildApiCall<ListServiceBindingsRequest, ListServiceBindingsResponse>("ListServiceBindings", grpcClient.ListServiceBindingsAsync, grpcClient.ListServiceBindings, effectiveSettings.ListServiceBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceBindings);
            Modify_ListServiceBindingsApiCall(ref _callListServiceBindings);
            _callGetServiceBinding = clientHelper.BuildApiCall<GetServiceBindingRequest, ServiceBinding>("GetServiceBinding", grpcClient.GetServiceBindingAsync, grpcClient.GetServiceBinding, effectiveSettings.GetServiceBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceBinding);
            Modify_GetServiceBindingApiCall(ref _callGetServiceBinding);
            _callCreateServiceBinding = clientHelper.BuildApiCall<CreateServiceBindingRequest, lro::Operation>("CreateServiceBinding", grpcClient.CreateServiceBindingAsync, grpcClient.CreateServiceBinding, effectiveSettings.CreateServiceBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceBinding);
            Modify_CreateServiceBindingApiCall(ref _callCreateServiceBinding);
            _callUpdateServiceBinding = clientHelper.BuildApiCall<UpdateServiceBindingRequest, lro::Operation>("UpdateServiceBinding", grpcClient.UpdateServiceBindingAsync, grpcClient.UpdateServiceBinding, effectiveSettings.UpdateServiceBindingSettings).WithGoogleRequestParam("service_binding.name", request => request.ServiceBinding?.Name);
            Modify_ApiCall(ref _callUpdateServiceBinding);
            Modify_UpdateServiceBindingApiCall(ref _callUpdateServiceBinding);
            _callDeleteServiceBinding = clientHelper.BuildApiCall<DeleteServiceBindingRequest, lro::Operation>("DeleteServiceBinding", grpcClient.DeleteServiceBindingAsync, grpcClient.DeleteServiceBinding, effectiveSettings.DeleteServiceBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceBinding);
            Modify_DeleteServiceBindingApiCall(ref _callDeleteServiceBinding);
            _callListMeshes = clientHelper.BuildApiCall<ListMeshesRequest, ListMeshesResponse>("ListMeshes", grpcClient.ListMeshesAsync, grpcClient.ListMeshes, effectiveSettings.ListMeshesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMeshes);
            Modify_ListMeshesApiCall(ref _callListMeshes);
            _callGetMesh = clientHelper.BuildApiCall<GetMeshRequest, Mesh>("GetMesh", grpcClient.GetMeshAsync, grpcClient.GetMesh, effectiveSettings.GetMeshSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMesh);
            Modify_GetMeshApiCall(ref _callGetMesh);
            _callCreateMesh = clientHelper.BuildApiCall<CreateMeshRequest, lro::Operation>("CreateMesh", grpcClient.CreateMeshAsync, grpcClient.CreateMesh, effectiveSettings.CreateMeshSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMesh);
            Modify_CreateMeshApiCall(ref _callCreateMesh);
            _callUpdateMesh = clientHelper.BuildApiCall<UpdateMeshRequest, lro::Operation>("UpdateMesh", grpcClient.UpdateMeshAsync, grpcClient.UpdateMesh, effectiveSettings.UpdateMeshSettings).WithGoogleRequestParam("mesh.name", request => request.Mesh?.Name);
            Modify_ApiCall(ref _callUpdateMesh);
            Modify_UpdateMeshApiCall(ref _callUpdateMesh);
            _callDeleteMesh = clientHelper.BuildApiCall<DeleteMeshRequest, lro::Operation>("DeleteMesh", grpcClient.DeleteMeshAsync, grpcClient.DeleteMesh, effectiveSettings.DeleteMeshSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMesh);
            Modify_DeleteMeshApiCall(ref _callDeleteMesh);
            _callListServiceLbPolicies = clientHelper.BuildApiCall<ListServiceLbPoliciesRequest, ListServiceLbPoliciesResponse>("ListServiceLbPolicies", grpcClient.ListServiceLbPoliciesAsync, grpcClient.ListServiceLbPolicies, effectiveSettings.ListServiceLbPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceLbPolicies);
            Modify_ListServiceLbPoliciesApiCall(ref _callListServiceLbPolicies);
            _callGetServiceLbPolicy = clientHelper.BuildApiCall<GetServiceLbPolicyRequest, ServiceLbPolicy>("GetServiceLbPolicy", grpcClient.GetServiceLbPolicyAsync, grpcClient.GetServiceLbPolicy, effectiveSettings.GetServiceLbPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceLbPolicy);
            Modify_GetServiceLbPolicyApiCall(ref _callGetServiceLbPolicy);
            _callCreateServiceLbPolicy = clientHelper.BuildApiCall<CreateServiceLbPolicyRequest, lro::Operation>("CreateServiceLbPolicy", grpcClient.CreateServiceLbPolicyAsync, grpcClient.CreateServiceLbPolicy, effectiveSettings.CreateServiceLbPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceLbPolicy);
            Modify_CreateServiceLbPolicyApiCall(ref _callCreateServiceLbPolicy);
            _callUpdateServiceLbPolicy = clientHelper.BuildApiCall<UpdateServiceLbPolicyRequest, lro::Operation>("UpdateServiceLbPolicy", grpcClient.UpdateServiceLbPolicyAsync, grpcClient.UpdateServiceLbPolicy, effectiveSettings.UpdateServiceLbPolicySettings).WithGoogleRequestParam("service_lb_policy.name", request => request.ServiceLbPolicy?.Name);
            Modify_ApiCall(ref _callUpdateServiceLbPolicy);
            Modify_UpdateServiceLbPolicyApiCall(ref _callUpdateServiceLbPolicy);
            _callDeleteServiceLbPolicy = clientHelper.BuildApiCall<DeleteServiceLbPolicyRequest, lro::Operation>("DeleteServiceLbPolicy", grpcClient.DeleteServiceLbPolicyAsync, grpcClient.DeleteServiceLbPolicy, effectiveSettings.DeleteServiceLbPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceLbPolicy);
            Modify_DeleteServiceLbPolicyApiCall(ref _callDeleteServiceLbPolicy);
            _callGetGatewayRouteView = clientHelper.BuildApiCall<GetGatewayRouteViewRequest, GatewayRouteView>("GetGatewayRouteView", grpcClient.GetGatewayRouteViewAsync, grpcClient.GetGatewayRouteView, effectiveSettings.GetGatewayRouteViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGatewayRouteView);
            Modify_GetGatewayRouteViewApiCall(ref _callGetGatewayRouteView);
            _callGetMeshRouteView = clientHelper.BuildApiCall<GetMeshRouteViewRequest, MeshRouteView>("GetMeshRouteView", grpcClient.GetMeshRouteViewAsync, grpcClient.GetMeshRouteView, effectiveSettings.GetMeshRouteViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMeshRouteView);
            Modify_GetMeshRouteViewApiCall(ref _callGetMeshRouteView);
            _callListGatewayRouteViews = clientHelper.BuildApiCall<ListGatewayRouteViewsRequest, ListGatewayRouteViewsResponse>("ListGatewayRouteViews", grpcClient.ListGatewayRouteViewsAsync, grpcClient.ListGatewayRouteViews, effectiveSettings.ListGatewayRouteViewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGatewayRouteViews);
            Modify_ListGatewayRouteViewsApiCall(ref _callListGatewayRouteViews);
            _callListMeshRouteViews = clientHelper.BuildApiCall<ListMeshRouteViewsRequest, ListMeshRouteViewsResponse>("ListMeshRouteViews", grpcClient.ListMeshRouteViewsAsync, grpcClient.ListMeshRouteViews, effectiveSettings.ListMeshRouteViewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMeshRouteViews);
            Modify_ListMeshRouteViewsApiCall(ref _callListMeshRouteViews);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEndpointPoliciesApiCall(ref gaxgrpc::ApiCall<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse> call);

        partial void Modify_GetEndpointPolicyApiCall(ref gaxgrpc::ApiCall<GetEndpointPolicyRequest, EndpointPolicy> call);

        partial void Modify_CreateEndpointPolicyApiCall(ref gaxgrpc::ApiCall<CreateEndpointPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateEndpointPolicyApiCall(ref gaxgrpc::ApiCall<UpdateEndpointPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteEndpointPolicyApiCall(ref gaxgrpc::ApiCall<DeleteEndpointPolicyRequest, lro::Operation> call);

        partial void Modify_ListGatewaysApiCall(ref gaxgrpc::ApiCall<ListGatewaysRequest, ListGatewaysResponse> call);

        partial void Modify_GetGatewayApiCall(ref gaxgrpc::ApiCall<GetGatewayRequest, Gateway> call);

        partial void Modify_CreateGatewayApiCall(ref gaxgrpc::ApiCall<CreateGatewayRequest, lro::Operation> call);

        partial void Modify_UpdateGatewayApiCall(ref gaxgrpc::ApiCall<UpdateGatewayRequest, lro::Operation> call);

        partial void Modify_DeleteGatewayApiCall(ref gaxgrpc::ApiCall<DeleteGatewayRequest, lro::Operation> call);

        partial void Modify_ListGrpcRoutesApiCall(ref gaxgrpc::ApiCall<ListGrpcRoutesRequest, ListGrpcRoutesResponse> call);

        partial void Modify_GetGrpcRouteApiCall(ref gaxgrpc::ApiCall<GetGrpcRouteRequest, GrpcRoute> call);

        partial void Modify_CreateGrpcRouteApiCall(ref gaxgrpc::ApiCall<CreateGrpcRouteRequest, lro::Operation> call);

        partial void Modify_UpdateGrpcRouteApiCall(ref gaxgrpc::ApiCall<UpdateGrpcRouteRequest, lro::Operation> call);

        partial void Modify_DeleteGrpcRouteApiCall(ref gaxgrpc::ApiCall<DeleteGrpcRouteRequest, lro::Operation> call);

        partial void Modify_ListHttpRoutesApiCall(ref gaxgrpc::ApiCall<ListHttpRoutesRequest, ListHttpRoutesResponse> call);

        partial void Modify_GetHttpRouteApiCall(ref gaxgrpc::ApiCall<GetHttpRouteRequest, HttpRoute> call);

        partial void Modify_CreateHttpRouteApiCall(ref gaxgrpc::ApiCall<CreateHttpRouteRequest, lro::Operation> call);

        partial void Modify_UpdateHttpRouteApiCall(ref gaxgrpc::ApiCall<UpdateHttpRouteRequest, lro::Operation> call);

        partial void Modify_DeleteHttpRouteApiCall(ref gaxgrpc::ApiCall<DeleteHttpRouteRequest, lro::Operation> call);

        partial void Modify_ListTcpRoutesApiCall(ref gaxgrpc::ApiCall<ListTcpRoutesRequest, ListTcpRoutesResponse> call);

        partial void Modify_GetTcpRouteApiCall(ref gaxgrpc::ApiCall<GetTcpRouteRequest, TcpRoute> call);

        partial void Modify_CreateTcpRouteApiCall(ref gaxgrpc::ApiCall<CreateTcpRouteRequest, lro::Operation> call);

        partial void Modify_UpdateTcpRouteApiCall(ref gaxgrpc::ApiCall<UpdateTcpRouteRequest, lro::Operation> call);

        partial void Modify_DeleteTcpRouteApiCall(ref gaxgrpc::ApiCall<DeleteTcpRouteRequest, lro::Operation> call);

        partial void Modify_ListTlsRoutesApiCall(ref gaxgrpc::ApiCall<ListTlsRoutesRequest, ListTlsRoutesResponse> call);

        partial void Modify_GetTlsRouteApiCall(ref gaxgrpc::ApiCall<GetTlsRouteRequest, TlsRoute> call);

        partial void Modify_CreateTlsRouteApiCall(ref gaxgrpc::ApiCall<CreateTlsRouteRequest, lro::Operation> call);

        partial void Modify_UpdateTlsRouteApiCall(ref gaxgrpc::ApiCall<UpdateTlsRouteRequest, lro::Operation> call);

        partial void Modify_DeleteTlsRouteApiCall(ref gaxgrpc::ApiCall<DeleteTlsRouteRequest, lro::Operation> call);

        partial void Modify_ListServiceBindingsApiCall(ref gaxgrpc::ApiCall<ListServiceBindingsRequest, ListServiceBindingsResponse> call);

        partial void Modify_GetServiceBindingApiCall(ref gaxgrpc::ApiCall<GetServiceBindingRequest, ServiceBinding> call);

        partial void Modify_CreateServiceBindingApiCall(ref gaxgrpc::ApiCall<CreateServiceBindingRequest, lro::Operation> call);

        partial void Modify_UpdateServiceBindingApiCall(ref gaxgrpc::ApiCall<UpdateServiceBindingRequest, lro::Operation> call);

        partial void Modify_DeleteServiceBindingApiCall(ref gaxgrpc::ApiCall<DeleteServiceBindingRequest, lro::Operation> call);

        partial void Modify_ListMeshesApiCall(ref gaxgrpc::ApiCall<ListMeshesRequest, ListMeshesResponse> call);

        partial void Modify_GetMeshApiCall(ref gaxgrpc::ApiCall<GetMeshRequest, Mesh> call);

        partial void Modify_CreateMeshApiCall(ref gaxgrpc::ApiCall<CreateMeshRequest, lro::Operation> call);

        partial void Modify_UpdateMeshApiCall(ref gaxgrpc::ApiCall<UpdateMeshRequest, lro::Operation> call);

        partial void Modify_DeleteMeshApiCall(ref gaxgrpc::ApiCall<DeleteMeshRequest, lro::Operation> call);

        partial void Modify_ListServiceLbPoliciesApiCall(ref gaxgrpc::ApiCall<ListServiceLbPoliciesRequest, ListServiceLbPoliciesResponse> call);

        partial void Modify_GetServiceLbPolicyApiCall(ref gaxgrpc::ApiCall<GetServiceLbPolicyRequest, ServiceLbPolicy> call);

        partial void Modify_CreateServiceLbPolicyApiCall(ref gaxgrpc::ApiCall<CreateServiceLbPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateServiceLbPolicyApiCall(ref gaxgrpc::ApiCall<UpdateServiceLbPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteServiceLbPolicyApiCall(ref gaxgrpc::ApiCall<DeleteServiceLbPolicyRequest, lro::Operation> call);

        partial void Modify_GetGatewayRouteViewApiCall(ref gaxgrpc::ApiCall<GetGatewayRouteViewRequest, GatewayRouteView> call);

        partial void Modify_GetMeshRouteViewApiCall(ref gaxgrpc::ApiCall<GetMeshRouteViewRequest, MeshRouteView> call);

        partial void Modify_ListGatewayRouteViewsApiCall(ref gaxgrpc::ApiCall<ListGatewayRouteViewsRequest, ListGatewayRouteViewsResponse> call);

        partial void Modify_ListMeshRouteViewsApiCall(ref gaxgrpc::ApiCall<ListMeshRouteViewsRequest, ListMeshRouteViewsResponse> call);

        partial void OnConstruction(NetworkServices.NetworkServicesClient grpcClient, NetworkServicesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkServices client</summary>
        public override NetworkServices.NetworkServicesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListEndpointPoliciesRequest(ref ListEndpointPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEndpointPolicyRequest(ref GetEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEndpointPolicyRequest(ref CreateEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEndpointPolicyRequest(ref UpdateEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEndpointPolicyRequest(ref DeleteEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGatewaysRequest(ref ListGatewaysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGatewayRequest(ref GetGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGatewayRequest(ref CreateGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGatewayRequest(ref UpdateGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGatewayRequest(ref DeleteGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGrpcRoutesRequest(ref ListGrpcRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGrpcRouteRequest(ref GetGrpcRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGrpcRouteRequest(ref CreateGrpcRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGrpcRouteRequest(ref UpdateGrpcRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGrpcRouteRequest(ref DeleteGrpcRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHttpRoutesRequest(ref ListHttpRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHttpRouteRequest(ref GetHttpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHttpRouteRequest(ref CreateHttpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHttpRouteRequest(ref UpdateHttpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHttpRouteRequest(ref DeleteHttpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTcpRoutesRequest(ref ListTcpRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTcpRouteRequest(ref GetTcpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTcpRouteRequest(ref CreateTcpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTcpRouteRequest(ref UpdateTcpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTcpRouteRequest(ref DeleteTcpRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTlsRoutesRequest(ref ListTlsRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTlsRouteRequest(ref GetTlsRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTlsRouteRequest(ref CreateTlsRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTlsRouteRequest(ref UpdateTlsRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTlsRouteRequest(ref DeleteTlsRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceBindingsRequest(ref ListServiceBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceBindingRequest(ref GetServiceBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceBindingRequest(ref CreateServiceBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceBindingRequest(ref UpdateServiceBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceBindingRequest(ref DeleteServiceBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMeshesRequest(ref ListMeshesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMeshRequest(ref GetMeshRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMeshRequest(ref CreateMeshRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMeshRequest(ref UpdateMeshRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMeshRequest(ref DeleteMeshRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceLbPoliciesRequest(ref ListServiceLbPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceLbPolicyRequest(ref GetServiceLbPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceLbPolicyRequest(ref CreateServiceLbPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceLbPolicyRequest(ref UpdateServiceLbPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceLbPolicyRequest(ref DeleteServiceLbPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGatewayRouteViewRequest(ref GetGatewayRouteViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMeshRouteViewRequest(ref GetMeshRouteViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGatewayRouteViewsRequest(ref ListGatewayRouteViewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMeshRouteViewsRequest(ref ListMeshRouteViewsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>(_callListEndpointPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>(_callListEndpointPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EndpointPolicy GetEndpointPolicy(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointPolicyRequest(ref request, ref callSettings);
            return _callGetEndpointPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EndpointPolicy> GetEndpointPolicyAsync(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointPolicyRequest(ref request, ref callSettings);
            return _callGetEndpointPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEndpointPolicy</c>.</summary>
        public override lro::OperationsClient CreateEndpointPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(_callCreateEndpointPolicy.Sync(request, callSettings), CreateEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(await _callCreateEndpointPolicy.Async(request, callSettings).ConfigureAwait(false), CreateEndpointPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEndpointPolicy</c>.</summary>
        public override lro::OperationsClient UpdateEndpointPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EndpointPolicy, OperationMetadata> UpdateEndpointPolicy(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(_callUpdateEndpointPolicy.Sync(request, callSettings), UpdateEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(await _callUpdateEndpointPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateEndpointPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEndpointPolicy</c>.</summary>
        public override lro::OperationsClient DeleteEndpointPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEndpointPolicy.Sync(request, callSettings), DeleteEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEndpointPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public override gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGatewaysRequest, ListGatewaysResponse, Gateway>(_callListGateways, request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGatewaysRequest, ListGatewaysResponse, Gateway>(_callListGateways, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Gateway GetGateway(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewayRequest(ref request, ref callSettings);
            return _callGetGateway.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Gateway> GetGatewayAsync(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewayRequest(ref request, ref callSettings);
            return _callGetGateway.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGateway</c>.</summary>
        public override lro::OperationsClient CreateGatewayOperationsClient { get; }

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Gateway, OperationMetadata> CreateGateway(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(_callCreateGateway.Sync(request, callSettings), CreateGatewayOperationsClient);
        }

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(await _callCreateGateway.Async(request, callSettings).ConfigureAwait(false), CreateGatewayOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGateway</c>.</summary>
        public override lro::OperationsClient UpdateGatewayOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Gateway, OperationMetadata> UpdateGateway(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(_callUpdateGateway.Sync(request, callSettings), UpdateGatewayOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(await _callUpdateGateway.Async(request, callSettings).ConfigureAwait(false), UpdateGatewayOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGateway</c>.</summary>
        public override lro::OperationsClient DeleteGatewayOperationsClient { get; }

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGateway.Sync(request, callSettings), DeleteGatewayOperationsClient);
        }

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGateway.Async(request, callSettings).ConfigureAwait(false), DeleteGatewayOperationsClient);
        }

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GrpcRoute"/> resources.</returns>
        public override gax::PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutes(ListGrpcRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGrpcRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGrpcRoutesRequest, ListGrpcRoutesResponse, GrpcRoute>(_callListGrpcRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists GrpcRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GrpcRoute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> ListGrpcRoutesAsync(ListGrpcRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGrpcRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGrpcRoutesRequest, ListGrpcRoutesResponse, GrpcRoute>(_callListGrpcRoutes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GrpcRoute GetGrpcRoute(GetGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGrpcRouteRequest(ref request, ref callSettings);
            return _callGetGrpcRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GrpcRoute> GetGrpcRouteAsync(GetGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGrpcRouteRequest(ref request, ref callSettings);
            return _callGetGrpcRoute.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGrpcRoute</c>.</summary>
        public override lro::OperationsClient CreateGrpcRouteOperationsClient { get; }

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GrpcRoute, OperationMetadata> CreateGrpcRoute(CreateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGrpcRouteRequest(ref request, ref callSettings);
            return new lro::Operation<GrpcRoute, OperationMetadata>(_callCreateGrpcRoute.Sync(request, callSettings), CreateGrpcRouteOperationsClient);
        }

        /// <summary>
        /// Creates a new GrpcRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> CreateGrpcRouteAsync(CreateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGrpcRouteRequest(ref request, ref callSettings);
            return new lro::Operation<GrpcRoute, OperationMetadata>(await _callCreateGrpcRoute.Async(request, callSettings).ConfigureAwait(false), CreateGrpcRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGrpcRoute</c>.</summary>
        public override lro::OperationsClient UpdateGrpcRouteOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GrpcRoute, OperationMetadata> UpdateGrpcRoute(UpdateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGrpcRouteRequest(ref request, ref callSettings);
            return new lro::Operation<GrpcRoute, OperationMetadata>(_callUpdateGrpcRoute.Sync(request, callSettings), UpdateGrpcRouteOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GrpcRoute, OperationMetadata>> UpdateGrpcRouteAsync(UpdateGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGrpcRouteRequest(ref request, ref callSettings);
            return new lro::Operation<GrpcRoute, OperationMetadata>(await _callUpdateGrpcRoute.Async(request, callSettings).ConfigureAwait(false), UpdateGrpcRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGrpcRoute</c>.</summary>
        public override lro::OperationsClient DeleteGrpcRouteOperationsClient { get; }

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGrpcRoute(DeleteGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGrpcRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGrpcRoute.Sync(request, callSettings), DeleteGrpcRouteOperationsClient);
        }

        /// <summary>
        /// Deletes a single GrpcRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGrpcRouteAsync(DeleteGrpcRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGrpcRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGrpcRoute.Async(request, callSettings).ConfigureAwait(false), DeleteGrpcRouteOperationsClient);
        }

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HttpRoute"/> resources.</returns>
        public override gax::PagedEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutes(ListHttpRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHttpRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHttpRoutesRequest, ListHttpRoutesResponse, HttpRoute>(_callListHttpRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HttpRoute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> ListHttpRoutesAsync(ListHttpRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHttpRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHttpRoutesRequest, ListHttpRoutesResponse, HttpRoute>(_callListHttpRoutes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HttpRoute GetHttpRoute(GetHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHttpRouteRequest(ref request, ref callSettings);
            return _callGetHttpRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HttpRoute> GetHttpRouteAsync(GetHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHttpRouteRequest(ref request, ref callSettings);
            return _callGetHttpRoute.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateHttpRoute</c>.</summary>
        public override lro::OperationsClient CreateHttpRouteOperationsClient { get; }

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<HttpRoute, OperationMetadata> CreateHttpRoute(CreateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHttpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<HttpRoute, OperationMetadata>(_callCreateHttpRoute.Sync(request, callSettings), CreateHttpRouteOperationsClient);
        }

        /// <summary>
        /// Creates a new HttpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<HttpRoute, OperationMetadata>> CreateHttpRouteAsync(CreateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHttpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<HttpRoute, OperationMetadata>(await _callCreateHttpRoute.Async(request, callSettings).ConfigureAwait(false), CreateHttpRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateHttpRoute</c>.</summary>
        public override lro::OperationsClient UpdateHttpRouteOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<HttpRoute, OperationMetadata> UpdateHttpRoute(UpdateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHttpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<HttpRoute, OperationMetadata>(_callUpdateHttpRoute.Sync(request, callSettings), UpdateHttpRouteOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<HttpRoute, OperationMetadata>> UpdateHttpRouteAsync(UpdateHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHttpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<HttpRoute, OperationMetadata>(await _callUpdateHttpRoute.Async(request, callSettings).ConfigureAwait(false), UpdateHttpRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteHttpRoute</c>.</summary>
        public override lro::OperationsClient DeleteHttpRouteOperationsClient { get; }

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteHttpRoute(DeleteHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHttpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteHttpRoute.Sync(request, callSettings), DeleteHttpRouteOperationsClient);
        }

        /// <summary>
        /// Deletes a single HttpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHttpRouteAsync(DeleteHttpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHttpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteHttpRoute.Async(request, callSettings).ConfigureAwait(false), DeleteHttpRouteOperationsClient);
        }

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TcpRoute"/> resources.</returns>
        public override gax::PagedEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutes(ListTcpRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTcpRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTcpRoutesRequest, ListTcpRoutesResponse, TcpRoute>(_callListTcpRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TcpRoute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> ListTcpRoutesAsync(ListTcpRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTcpRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTcpRoutesRequest, ListTcpRoutesResponse, TcpRoute>(_callListTcpRoutes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TcpRoute GetTcpRoute(GetTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTcpRouteRequest(ref request, ref callSettings);
            return _callGetTcpRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TcpRoute> GetTcpRouteAsync(GetTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTcpRouteRequest(ref request, ref callSettings);
            return _callGetTcpRoute.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTcpRoute</c>.</summary>
        public override lro::OperationsClient CreateTcpRouteOperationsClient { get; }

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TcpRoute, OperationMetadata> CreateTcpRoute(CreateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTcpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TcpRoute, OperationMetadata>(_callCreateTcpRoute.Sync(request, callSettings), CreateTcpRouteOperationsClient);
        }

        /// <summary>
        /// Creates a new TcpRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TcpRoute, OperationMetadata>> CreateTcpRouteAsync(CreateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTcpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TcpRoute, OperationMetadata>(await _callCreateTcpRoute.Async(request, callSettings).ConfigureAwait(false), CreateTcpRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTcpRoute</c>.</summary>
        public override lro::OperationsClient UpdateTcpRouteOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TcpRoute, OperationMetadata> UpdateTcpRoute(UpdateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTcpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TcpRoute, OperationMetadata>(_callUpdateTcpRoute.Sync(request, callSettings), UpdateTcpRouteOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TcpRoute, OperationMetadata>> UpdateTcpRouteAsync(UpdateTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTcpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TcpRoute, OperationMetadata>(await _callUpdateTcpRoute.Async(request, callSettings).ConfigureAwait(false), UpdateTcpRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTcpRoute</c>.</summary>
        public override lro::OperationsClient DeleteTcpRouteOperationsClient { get; }

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTcpRoute(DeleteTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTcpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTcpRoute.Sync(request, callSettings), DeleteTcpRouteOperationsClient);
        }

        /// <summary>
        /// Deletes a single TcpRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTcpRouteAsync(DeleteTcpRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTcpRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTcpRoute.Async(request, callSettings).ConfigureAwait(false), DeleteTcpRouteOperationsClient);
        }

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TlsRoute"/> resources.</returns>
        public override gax::PagedEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutes(ListTlsRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTlsRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTlsRoutesRequest, ListTlsRoutesResponse, TlsRoute>(_callListTlsRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TlsRoute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> ListTlsRoutesAsync(ListTlsRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTlsRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTlsRoutesRequest, ListTlsRoutesResponse, TlsRoute>(_callListTlsRoutes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TlsRoute GetTlsRoute(GetTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTlsRouteRequest(ref request, ref callSettings);
            return _callGetTlsRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TlsRoute> GetTlsRouteAsync(GetTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTlsRouteRequest(ref request, ref callSettings);
            return _callGetTlsRoute.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTlsRoute</c>.</summary>
        public override lro::OperationsClient CreateTlsRouteOperationsClient { get; }

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TlsRoute, OperationMetadata> CreateTlsRoute(CreateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTlsRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TlsRoute, OperationMetadata>(_callCreateTlsRoute.Sync(request, callSettings), CreateTlsRouteOperationsClient);
        }

        /// <summary>
        /// Creates a new TlsRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TlsRoute, OperationMetadata>> CreateTlsRouteAsync(CreateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTlsRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TlsRoute, OperationMetadata>(await _callCreateTlsRoute.Async(request, callSettings).ConfigureAwait(false), CreateTlsRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTlsRoute</c>.</summary>
        public override lro::OperationsClient UpdateTlsRouteOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TlsRoute, OperationMetadata> UpdateTlsRoute(UpdateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTlsRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TlsRoute, OperationMetadata>(_callUpdateTlsRoute.Sync(request, callSettings), UpdateTlsRouteOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TlsRoute, OperationMetadata>> UpdateTlsRouteAsync(UpdateTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTlsRouteRequest(ref request, ref callSettings);
            return new lro::Operation<TlsRoute, OperationMetadata>(await _callUpdateTlsRoute.Async(request, callSettings).ConfigureAwait(false), UpdateTlsRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTlsRoute</c>.</summary>
        public override lro::OperationsClient DeleteTlsRouteOperationsClient { get; }

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsRoute(DeleteTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTlsRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTlsRoute.Sync(request, callSettings), DeleteTlsRouteOperationsClient);
        }

        /// <summary>
        /// Deletes a single TlsRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsRouteAsync(DeleteTlsRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTlsRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTlsRoute.Async(request, callSettings).ConfigureAwait(false), DeleteTlsRouteOperationsClient);
        }

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindings(ListServiceBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceBindingsRequest, ListServiceBindingsResponse, ServiceBinding>(_callListServiceBindings, request, callSettings);
        }

        /// <summary>
        /// Lists ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> ListServiceBindingsAsync(ListServiceBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceBindingsRequest, ListServiceBindingsResponse, ServiceBinding>(_callListServiceBindings, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceBinding GetServiceBinding(GetServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceBindingRequest(ref request, ref callSettings);
            return _callGetServiceBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceBinding> GetServiceBindingAsync(GetServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceBindingRequest(ref request, ref callSettings);
            return _callGetServiceBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceBinding</c>.</summary>
        public override lro::OperationsClient CreateServiceBindingOperationsClient { get; }

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceBinding, OperationMetadata> CreateServiceBinding(CreateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceBindingRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceBinding, OperationMetadata>(_callCreateServiceBinding.Sync(request, callSettings), CreateServiceBindingOperationsClient);
        }

        /// <summary>
        /// Creates a new ServiceBinding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> CreateServiceBindingAsync(CreateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceBindingRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceBinding, OperationMetadata>(await _callCreateServiceBinding.Async(request, callSettings).ConfigureAwait(false), CreateServiceBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServiceBinding</c>.</summary>
        public override lro::OperationsClient UpdateServiceBindingOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceBinding, OperationMetadata> UpdateServiceBinding(UpdateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceBindingRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceBinding, OperationMetadata>(_callUpdateServiceBinding.Sync(request, callSettings), UpdateServiceBindingOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceBinding, OperationMetadata>> UpdateServiceBindingAsync(UpdateServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceBindingRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceBinding, OperationMetadata>(await _callUpdateServiceBinding.Async(request, callSettings).ConfigureAwait(false), UpdateServiceBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceBinding</c>.</summary>
        public override lro::OperationsClient DeleteServiceBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceBinding(DeleteServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceBinding.Sync(request, callSettings), DeleteServiceBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServiceBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceBindingAsync(DeleteServiceBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceBinding.Async(request, callSettings).ConfigureAwait(false), DeleteServiceBindingOperationsClient);
        }

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Mesh"/> resources.</returns>
        public override gax::PagedEnumerable<ListMeshesResponse, Mesh> ListMeshes(ListMeshesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMeshesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMeshesRequest, ListMeshesResponse, Mesh>(_callListMeshes, request, callSettings);
        }

        /// <summary>
        /// Lists Meshes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Mesh"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMeshesResponse, Mesh> ListMeshesAsync(ListMeshesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMeshesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMeshesRequest, ListMeshesResponse, Mesh>(_callListMeshes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Mesh GetMesh(GetMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMeshRequest(ref request, ref callSettings);
            return _callGetMesh.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Mesh> GetMeshAsync(GetMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMeshRequest(ref request, ref callSettings);
            return _callGetMesh.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMesh</c>.</summary>
        public override lro::OperationsClient CreateMeshOperationsClient { get; }

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Mesh, OperationMetadata> CreateMesh(CreateMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMeshRequest(ref request, ref callSettings);
            return new lro::Operation<Mesh, OperationMetadata>(_callCreateMesh.Sync(request, callSettings), CreateMeshOperationsClient);
        }

        /// <summary>
        /// Creates a new Mesh in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Mesh, OperationMetadata>> CreateMeshAsync(CreateMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMeshRequest(ref request, ref callSettings);
            return new lro::Operation<Mesh, OperationMetadata>(await _callCreateMesh.Async(request, callSettings).ConfigureAwait(false), CreateMeshOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMesh</c>.</summary>
        public override lro::OperationsClient UpdateMeshOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Mesh, OperationMetadata> UpdateMesh(UpdateMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMeshRequest(ref request, ref callSettings);
            return new lro::Operation<Mesh, OperationMetadata>(_callUpdateMesh.Sync(request, callSettings), UpdateMeshOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Mesh, OperationMetadata>> UpdateMeshAsync(UpdateMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMeshRequest(ref request, ref callSettings);
            return new lro::Operation<Mesh, OperationMetadata>(await _callUpdateMesh.Async(request, callSettings).ConfigureAwait(false), UpdateMeshOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMesh</c>.</summary>
        public override lro::OperationsClient DeleteMeshOperationsClient { get; }

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMesh(DeleteMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMeshRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMesh.Sync(request, callSettings), DeleteMeshOperationsClient);
        }

        /// <summary>
        /// Deletes a single Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMeshAsync(DeleteMeshRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMeshRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMesh.Async(request, callSettings).ConfigureAwait(false), DeleteMeshOperationsClient);
        }

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPolicies(ListServiceLbPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceLbPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceLbPoliciesRequest, ListServiceLbPoliciesResponse, ServiceLbPolicy>(_callListServiceLbPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists ServiceLbPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLbPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> ListServiceLbPoliciesAsync(ListServiceLbPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceLbPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceLbPoliciesRequest, ListServiceLbPoliciesResponse, ServiceLbPolicy>(_callListServiceLbPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceLbPolicy GetServiceLbPolicy(GetServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceLbPolicyRequest(ref request, ref callSettings);
            return _callGetServiceLbPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceLbPolicy> GetServiceLbPolicyAsync(GetServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceLbPolicyRequest(ref request, ref callSettings);
            return _callGetServiceLbPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceLbPolicy</c>.</summary>
        public override lro::OperationsClient CreateServiceLbPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceLbPolicy, OperationMetadata> CreateServiceLbPolicy(CreateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceLbPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceLbPolicy, OperationMetadata>(_callCreateServiceLbPolicy.Sync(request, callSettings), CreateServiceLbPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new ServiceLbPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> CreateServiceLbPolicyAsync(CreateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceLbPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceLbPolicy, OperationMetadata>(await _callCreateServiceLbPolicy.Async(request, callSettings).ConfigureAwait(false), CreateServiceLbPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServiceLbPolicy</c>.</summary>
        public override lro::OperationsClient UpdateServiceLbPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceLbPolicy, OperationMetadata> UpdateServiceLbPolicy(UpdateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceLbPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceLbPolicy, OperationMetadata>(_callUpdateServiceLbPolicy.Sync(request, callSettings), UpdateServiceLbPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceLbPolicy, OperationMetadata>> UpdateServiceLbPolicyAsync(UpdateServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceLbPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceLbPolicy, OperationMetadata>(await _callUpdateServiceLbPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateServiceLbPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceLbPolicy</c>.</summary>
        public override lro::OperationsClient DeleteServiceLbPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceLbPolicy(DeleteServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceLbPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceLbPolicy.Sync(request, callSettings), DeleteServiceLbPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServiceLbPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceLbPolicyAsync(DeleteServiceLbPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceLbPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceLbPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteServiceLbPolicyOperationsClient);
        }

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GatewayRouteView GetGatewayRouteView(GetGatewayRouteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewayRouteViewRequest(ref request, ref callSettings);
            return _callGetGatewayRouteView.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single RouteView of a Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GatewayRouteView> GetGatewayRouteViewAsync(GetGatewayRouteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewayRouteViewRequest(ref request, ref callSettings);
            return _callGetGatewayRouteView.Async(request, callSettings);
        }

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MeshRouteView GetMeshRouteView(GetMeshRouteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMeshRouteViewRequest(ref request, ref callSettings);
            return _callGetMeshRouteView.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single RouteView of a Mesh.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MeshRouteView> GetMeshRouteViewAsync(GetMeshRouteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMeshRouteViewRequest(ref request, ref callSettings);
            return _callGetMeshRouteView.Async(request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public override gax::PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViews(ListGatewayRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewayRouteViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGatewayRouteViewsRequest, ListGatewayRouteViewsResponse, GatewayRouteView>(_callListGatewayRouteViews, request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GatewayRouteView"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> ListGatewayRouteViewsAsync(ListGatewayRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewayRouteViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGatewayRouteViewsRequest, ListGatewayRouteViewsResponse, GatewayRouteView>(_callListGatewayRouteViews, request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MeshRouteView"/> resources.</returns>
        public override gax::PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViews(ListMeshRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMeshRouteViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMeshRouteViewsRequest, ListMeshRouteViewsResponse, MeshRouteView>(_callListMeshRouteViews, request, callSettings);
        }

        /// <summary>
        /// Lists RouteViews
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MeshRouteView"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> ListMeshRouteViewsAsync(ListMeshRouteViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMeshRouteViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMeshRouteViewsRequest, ListMeshRouteViewsResponse, MeshRouteView>(_callListMeshRouteViews, request, callSettings);
        }
    }

    public partial class ListEndpointPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGatewaysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGrpcRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHttpRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTcpRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTlsRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMeshesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceLbPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGatewayRouteViewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMeshRouteViewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEndpointPoliciesResponse : gaxgrpc::IPageResponse<EndpointPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EndpointPolicy> GetEnumerator() => EndpointPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGatewaysResponse : gaxgrpc::IPageResponse<Gateway>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Gateway> GetEnumerator() => Gateways.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGrpcRoutesResponse : gaxgrpc::IPageResponse<GrpcRoute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GrpcRoute> GetEnumerator() => GrpcRoutes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHttpRoutesResponse : gaxgrpc::IPageResponse<HttpRoute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HttpRoute> GetEnumerator() => HttpRoutes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTcpRoutesResponse : gaxgrpc::IPageResponse<TcpRoute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TcpRoute> GetEnumerator() => TcpRoutes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTlsRoutesResponse : gaxgrpc::IPageResponse<TlsRoute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TlsRoute> GetEnumerator() => TlsRoutes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceBindingsResponse : gaxgrpc::IPageResponse<ServiceBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceBinding> GetEnumerator() => ServiceBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMeshesResponse : gaxgrpc::IPageResponse<Mesh>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Mesh> GetEnumerator() => Meshes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceLbPoliciesResponse : gaxgrpc::IPageResponse<ServiceLbPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceLbPolicy> GetEnumerator() => ServiceLbPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGatewayRouteViewsResponse : gaxgrpc::IPageResponse<GatewayRouteView>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GatewayRouteView> GetEnumerator() => GatewayRouteViews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMeshRouteViewsResponse : gaxgrpc::IPageResponse<MeshRouteView>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MeshRouteView> GetEnumerator() => MeshRouteViews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NetworkServices
    {
        public partial class NetworkServicesClient
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

    public static partial class NetworkServices
    {
        public partial class NetworkServicesClient
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
