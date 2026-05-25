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

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Settings for <see cref="NetworkSecurityClient"/> instances.</summary>
    public sealed partial class NetworkSecuritySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetworkSecuritySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetworkSecuritySettings"/>.</returns>
        public static NetworkSecuritySettings GetDefault() => new NetworkSecuritySettings();

        /// <summary>Constructs a new <see cref="NetworkSecuritySettings"/> object with default settings.</summary>
        public NetworkSecuritySettings()
        {
        }

        private NetworkSecuritySettings(NetworkSecuritySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAuthorizationPoliciesSettings = existing.ListAuthorizationPoliciesSettings;
            GetAuthorizationPolicySettings = existing.GetAuthorizationPolicySettings;
            CreateAuthorizationPolicySettings = existing.CreateAuthorizationPolicySettings;
            CreateAuthorizationPolicyOperationsSettings = existing.CreateAuthorizationPolicyOperationsSettings.Clone();
            UpdateAuthorizationPolicySettings = existing.UpdateAuthorizationPolicySettings;
            UpdateAuthorizationPolicyOperationsSettings = existing.UpdateAuthorizationPolicyOperationsSettings.Clone();
            DeleteAuthorizationPolicySettings = existing.DeleteAuthorizationPolicySettings;
            DeleteAuthorizationPolicyOperationsSettings = existing.DeleteAuthorizationPolicyOperationsSettings.Clone();
            ListBackendAuthenticationConfigsSettings = existing.ListBackendAuthenticationConfigsSettings;
            GetBackendAuthenticationConfigSettings = existing.GetBackendAuthenticationConfigSettings;
            CreateBackendAuthenticationConfigSettings = existing.CreateBackendAuthenticationConfigSettings;
            CreateBackendAuthenticationConfigOperationsSettings = existing.CreateBackendAuthenticationConfigOperationsSettings.Clone();
            UpdateBackendAuthenticationConfigSettings = existing.UpdateBackendAuthenticationConfigSettings;
            UpdateBackendAuthenticationConfigOperationsSettings = existing.UpdateBackendAuthenticationConfigOperationsSettings.Clone();
            DeleteBackendAuthenticationConfigSettings = existing.DeleteBackendAuthenticationConfigSettings;
            DeleteBackendAuthenticationConfigOperationsSettings = existing.DeleteBackendAuthenticationConfigOperationsSettings.Clone();
            ListServerTlsPoliciesSettings = existing.ListServerTlsPoliciesSettings;
            GetServerTlsPolicySettings = existing.GetServerTlsPolicySettings;
            CreateServerTlsPolicySettings = existing.CreateServerTlsPolicySettings;
            CreateServerTlsPolicyOperationsSettings = existing.CreateServerTlsPolicyOperationsSettings.Clone();
            UpdateServerTlsPolicySettings = existing.UpdateServerTlsPolicySettings;
            UpdateServerTlsPolicyOperationsSettings = existing.UpdateServerTlsPolicyOperationsSettings.Clone();
            DeleteServerTlsPolicySettings = existing.DeleteServerTlsPolicySettings;
            DeleteServerTlsPolicyOperationsSettings = existing.DeleteServerTlsPolicyOperationsSettings.Clone();
            ListClientTlsPoliciesSettings = existing.ListClientTlsPoliciesSettings;
            GetClientTlsPolicySettings = existing.GetClientTlsPolicySettings;
            CreateClientTlsPolicySettings = existing.CreateClientTlsPolicySettings;
            CreateClientTlsPolicyOperationsSettings = existing.CreateClientTlsPolicyOperationsSettings.Clone();
            UpdateClientTlsPolicySettings = existing.UpdateClientTlsPolicySettings;
            UpdateClientTlsPolicyOperationsSettings = existing.UpdateClientTlsPolicyOperationsSettings.Clone();
            DeleteClientTlsPolicySettings = existing.DeleteClientTlsPolicySettings;
            DeleteClientTlsPolicyOperationsSettings = existing.DeleteClientTlsPolicyOperationsSettings.Clone();
            ListGatewaySecurityPoliciesSettings = existing.ListGatewaySecurityPoliciesSettings;
            GetGatewaySecurityPolicySettings = existing.GetGatewaySecurityPolicySettings;
            CreateGatewaySecurityPolicySettings = existing.CreateGatewaySecurityPolicySettings;
            CreateGatewaySecurityPolicyOperationsSettings = existing.CreateGatewaySecurityPolicyOperationsSettings.Clone();
            UpdateGatewaySecurityPolicySettings = existing.UpdateGatewaySecurityPolicySettings;
            UpdateGatewaySecurityPolicyOperationsSettings = existing.UpdateGatewaySecurityPolicyOperationsSettings.Clone();
            DeleteGatewaySecurityPolicySettings = existing.DeleteGatewaySecurityPolicySettings;
            DeleteGatewaySecurityPolicyOperationsSettings = existing.DeleteGatewaySecurityPolicyOperationsSettings.Clone();
            ListGatewaySecurityPolicyRulesSettings = existing.ListGatewaySecurityPolicyRulesSettings;
            GetGatewaySecurityPolicyRuleSettings = existing.GetGatewaySecurityPolicyRuleSettings;
            CreateGatewaySecurityPolicyRuleSettings = existing.CreateGatewaySecurityPolicyRuleSettings;
            CreateGatewaySecurityPolicyRuleOperationsSettings = existing.CreateGatewaySecurityPolicyRuleOperationsSettings.Clone();
            UpdateGatewaySecurityPolicyRuleSettings = existing.UpdateGatewaySecurityPolicyRuleSettings;
            UpdateGatewaySecurityPolicyRuleOperationsSettings = existing.UpdateGatewaySecurityPolicyRuleOperationsSettings.Clone();
            DeleteGatewaySecurityPolicyRuleSettings = existing.DeleteGatewaySecurityPolicyRuleSettings;
            DeleteGatewaySecurityPolicyRuleOperationsSettings = existing.DeleteGatewaySecurityPolicyRuleOperationsSettings.Clone();
            ListUrlListsSettings = existing.ListUrlListsSettings;
            GetUrlListSettings = existing.GetUrlListSettings;
            CreateUrlListSettings = existing.CreateUrlListSettings;
            CreateUrlListOperationsSettings = existing.CreateUrlListOperationsSettings.Clone();
            UpdateUrlListSettings = existing.UpdateUrlListSettings;
            UpdateUrlListOperationsSettings = existing.UpdateUrlListOperationsSettings.Clone();
            DeleteUrlListSettings = existing.DeleteUrlListSettings;
            DeleteUrlListOperationsSettings = existing.DeleteUrlListOperationsSettings.Clone();
            ListTlsInspectionPoliciesSettings = existing.ListTlsInspectionPoliciesSettings;
            GetTlsInspectionPolicySettings = existing.GetTlsInspectionPolicySettings;
            CreateTlsInspectionPolicySettings = existing.CreateTlsInspectionPolicySettings;
            CreateTlsInspectionPolicyOperationsSettings = existing.CreateTlsInspectionPolicyOperationsSettings.Clone();
            UpdateTlsInspectionPolicySettings = existing.UpdateTlsInspectionPolicySettings;
            UpdateTlsInspectionPolicyOperationsSettings = existing.UpdateTlsInspectionPolicyOperationsSettings.Clone();
            DeleteTlsInspectionPolicySettings = existing.DeleteTlsInspectionPolicySettings;
            DeleteTlsInspectionPolicyOperationsSettings = existing.DeleteTlsInspectionPolicyOperationsSettings.Clone();
            ListAuthzPoliciesSettings = existing.ListAuthzPoliciesSettings;
            GetAuthzPolicySettings = existing.GetAuthzPolicySettings;
            CreateAuthzPolicySettings = existing.CreateAuthzPolicySettings;
            CreateAuthzPolicyOperationsSettings = existing.CreateAuthzPolicyOperationsSettings.Clone();
            UpdateAuthzPolicySettings = existing.UpdateAuthzPolicySettings;
            UpdateAuthzPolicyOperationsSettings = existing.UpdateAuthzPolicyOperationsSettings.Clone();
            DeleteAuthzPolicySettings = existing.DeleteAuthzPolicySettings;
            DeleteAuthzPolicyOperationsSettings = existing.DeleteAuthzPolicyOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetworkSecuritySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListAuthorizationPolicies</c> and
        /// <c>NetworkSecurityClient.ListAuthorizationPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAuthorizationPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetAuthorizationPolicy</c> and <c>NetworkSecurityClient.GetAuthorizationPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAuthorizationPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateAuthorizationPolicy</c> and
        /// <c>NetworkSecurityClient.CreateAuthorizationPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAuthorizationPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateAuthorizationPolicy</c> and
        /// <c>NetworkSecurityClient.CreateAuthorizationPolicyAsync</c>.
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
        public lro::OperationsSettings CreateAuthorizationPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateAuthorizationPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateAuthorizationPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAuthorizationPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateAuthorizationPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateAuthorizationPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateAuthorizationPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteAuthorizationPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteAuthorizationPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAuthorizationPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteAuthorizationPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteAuthorizationPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteAuthorizationPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListBackendAuthenticationConfigs</c> and
        /// <c>NetworkSecurityClient.ListBackendAuthenticationConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackendAuthenticationConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetBackendAuthenticationConfig</c> and
        /// <c>NetworkSecurityClient.GetBackendAuthenticationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackendAuthenticationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateBackendAuthenticationConfig</c> and
        /// <c>NetworkSecurityClient.CreateBackendAuthenticationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackendAuthenticationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateBackendAuthenticationConfig</c>
        /// and <c>NetworkSecurityClient.CreateBackendAuthenticationConfigAsync</c>.
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
        public lro::OperationsSettings CreateBackendAuthenticationConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateBackendAuthenticationConfig</c> and
        /// <c>NetworkSecurityClient.UpdateBackendAuthenticationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackendAuthenticationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateBackendAuthenticationConfig</c>
        /// and <c>NetworkSecurityClient.UpdateBackendAuthenticationConfigAsync</c>.
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
        public lro::OperationsSettings UpdateBackendAuthenticationConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteBackendAuthenticationConfig</c> and
        /// <c>NetworkSecurityClient.DeleteBackendAuthenticationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackendAuthenticationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteBackendAuthenticationConfig</c>
        /// and <c>NetworkSecurityClient.DeleteBackendAuthenticationConfigAsync</c>.
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
        public lro::OperationsSettings DeleteBackendAuthenticationConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListServerTlsPolicies</c> and <c>NetworkSecurityClient.ListServerTlsPoliciesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServerTlsPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetServerTlsPolicy</c> and <c>NetworkSecurityClient.GetServerTlsPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServerTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateServerTlsPolicy</c> and <c>NetworkSecurityClient.CreateServerTlsPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServerTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateServerTlsPolicy</c> and
        /// <c>NetworkSecurityClient.CreateServerTlsPolicyAsync</c>.
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
        public lro::OperationsSettings CreateServerTlsPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateServerTlsPolicy</c> and <c>NetworkSecurityClient.UpdateServerTlsPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServerTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateServerTlsPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateServerTlsPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateServerTlsPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteServerTlsPolicy</c> and <c>NetworkSecurityClient.DeleteServerTlsPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServerTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteServerTlsPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteServerTlsPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteServerTlsPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListClientTlsPolicies</c> and <c>NetworkSecurityClient.ListClientTlsPoliciesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClientTlsPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetClientTlsPolicy</c> and <c>NetworkSecurityClient.GetClientTlsPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClientTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateClientTlsPolicy</c> and <c>NetworkSecurityClient.CreateClientTlsPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClientTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateClientTlsPolicy</c> and
        /// <c>NetworkSecurityClient.CreateClientTlsPolicyAsync</c>.
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
        public lro::OperationsSettings CreateClientTlsPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateClientTlsPolicy</c> and <c>NetworkSecurityClient.UpdateClientTlsPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClientTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateClientTlsPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateClientTlsPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateClientTlsPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteClientTlsPolicy</c> and <c>NetworkSecurityClient.DeleteClientTlsPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClientTlsPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteClientTlsPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteClientTlsPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteClientTlsPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListGatewaySecurityPolicies</c> and
        /// <c>NetworkSecurityClient.ListGatewaySecurityPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGatewaySecurityPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.GetGatewaySecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGatewaySecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.CreateGatewaySecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGatewaySecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.CreateGatewaySecurityPolicyAsync</c>.
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
        public lro::OperationsSettings CreateGatewaySecurityPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateGatewaySecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGatewaySecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateGatewaySecurityPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateGatewaySecurityPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteGatewaySecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGatewaySecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteGatewaySecurityPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteGatewaySecurityPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteGatewaySecurityPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListGatewaySecurityPolicyRules</c> and
        /// <c>NetworkSecurityClient.ListGatewaySecurityPolicyRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGatewaySecurityPolicyRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetGatewaySecurityPolicyRule</c> and
        /// <c>NetworkSecurityClient.GetGatewaySecurityPolicyRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGatewaySecurityPolicyRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateGatewaySecurityPolicyRule</c> and
        /// <c>NetworkSecurityClient.CreateGatewaySecurityPolicyRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGatewaySecurityPolicyRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateGatewaySecurityPolicyRule</c>
        /// and <c>NetworkSecurityClient.CreateGatewaySecurityPolicyRuleAsync</c>.
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
        public lro::OperationsSettings CreateGatewaySecurityPolicyRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateGatewaySecurityPolicyRule</c> and
        /// <c>NetworkSecurityClient.UpdateGatewaySecurityPolicyRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGatewaySecurityPolicyRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateGatewaySecurityPolicyRule</c>
        /// and <c>NetworkSecurityClient.UpdateGatewaySecurityPolicyRuleAsync</c>.
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
        public lro::OperationsSettings UpdateGatewaySecurityPolicyRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteGatewaySecurityPolicyRule</c> and
        /// <c>NetworkSecurityClient.DeleteGatewaySecurityPolicyRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGatewaySecurityPolicyRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteGatewaySecurityPolicyRule</c>
        /// and <c>NetworkSecurityClient.DeleteGatewaySecurityPolicyRuleAsync</c>.
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
        public lro::OperationsSettings DeleteGatewaySecurityPolicyRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListUrlLists</c> and <c>NetworkSecurityClient.ListUrlListsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUrlListsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetUrlList</c> and <c>NetworkSecurityClient.GetUrlListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUrlListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateUrlList</c> and <c>NetworkSecurityClient.CreateUrlListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUrlListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateUrlList</c> and
        /// <c>NetworkSecurityClient.CreateUrlListAsync</c>.
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
        public lro::OperationsSettings CreateUrlListOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateUrlList</c> and <c>NetworkSecurityClient.UpdateUrlListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUrlListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateUrlList</c> and
        /// <c>NetworkSecurityClient.UpdateUrlListAsync</c>.
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
        public lro::OperationsSettings UpdateUrlListOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteUrlList</c> and <c>NetworkSecurityClient.DeleteUrlListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUrlListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteUrlList</c> and
        /// <c>NetworkSecurityClient.DeleteUrlListAsync</c>.
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
        public lro::OperationsSettings DeleteUrlListOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListTlsInspectionPolicies</c> and
        /// <c>NetworkSecurityClient.ListTlsInspectionPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTlsInspectionPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetTlsInspectionPolicy</c> and <c>NetworkSecurityClient.GetTlsInspectionPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTlsInspectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateTlsInspectionPolicy</c> and
        /// <c>NetworkSecurityClient.CreateTlsInspectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTlsInspectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateTlsInspectionPolicy</c> and
        /// <c>NetworkSecurityClient.CreateTlsInspectionPolicyAsync</c>.
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
        public lro::OperationsSettings CreateTlsInspectionPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateTlsInspectionPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateTlsInspectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTlsInspectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateTlsInspectionPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateTlsInspectionPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateTlsInspectionPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteTlsInspectionPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteTlsInspectionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTlsInspectionPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteTlsInspectionPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteTlsInspectionPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteTlsInspectionPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.ListAuthzPolicies</c> and <c>NetworkSecurityClient.ListAuthzPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAuthzPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.GetAuthzPolicy</c> and <c>NetworkSecurityClient.GetAuthzPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAuthzPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.CreateAuthzPolicy</c> and <c>NetworkSecurityClient.CreateAuthzPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAuthzPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.CreateAuthzPolicy</c> and
        /// <c>NetworkSecurityClient.CreateAuthzPolicyAsync</c>.
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
        public lro::OperationsSettings CreateAuthzPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.UpdateAuthzPolicy</c> and <c>NetworkSecurityClient.UpdateAuthzPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAuthzPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.UpdateAuthzPolicy</c> and
        /// <c>NetworkSecurityClient.UpdateAuthzPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateAuthzPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkSecurityClient.DeleteAuthzPolicy</c> and <c>NetworkSecurityClient.DeleteAuthzPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAuthzPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkSecurityClient.DeleteAuthzPolicy</c> and
        /// <c>NetworkSecurityClient.DeleteAuthzPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteAuthzPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="NetworkSecuritySettings"/> object.</returns>
        public NetworkSecuritySettings Clone() => new NetworkSecuritySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetworkSecurityClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NetworkSecurityClientBuilder : gaxgrpc::ClientBuilderBase<NetworkSecurityClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetworkSecuritySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetworkSecurityClientBuilder() : base(NetworkSecurityClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetworkSecurityClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetworkSecurityClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetworkSecurityClient Build()
        {
            NetworkSecurityClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetworkSecurityClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetworkSecurityClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetworkSecurityClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetworkSecurityClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetworkSecurityClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetworkSecurityClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetworkSecurityClient.ChannelPool;
    }

    /// <summary>NetworkSecurity client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Network Security API provides resources to configure authentication and
    /// authorization policies. Refer to per API resource documentation for more
    /// information.
    /// </remarks>
    public abstract partial class NetworkSecurityClient
    {
        /// <summary>
        /// The default endpoint for the NetworkSecurity service, which is a host of "networksecurity.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default NetworkSecurity scopes.</summary>
        /// <remarks>
        /// The default NetworkSecurity scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkSecurity.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetworkSecurityClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkSecurityClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetworkSecurityClient"/>.</returns>
        public static stt::Task<NetworkSecurityClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetworkSecurityClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetworkSecurityClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkSecurityClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetworkSecurityClient"/>.</returns>
        public static NetworkSecurityClient Create() => new NetworkSecurityClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetworkSecurityClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetworkSecuritySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetworkSecurityClient"/>.</returns>
        internal static NetworkSecurityClient Create(grpccore::CallInvoker callInvoker, NetworkSecuritySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetworkSecurity.NetworkSecurityClient grpcClient = new NetworkSecurity.NetworkSecurityClient(callInvoker);
            return new NetworkSecurityClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetworkSecurity client</summary>
        public virtual NetworkSecurity.NetworkSecurityClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPolicies(ListAuthorizationPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPoliciesAsync(ListAuthorizationPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AuthorizationPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthorizationPoliciesRequest request = new ListAuthorizationPoliciesRequest
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
            return ListAuthorizationPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AuthorizationPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthorizationPoliciesRequest request = new ListAuthorizationPoliciesRequest
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
            return ListAuthorizationPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AuthorizationPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthorizationPoliciesRequest request = new ListAuthorizationPoliciesRequest
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
            return ListAuthorizationPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AuthorizationPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthorizationPoliciesRequest request = new ListAuthorizationPoliciesRequest
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
            return ListAuthorizationPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationPolicy GetAuthorizationPolicy(GetAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(GetAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(GetAuthorizationPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAuthorizationPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationPolicy GetAuthorizationPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorizationPolicy(new GetAuthorizationPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorizationPolicyAsync(new GetAuthorizationPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAuthorizationPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationPolicy GetAuthorizationPolicy(AuthorizationPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorizationPolicy(new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(AuthorizationPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorizationPolicyAsync(new GetAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(AuthorizationPolicyName name, st::CancellationToken cancellationToken) =>
            GetAuthorizationPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> CreateAuthorizationPolicy(CreateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(CreateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(CreateAuthorizationPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateAuthorizationPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAuthorizationPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateAuthorizationPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAuthorizationPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> PollOnceCreateAuthorizationPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthorizationPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAuthorizationPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAuthorizationPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> PollOnceCreateAuthorizationPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthorizationPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAuthorizationPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AuthorizationPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authorizationPolicy">
        /// Required. AuthorizationPolicy resource to be created.
        /// </param>
        /// <param name="authorizationPolicyId">
        /// Required. Short name of the AuthorizationPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> CreateAuthorizationPolicy(string parent, AuthorizationPolicy authorizationPolicy, string authorizationPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthorizationPolicy(new CreateAuthorizationPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AuthorizationPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)),
                AuthorizationPolicy = gax::GaxPreconditions.CheckNotNull(authorizationPolicy, nameof(authorizationPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AuthorizationPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authorizationPolicy">
        /// Required. AuthorizationPolicy resource to be created.
        /// </param>
        /// <param name="authorizationPolicyId">
        /// Required. Short name of the AuthorizationPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(string parent, AuthorizationPolicy authorizationPolicy, string authorizationPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthorizationPolicyAsync(new CreateAuthorizationPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AuthorizationPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)),
                AuthorizationPolicy = gax::GaxPreconditions.CheckNotNull(authorizationPolicy, nameof(authorizationPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AuthorizationPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authorizationPolicy">
        /// Required. AuthorizationPolicy resource to be created.
        /// </param>
        /// <param name="authorizationPolicyId">
        /// Required. Short name of the AuthorizationPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(string parent, AuthorizationPolicy authorizationPolicy, string authorizationPolicyId, st::CancellationToken cancellationToken) =>
            CreateAuthorizationPolicyAsync(parent, authorizationPolicy, authorizationPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AuthorizationPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authorizationPolicy">
        /// Required. AuthorizationPolicy resource to be created.
        /// </param>
        /// <param name="authorizationPolicyId">
        /// Required. Short name of the AuthorizationPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> CreateAuthorizationPolicy(gagr::LocationName parent, AuthorizationPolicy authorizationPolicy, string authorizationPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthorizationPolicy(new CreateAuthorizationPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AuthorizationPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)),
                AuthorizationPolicy = gax::GaxPreconditions.CheckNotNull(authorizationPolicy, nameof(authorizationPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AuthorizationPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authorizationPolicy">
        /// Required. AuthorizationPolicy resource to be created.
        /// </param>
        /// <param name="authorizationPolicyId">
        /// Required. Short name of the AuthorizationPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(gagr::LocationName parent, AuthorizationPolicy authorizationPolicy, string authorizationPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthorizationPolicyAsync(new CreateAuthorizationPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AuthorizationPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)),
                AuthorizationPolicy = gax::GaxPreconditions.CheckNotNull(authorizationPolicy, nameof(authorizationPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AuthorizationPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authorizationPolicy">
        /// Required. AuthorizationPolicy resource to be created.
        /// </param>
        /// <param name="authorizationPolicyId">
        /// Required. Short name of the AuthorizationPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(gagr::LocationName parent, AuthorizationPolicy authorizationPolicy, string authorizationPolicyId, st::CancellationToken cancellationToken) =>
            CreateAuthorizationPolicyAsync(parent, authorizationPolicy, authorizationPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> UpdateAuthorizationPolicy(UpdateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> UpdateAuthorizationPolicyAsync(UpdateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> UpdateAuthorizationPolicyAsync(UpdateAuthorizationPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAuthorizationPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAuthorizationPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateAuthorizationPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAuthorizationPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> PollOnceUpdateAuthorizationPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthorizationPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAuthorizationPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAuthorizationPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> PollOnceUpdateAuthorizationPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthorizationPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAuthorizationPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="authorizationPolicy">
        /// Required. Updated AuthorizationPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// AuthorizationPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthorizationPolicy, OperationMetadata> UpdateAuthorizationPolicy(AuthorizationPolicy authorizationPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAuthorizationPolicy(new UpdateAuthorizationPolicyRequest
            {
                UpdateMask = updateMask,
                AuthorizationPolicy = gax::GaxPreconditions.CheckNotNull(authorizationPolicy, nameof(authorizationPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="authorizationPolicy">
        /// Required. Updated AuthorizationPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// AuthorizationPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> UpdateAuthorizationPolicyAsync(AuthorizationPolicy authorizationPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAuthorizationPolicyAsync(new UpdateAuthorizationPolicyRequest
            {
                UpdateMask = updateMask,
                AuthorizationPolicy = gax::GaxPreconditions.CheckNotNull(authorizationPolicy, nameof(authorizationPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="authorizationPolicy">
        /// Required. Updated AuthorizationPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// AuthorizationPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> UpdateAuthorizationPolicyAsync(AuthorizationPolicy authorizationPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAuthorizationPolicyAsync(authorizationPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthorizationPolicy(DeleteAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(DeleteAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(DeleteAuthorizationPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAuthorizationPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAuthorizationPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteAuthorizationPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAuthorizationPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAuthorizationPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAuthorizationPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAuthorizationPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAuthorizationPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAuthorizationPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthorizationPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthorizationPolicy(new DeleteAuthorizationPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthorizationPolicyAsync(new DeleteAuthorizationPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAuthorizationPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthorizationPolicy(AuthorizationPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthorizationPolicy(new DeleteAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(AuthorizationPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthorizationPolicyAsync(new DeleteAuthorizationPolicyRequest
            {
                AuthorizationPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AuthorizationPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/authorizationPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(AuthorizationPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAuthorizationPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigs(ListBackendAuthenticationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigsAsync(ListBackendAuthenticationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the
        /// BackendAuthenticationConfigs should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackendAuthenticationConfigsRequest request = new ListBackendAuthenticationConfigsRequest
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
            return ListBackendAuthenticationConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the
        /// BackendAuthenticationConfigs should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackendAuthenticationConfigsRequest request = new ListBackendAuthenticationConfigsRequest
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
            return ListBackendAuthenticationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the
        /// BackendAuthenticationConfigs should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackendAuthenticationConfigsRequest request = new ListBackendAuthenticationConfigsRequest
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
            return ListBackendAuthenticationConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the
        /// BackendAuthenticationConfigs should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackendAuthenticationConfigsRequest request = new ListBackendAuthenticationConfigsRequest
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
            return ListBackendAuthenticationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendAuthenticationConfig GetBackendAuthenticationConfig(GetBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(GetBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(GetBackendAuthenticationConfigRequest request, st::CancellationToken cancellationToken) =>
            GetBackendAuthenticationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to get. Must be in the
        /// format `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendAuthenticationConfig GetBackendAuthenticationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackendAuthenticationConfig(new GetBackendAuthenticationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to get. Must be in the
        /// format `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackendAuthenticationConfigAsync(new GetBackendAuthenticationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to get. Must be in the
        /// format `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackendAuthenticationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to get. Must be in the
        /// format `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendAuthenticationConfig GetBackendAuthenticationConfig(BackendAuthenticationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackendAuthenticationConfig(new GetBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to get. Must be in the
        /// format `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(BackendAuthenticationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackendAuthenticationConfigAsync(new GetBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to get. Must be in the
        /// format `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(BackendAuthenticationConfigName name, st::CancellationToken cancellationToken) =>
            GetBackendAuthenticationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> CreateBackendAuthenticationConfig(CreateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(CreateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(CreateBackendAuthenticationConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateBackendAuthenticationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBackendAuthenticationConfig</c>.</summary>
        public virtual lro::OperationsClient CreateBackendAuthenticationConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackendAuthenticationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> PollOnceCreateBackendAuthenticationConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackendAuthenticationConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackendAuthenticationConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackendAuthenticationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> PollOnceCreateBackendAuthenticationConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackendAuthenticationConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackendAuthenticationConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the BackendAuthenticationConfig. Must be
        /// in the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="backendAuthenticationConfig">
        /// Required. BackendAuthenticationConfig resource to be created.
        /// </param>
        /// <param name="backendAuthenticationConfigId">
        /// Required. Short name of the BackendAuthenticationConfig resource to be
        /// created. This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start with a
        /// number. E.g. "backend-auth-config".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> CreateBackendAuthenticationConfig(string parent, BackendAuthenticationConfig backendAuthenticationConfig, string backendAuthenticationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackendAuthenticationConfig(new CreateBackendAuthenticationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackendAuthenticationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(backendAuthenticationConfigId, nameof(backendAuthenticationConfigId)),
                BackendAuthenticationConfig = gax::GaxPreconditions.CheckNotNull(backendAuthenticationConfig, nameof(backendAuthenticationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the BackendAuthenticationConfig. Must be
        /// in the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="backendAuthenticationConfig">
        /// Required. BackendAuthenticationConfig resource to be created.
        /// </param>
        /// <param name="backendAuthenticationConfigId">
        /// Required. Short name of the BackendAuthenticationConfig resource to be
        /// created. This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start with a
        /// number. E.g. "backend-auth-config".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(string parent, BackendAuthenticationConfig backendAuthenticationConfig, string backendAuthenticationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackendAuthenticationConfigAsync(new CreateBackendAuthenticationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackendAuthenticationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(backendAuthenticationConfigId, nameof(backendAuthenticationConfigId)),
                BackendAuthenticationConfig = gax::GaxPreconditions.CheckNotNull(backendAuthenticationConfig, nameof(backendAuthenticationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the BackendAuthenticationConfig. Must be
        /// in the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="backendAuthenticationConfig">
        /// Required. BackendAuthenticationConfig resource to be created.
        /// </param>
        /// <param name="backendAuthenticationConfigId">
        /// Required. Short name of the BackendAuthenticationConfig resource to be
        /// created. This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start with a
        /// number. E.g. "backend-auth-config".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(string parent, BackendAuthenticationConfig backendAuthenticationConfig, string backendAuthenticationConfigId, st::CancellationToken cancellationToken) =>
            CreateBackendAuthenticationConfigAsync(parent, backendAuthenticationConfig, backendAuthenticationConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the BackendAuthenticationConfig. Must be
        /// in the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="backendAuthenticationConfig">
        /// Required. BackendAuthenticationConfig resource to be created.
        /// </param>
        /// <param name="backendAuthenticationConfigId">
        /// Required. Short name of the BackendAuthenticationConfig resource to be
        /// created. This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start with a
        /// number. E.g. "backend-auth-config".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> CreateBackendAuthenticationConfig(gagr::LocationName parent, BackendAuthenticationConfig backendAuthenticationConfig, string backendAuthenticationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackendAuthenticationConfig(new CreateBackendAuthenticationConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackendAuthenticationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(backendAuthenticationConfigId, nameof(backendAuthenticationConfigId)),
                BackendAuthenticationConfig = gax::GaxPreconditions.CheckNotNull(backendAuthenticationConfig, nameof(backendAuthenticationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the BackendAuthenticationConfig. Must be
        /// in the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="backendAuthenticationConfig">
        /// Required. BackendAuthenticationConfig resource to be created.
        /// </param>
        /// <param name="backendAuthenticationConfigId">
        /// Required. Short name of the BackendAuthenticationConfig resource to be
        /// created. This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start with a
        /// number. E.g. "backend-auth-config".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(gagr::LocationName parent, BackendAuthenticationConfig backendAuthenticationConfig, string backendAuthenticationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackendAuthenticationConfigAsync(new CreateBackendAuthenticationConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackendAuthenticationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(backendAuthenticationConfigId, nameof(backendAuthenticationConfigId)),
                BackendAuthenticationConfig = gax::GaxPreconditions.CheckNotNull(backendAuthenticationConfig, nameof(backendAuthenticationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the BackendAuthenticationConfig. Must be
        /// in the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="backendAuthenticationConfig">
        /// Required. BackendAuthenticationConfig resource to be created.
        /// </param>
        /// <param name="backendAuthenticationConfigId">
        /// Required. Short name of the BackendAuthenticationConfig resource to be
        /// created. This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start with a
        /// number. E.g. "backend-auth-config".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(gagr::LocationName parent, BackendAuthenticationConfig backendAuthenticationConfig, string backendAuthenticationConfigId, st::CancellationToken cancellationToken) =>
            CreateBackendAuthenticationConfigAsync(parent, backendAuthenticationConfig, backendAuthenticationConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> UpdateBackendAuthenticationConfig(UpdateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> UpdateBackendAuthenticationConfigAsync(UpdateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> UpdateBackendAuthenticationConfigAsync(UpdateBackendAuthenticationConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackendAuthenticationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBackendAuthenticationConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateBackendAuthenticationConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackendAuthenticationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> PollOnceUpdateBackendAuthenticationConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackendAuthenticationConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackendAuthenticationConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackendAuthenticationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> PollOnceUpdateBackendAuthenticationConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackendAuthenticationConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackendAuthenticationConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="backendAuthenticationConfig">
        /// Required. Updated BackendAuthenticationConfig resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// BackendAuthenticationConfig resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackendAuthenticationConfig, OperationMetadata> UpdateBackendAuthenticationConfig(BackendAuthenticationConfig backendAuthenticationConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackendAuthenticationConfig(new UpdateBackendAuthenticationConfigRequest
            {
                UpdateMask = updateMask,
                BackendAuthenticationConfig = gax::GaxPreconditions.CheckNotNull(backendAuthenticationConfig, nameof(backendAuthenticationConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="backendAuthenticationConfig">
        /// Required. Updated BackendAuthenticationConfig resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// BackendAuthenticationConfig resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> UpdateBackendAuthenticationConfigAsync(BackendAuthenticationConfig backendAuthenticationConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackendAuthenticationConfigAsync(new UpdateBackendAuthenticationConfigRequest
            {
                UpdateMask = updateMask,
                BackendAuthenticationConfig = gax::GaxPreconditions.CheckNotNull(backendAuthenticationConfig, nameof(backendAuthenticationConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="backendAuthenticationConfig">
        /// Required. Updated BackendAuthenticationConfig resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// BackendAuthenticationConfig resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> UpdateBackendAuthenticationConfigAsync(BackendAuthenticationConfig backendAuthenticationConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackendAuthenticationConfigAsync(backendAuthenticationConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackendAuthenticationConfig(DeleteBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(DeleteBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(DeleteBackendAuthenticationConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackendAuthenticationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackendAuthenticationConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteBackendAuthenticationConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackendAuthenticationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackendAuthenticationConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackendAuthenticationConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackendAuthenticationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackendAuthenticationConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackendAuthenticationConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to delete. Must be in
        /// the format
        /// `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackendAuthenticationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackendAuthenticationConfig(new DeleteBackendAuthenticationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to delete. Must be in
        /// the format
        /// `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackendAuthenticationConfigAsync(new DeleteBackendAuthenticationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to delete. Must be in
        /// the format
        /// `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackendAuthenticationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to delete. Must be in
        /// the format
        /// `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackendAuthenticationConfig(BackendAuthenticationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackendAuthenticationConfig(new DeleteBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to delete. Must be in
        /// the format
        /// `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(BackendAuthenticationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackendAuthenticationConfigAsync(new DeleteBackendAuthenticationConfigRequest
            {
                BackendAuthenticationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the BackendAuthenticationConfig to delete. Must be in
        /// the format
        /// `projects/*/locations/{location}/backendAuthenticationConfigs/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(BackendAuthenticationConfigName name, st::CancellationToken cancellationToken) =>
            DeleteBackendAuthenticationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPolicies(ListServerTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPoliciesAsync(ListServerTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServerTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServerTlsPoliciesRequest request = new ListServerTlsPoliciesRequest
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
            return ListServerTlsPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServerTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServerTlsPoliciesRequest request = new ListServerTlsPoliciesRequest
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
            return ListServerTlsPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServerTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServerTlsPoliciesRequest request = new ListServerTlsPoliciesRequest
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
            return ListServerTlsPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ServerTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServerTlsPoliciesRequest request = new ListServerTlsPoliciesRequest
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
            return ListServerTlsPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServerTlsPolicy GetServerTlsPolicy(GetServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(GetServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(GetServerTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetServerTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServerTlsPolicy GetServerTlsPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServerTlsPolicy(new GetServerTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServerTlsPolicyAsync(new GetServerTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetServerTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServerTlsPolicy GetServerTlsPolicy(ServerTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServerTlsPolicy(new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(ServerTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServerTlsPolicyAsync(new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(ServerTlsPolicyName name, st::CancellationToken cancellationToken) =>
            GetServerTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> CreateServerTlsPolicy(CreateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(CreateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(CreateServerTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateServerTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServerTlsPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateServerTlsPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateServerTlsPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> PollOnceCreateServerTlsPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServerTlsPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServerTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServerTlsPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> PollOnceCreateServerTlsPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServerTlsPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServerTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServerTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="serverTlsPolicy">
        /// Required. ServerTlsPolicy resource to be created.
        /// </param>
        /// <param name="serverTlsPolicyId">
        /// Required. Short name of the ServerTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "server_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> CreateServerTlsPolicy(string parent, ServerTlsPolicy serverTlsPolicy, string serverTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServerTlsPolicy(new CreateServerTlsPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServerTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)),
                ServerTlsPolicy = gax::GaxPreconditions.CheckNotNull(serverTlsPolicy, nameof(serverTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServerTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="serverTlsPolicy">
        /// Required. ServerTlsPolicy resource to be created.
        /// </param>
        /// <param name="serverTlsPolicyId">
        /// Required. Short name of the ServerTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "server_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(string parent, ServerTlsPolicy serverTlsPolicy, string serverTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServerTlsPolicyAsync(new CreateServerTlsPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServerTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)),
                ServerTlsPolicy = gax::GaxPreconditions.CheckNotNull(serverTlsPolicy, nameof(serverTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServerTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="serverTlsPolicy">
        /// Required. ServerTlsPolicy resource to be created.
        /// </param>
        /// <param name="serverTlsPolicyId">
        /// Required. Short name of the ServerTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "server_mtls_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(string parent, ServerTlsPolicy serverTlsPolicy, string serverTlsPolicyId, st::CancellationToken cancellationToken) =>
            CreateServerTlsPolicyAsync(parent, serverTlsPolicy, serverTlsPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServerTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="serverTlsPolicy">
        /// Required. ServerTlsPolicy resource to be created.
        /// </param>
        /// <param name="serverTlsPolicyId">
        /// Required. Short name of the ServerTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "server_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> CreateServerTlsPolicy(gagr::LocationName parent, ServerTlsPolicy serverTlsPolicy, string serverTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServerTlsPolicy(new CreateServerTlsPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServerTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)),
                ServerTlsPolicy = gax::GaxPreconditions.CheckNotNull(serverTlsPolicy, nameof(serverTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServerTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="serverTlsPolicy">
        /// Required. ServerTlsPolicy resource to be created.
        /// </param>
        /// <param name="serverTlsPolicyId">
        /// Required. Short name of the ServerTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "server_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(gagr::LocationName parent, ServerTlsPolicy serverTlsPolicy, string serverTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServerTlsPolicyAsync(new CreateServerTlsPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServerTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)),
                ServerTlsPolicy = gax::GaxPreconditions.CheckNotNull(serverTlsPolicy, nameof(serverTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ServerTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="serverTlsPolicy">
        /// Required. ServerTlsPolicy resource to be created.
        /// </param>
        /// <param name="serverTlsPolicyId">
        /// Required. Short name of the ServerTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "server_mtls_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(gagr::LocationName parent, ServerTlsPolicy serverTlsPolicy, string serverTlsPolicyId, st::CancellationToken cancellationToken) =>
            CreateServerTlsPolicyAsync(parent, serverTlsPolicy, serverTlsPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> UpdateServerTlsPolicy(UpdateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> UpdateServerTlsPolicyAsync(UpdateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> UpdateServerTlsPolicyAsync(UpdateServerTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateServerTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServerTlsPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateServerTlsPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateServerTlsPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> PollOnceUpdateServerTlsPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServerTlsPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServerTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServerTlsPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> PollOnceUpdateServerTlsPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServerTlsPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServerTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="serverTlsPolicy">
        /// Required. Updated ServerTlsPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServerTlsPolicy resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServerTlsPolicy, OperationMetadata> UpdateServerTlsPolicy(ServerTlsPolicy serverTlsPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServerTlsPolicy(new UpdateServerTlsPolicyRequest
            {
                UpdateMask = updateMask,
                ServerTlsPolicy = gax::GaxPreconditions.CheckNotNull(serverTlsPolicy, nameof(serverTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="serverTlsPolicy">
        /// Required. Updated ServerTlsPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServerTlsPolicy resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> UpdateServerTlsPolicyAsync(ServerTlsPolicy serverTlsPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServerTlsPolicyAsync(new UpdateServerTlsPolicyRequest
            {
                UpdateMask = updateMask,
                ServerTlsPolicy = gax::GaxPreconditions.CheckNotNull(serverTlsPolicy, nameof(serverTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="serverTlsPolicy">
        /// Required. Updated ServerTlsPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ServerTlsPolicy resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> UpdateServerTlsPolicyAsync(ServerTlsPolicy serverTlsPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServerTlsPolicyAsync(serverTlsPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServerTlsPolicy(DeleteServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(DeleteServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(DeleteServerTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteServerTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServerTlsPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteServerTlsPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteServerTlsPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServerTlsPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServerTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServerTlsPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServerTlsPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServerTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServerTlsPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServerTlsPolicy(new DeleteServerTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServerTlsPolicyAsync(new DeleteServerTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServerTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServerTlsPolicy(ServerTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServerTlsPolicy(new DeleteServerTlsPolicyRequest
            {
                ServerTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(ServerTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServerTlsPolicyAsync(new DeleteServerTlsPolicyRequest
            {
                ServerTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ServerTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/serverTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(ServerTlsPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteServerTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPolicies(ListClientTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPoliciesAsync(ListClientTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ClientTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientTlsPoliciesRequest request = new ListClientTlsPoliciesRequest
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
            return ListClientTlsPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ClientTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientTlsPoliciesRequest request = new ListClientTlsPoliciesRequest
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
            return ListClientTlsPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ClientTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientTlsPoliciesRequest request = new ListClientTlsPoliciesRequest
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
            return ListClientTlsPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the ClientTlsPolicies should
        /// be listed, specified in the format `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClientTlsPoliciesRequest request = new ListClientTlsPoliciesRequest
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
            return ListClientTlsPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientTlsPolicy GetClientTlsPolicy(GetClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(GetClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(GetClientTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetClientTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientTlsPolicy GetClientTlsPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientTlsPolicy(new GetClientTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientTlsPolicyAsync(new GetClientTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetClientTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientTlsPolicy GetClientTlsPolicy(ClientTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientTlsPolicy(new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(ClientTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientTlsPolicyAsync(new GetClientTlsPolicyRequest
            {
                ClientTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to get. Must be in the format
        /// `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(ClientTlsPolicyName name, st::CancellationToken cancellationToken) =>
            GetClientTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> CreateClientTlsPolicy(CreateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(CreateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(CreateClientTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateClientTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateClientTlsPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateClientTlsPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateClientTlsPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> PollOnceCreateClientTlsPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientTlsPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClientTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateClientTlsPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> PollOnceCreateClientTlsPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientTlsPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClientTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ClientTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="clientTlsPolicy">
        /// Required. ClientTlsPolicy resource to be created.
        /// </param>
        /// <param name="clientTlsPolicyId">
        /// Required. Short name of the ClientTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "client_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> CreateClientTlsPolicy(string parent, ClientTlsPolicy clientTlsPolicy, string clientTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientTlsPolicy(new CreateClientTlsPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)),
                ClientTlsPolicy = gax::GaxPreconditions.CheckNotNull(clientTlsPolicy, nameof(clientTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ClientTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="clientTlsPolicy">
        /// Required. ClientTlsPolicy resource to be created.
        /// </param>
        /// <param name="clientTlsPolicyId">
        /// Required. Short name of the ClientTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "client_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(string parent, ClientTlsPolicy clientTlsPolicy, string clientTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientTlsPolicyAsync(new CreateClientTlsPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)),
                ClientTlsPolicy = gax::GaxPreconditions.CheckNotNull(clientTlsPolicy, nameof(clientTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ClientTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="clientTlsPolicy">
        /// Required. ClientTlsPolicy resource to be created.
        /// </param>
        /// <param name="clientTlsPolicyId">
        /// Required. Short name of the ClientTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "client_mtls_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(string parent, ClientTlsPolicy clientTlsPolicy, string clientTlsPolicyId, st::CancellationToken cancellationToken) =>
            CreateClientTlsPolicyAsync(parent, clientTlsPolicy, clientTlsPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ClientTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="clientTlsPolicy">
        /// Required. ClientTlsPolicy resource to be created.
        /// </param>
        /// <param name="clientTlsPolicyId">
        /// Required. Short name of the ClientTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "client_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> CreateClientTlsPolicy(gagr::LocationName parent, ClientTlsPolicy clientTlsPolicy, string clientTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientTlsPolicy(new CreateClientTlsPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)),
                ClientTlsPolicy = gax::GaxPreconditions.CheckNotNull(clientTlsPolicy, nameof(clientTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ClientTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="clientTlsPolicy">
        /// Required. ClientTlsPolicy resource to be created.
        /// </param>
        /// <param name="clientTlsPolicyId">
        /// Required. Short name of the ClientTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "client_mtls_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(gagr::LocationName parent, ClientTlsPolicy clientTlsPolicy, string clientTlsPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientTlsPolicyAsync(new CreateClientTlsPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientTlsPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)),
                ClientTlsPolicy = gax::GaxPreconditions.CheckNotNull(clientTlsPolicy, nameof(clientTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the ClientTlsPolicy. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="clientTlsPolicy">
        /// Required. ClientTlsPolicy resource to be created.
        /// </param>
        /// <param name="clientTlsPolicyId">
        /// Required. Short name of the ClientTlsPolicy resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "client_mtls_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(gagr::LocationName parent, ClientTlsPolicy clientTlsPolicy, string clientTlsPolicyId, st::CancellationToken cancellationToken) =>
            CreateClientTlsPolicyAsync(parent, clientTlsPolicy, clientTlsPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> UpdateClientTlsPolicy(UpdateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> UpdateClientTlsPolicyAsync(UpdateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> UpdateClientTlsPolicyAsync(UpdateClientTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateClientTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateClientTlsPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateClientTlsPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateClientTlsPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> PollOnceUpdateClientTlsPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientTlsPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClientTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateClientTlsPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> PollOnceUpdateClientTlsPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientTlsPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClientTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="clientTlsPolicy">
        /// Required. Updated ClientTlsPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ClientTlsPolicy resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientTlsPolicy, OperationMetadata> UpdateClientTlsPolicy(ClientTlsPolicy clientTlsPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClientTlsPolicy(new UpdateClientTlsPolicyRequest
            {
                UpdateMask = updateMask,
                ClientTlsPolicy = gax::GaxPreconditions.CheckNotNull(clientTlsPolicy, nameof(clientTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="clientTlsPolicy">
        /// Required. Updated ClientTlsPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ClientTlsPolicy resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> UpdateClientTlsPolicyAsync(ClientTlsPolicy clientTlsPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClientTlsPolicyAsync(new UpdateClientTlsPolicyRequest
            {
                UpdateMask = updateMask,
                ClientTlsPolicy = gax::GaxPreconditions.CheckNotNull(clientTlsPolicy, nameof(clientTlsPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="clientTlsPolicy">
        /// Required. Updated ClientTlsPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ClientTlsPolicy resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> UpdateClientTlsPolicyAsync(ClientTlsPolicy clientTlsPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClientTlsPolicyAsync(clientTlsPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteClientTlsPolicy(DeleteClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(DeleteClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(DeleteClientTlsPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteClientTlsPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteClientTlsPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteClientTlsPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteClientTlsPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteClientTlsPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClientTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteClientTlsPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteClientTlsPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClientTlsPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteClientTlsPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientTlsPolicy(new DeleteClientTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientTlsPolicyAsync(new DeleteClientTlsPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClientTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteClientTlsPolicy(ClientTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientTlsPolicy(new DeleteClientTlsPolicyRequest
            {
                ClientTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(ClientTlsPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientTlsPolicyAsync(new DeleteClientTlsPolicyRequest
            {
                ClientTlsPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the ClientTlsPolicy to delete. Must be in
        /// the format `projects/*/locations/{location}/clientTlsPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(ClientTlsPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteClientTlsPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPolicies(ListGatewaySecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPoliciesAsync(ListGatewaySecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GatewaySecurityPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPoliciesRequest request = new ListGatewaySecurityPoliciesRequest
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
            return ListGatewaySecurityPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GatewaySecurityPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPoliciesRequest request = new ListGatewaySecurityPoliciesRequest
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
            return ListGatewaySecurityPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GatewaySecurityPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPoliciesRequest request = new ListGatewaySecurityPoliciesRequest
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
            return ListGatewaySecurityPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the GatewaySecurityPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPoliciesRequest request = new ListGatewaySecurityPoliciesRequest
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
            return ListGatewaySecurityPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewaySecurityPolicy GetGatewaySecurityPolicy(GetGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(GetGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(GetGatewaySecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetGatewaySecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewaySecurityPolicy GetGatewaySecurityPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicy(new GetGatewaySecurityPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicyAsync(new GetGatewaySecurityPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetGatewaySecurityPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewaySecurityPolicy GetGatewaySecurityPolicy(GatewaySecurityPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicy(new GetGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(GatewaySecurityPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicyAsync(new GetGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(GatewaySecurityPolicyName name, st::CancellationToken cancellationToken) =>
            GetGatewaySecurityPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> CreateGatewaySecurityPolicy(CreateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(CreateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(CreateGatewaySecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateGatewaySecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGatewaySecurityPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateGatewaySecurityPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGatewaySecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> PollOnceCreateGatewaySecurityPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewaySecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGatewaySecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> PollOnceCreateGatewaySecurityPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewaySecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GatewaySecurityPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gatewaySecurityPolicy">
        /// Required. GatewaySecurityPolicy resource to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyId">
        /// Required. Short name of the GatewaySecurityPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "gateway_security_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> CreateGatewaySecurityPolicy(string parent, GatewaySecurityPolicy gatewaySecurityPolicy, string gatewaySecurityPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicy(new CreateGatewaySecurityPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewaySecurityPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)),
                GatewaySecurityPolicy = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicy, nameof(gatewaySecurityPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GatewaySecurityPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gatewaySecurityPolicy">
        /// Required. GatewaySecurityPolicy resource to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyId">
        /// Required. Short name of the GatewaySecurityPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "gateway_security_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(string parent, GatewaySecurityPolicy gatewaySecurityPolicy, string gatewaySecurityPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicyAsync(new CreateGatewaySecurityPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewaySecurityPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)),
                GatewaySecurityPolicy = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicy, nameof(gatewaySecurityPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GatewaySecurityPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gatewaySecurityPolicy">
        /// Required. GatewaySecurityPolicy resource to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyId">
        /// Required. Short name of the GatewaySecurityPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "gateway_security_policy1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(string parent, GatewaySecurityPolicy gatewaySecurityPolicy, string gatewaySecurityPolicyId, st::CancellationToken cancellationToken) =>
            CreateGatewaySecurityPolicyAsync(parent, gatewaySecurityPolicy, gatewaySecurityPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GatewaySecurityPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gatewaySecurityPolicy">
        /// Required. GatewaySecurityPolicy resource to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyId">
        /// Required. Short name of the GatewaySecurityPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "gateway_security_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> CreateGatewaySecurityPolicy(gagr::LocationName parent, GatewaySecurityPolicy gatewaySecurityPolicy, string gatewaySecurityPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicy(new CreateGatewaySecurityPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewaySecurityPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)),
                GatewaySecurityPolicy = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicy, nameof(gatewaySecurityPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GatewaySecurityPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gatewaySecurityPolicy">
        /// Required. GatewaySecurityPolicy resource to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyId">
        /// Required. Short name of the GatewaySecurityPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "gateway_security_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(gagr::LocationName parent, GatewaySecurityPolicy gatewaySecurityPolicy, string gatewaySecurityPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicyAsync(new CreateGatewaySecurityPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewaySecurityPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)),
                GatewaySecurityPolicy = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicy, nameof(gatewaySecurityPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the GatewaySecurityPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gatewaySecurityPolicy">
        /// Required. GatewaySecurityPolicy resource to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyId">
        /// Required. Short name of the GatewaySecurityPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "gateway_security_policy1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(gagr::LocationName parent, GatewaySecurityPolicy gatewaySecurityPolicy, string gatewaySecurityPolicyId, st::CancellationToken cancellationToken) =>
            CreateGatewaySecurityPolicyAsync(parent, gatewaySecurityPolicy, gatewaySecurityPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> UpdateGatewaySecurityPolicy(UpdateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> UpdateGatewaySecurityPolicyAsync(UpdateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> UpdateGatewaySecurityPolicyAsync(UpdateGatewaySecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateGatewaySecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGatewaySecurityPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateGatewaySecurityPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGatewaySecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> PollOnceUpdateGatewaySecurityPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewaySecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGatewaySecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> PollOnceUpdateGatewaySecurityPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewaySecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="gatewaySecurityPolicy">
        /// Required. Updated GatewaySecurityPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GatewaySecurityPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicy, OperationMetadata> UpdateGatewaySecurityPolicy(GatewaySecurityPolicy gatewaySecurityPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGatewaySecurityPolicy(new UpdateGatewaySecurityPolicyRequest
            {
                UpdateMask = updateMask,
                GatewaySecurityPolicy = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicy, nameof(gatewaySecurityPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="gatewaySecurityPolicy">
        /// Required. Updated GatewaySecurityPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GatewaySecurityPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> UpdateGatewaySecurityPolicyAsync(GatewaySecurityPolicy gatewaySecurityPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGatewaySecurityPolicyAsync(new UpdateGatewaySecurityPolicyRequest
            {
                UpdateMask = updateMask,
                GatewaySecurityPolicy = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicy, nameof(gatewaySecurityPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="gatewaySecurityPolicy">
        /// Required. Updated GatewaySecurityPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GatewaySecurityPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> UpdateGatewaySecurityPolicyAsync(GatewaySecurityPolicy gatewaySecurityPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGatewaySecurityPolicyAsync(gatewaySecurityPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicy(DeleteGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(DeleteGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(DeleteGatewaySecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteGatewaySecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGatewaySecurityPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteGatewaySecurityPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGatewaySecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGatewaySecurityPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewaySecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGatewaySecurityPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGatewaySecurityPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewaySecurityPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicy(new DeleteGatewaySecurityPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicyAsync(new DeleteGatewaySecurityPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGatewaySecurityPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicy(GatewaySecurityPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicy(new DeleteGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(GatewaySecurityPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicyAsync(new DeleteGatewaySecurityPolicyRequest
            {
                GatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicy to delete. Must be in the
        /// format `projects/{project}/locations/{location}/gatewaySecurityPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(GatewaySecurityPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteGatewaySecurityPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRules(ListGatewaySecurityPolicyRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRulesAsync(ListGatewaySecurityPolicyRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and GatewaySecurityPolicy from which the
        /// GatewaySecurityPolicyRules should be listed, specified in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}`.
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
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPolicyRulesRequest request = new ListGatewaySecurityPolicyRulesRequest
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
            return ListGatewaySecurityPolicyRules(request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and GatewaySecurityPolicy from which the
        /// GatewaySecurityPolicyRules should be listed, specified in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPolicyRulesRequest request = new ListGatewaySecurityPolicyRulesRequest
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
            return ListGatewaySecurityPolicyRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and GatewaySecurityPolicy from which the
        /// GatewaySecurityPolicyRules should be listed, specified in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}`.
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
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRules(GatewaySecurityPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPolicyRulesRequest request = new ListGatewaySecurityPolicyRulesRequest
            {
                ParentAsGatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGatewaySecurityPolicyRules(request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and GatewaySecurityPolicy from which the
        /// GatewaySecurityPolicyRules should be listed, specified in the format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRulesAsync(GatewaySecurityPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaySecurityPolicyRulesRequest request = new ListGatewaySecurityPolicyRulesRequest
            {
                ParentAsGatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGatewaySecurityPolicyRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewaySecurityPolicyRule GetGatewaySecurityPolicyRule(GetGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(GetGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(GetGatewaySecurityPolicyRuleRequest request, st::CancellationToken cancellationToken) =>
            GetGatewaySecurityPolicyRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GatewaySecurityPolicyRule to retrieve.
        /// Format:
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*/rules/*
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewaySecurityPolicyRule GetGatewaySecurityPolicyRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicyRule(new GetGatewaySecurityPolicyRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GatewaySecurityPolicyRule to retrieve.
        /// Format:
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*/rules/*
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicyRuleAsync(new GetGatewaySecurityPolicyRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GatewaySecurityPolicyRule to retrieve.
        /// Format:
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*/rules/*
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetGatewaySecurityPolicyRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GatewaySecurityPolicyRule to retrieve.
        /// Format:
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*/rules/*
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GatewaySecurityPolicyRule GetGatewaySecurityPolicyRule(GatewaySecurityPolicyRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicyRule(new GetGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GatewaySecurityPolicyRule to retrieve.
        /// Format:
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*/rules/*
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewaySecurityPolicyRuleAsync(new GetGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GatewaySecurityPolicyRule to retrieve.
        /// Format:
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*/rules/*
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName name, st::CancellationToken cancellationToken) =>
            GetGatewaySecurityPolicyRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> CreateGatewaySecurityPolicyRule(CreateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(CreateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(CreateGatewaySecurityPolicyRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateGatewaySecurityPolicyRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGatewaySecurityPolicyRule</c>.</summary>
        public virtual lro::OperationsClient CreateGatewaySecurityPolicyRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGatewaySecurityPolicyRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> PollOnceCreateGatewaySecurityPolicyRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewaySecurityPolicyRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGatewaySecurityPolicyRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> PollOnceCreateGatewaySecurityPolicyRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewaySecurityPolicyRuleOperationsClient, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent where this rule will be created.
        /// Format :
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*
        /// </param>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. The rule to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyRuleId">
        /// The ID to use for the rule, which will become the final component of
        /// the rule's resource name.
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> CreateGatewaySecurityPolicyRule(string parent, GatewaySecurityPolicyRule gatewaySecurityPolicyRule, string gatewaySecurityPolicyRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicyRule(new CreateGatewaySecurityPolicyRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewaySecurityPolicyRule = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRule, nameof(gatewaySecurityPolicyRule)),
                GatewaySecurityPolicyRuleId = gatewaySecurityPolicyRuleId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent where this rule will be created.
        /// Format :
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*
        /// </param>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. The rule to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyRuleId">
        /// The ID to use for the rule, which will become the final component of
        /// the rule's resource name.
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(string parent, GatewaySecurityPolicyRule gatewaySecurityPolicyRule, string gatewaySecurityPolicyRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicyRuleAsync(new CreateGatewaySecurityPolicyRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewaySecurityPolicyRule = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRule, nameof(gatewaySecurityPolicyRule)),
                GatewaySecurityPolicyRuleId = gatewaySecurityPolicyRuleId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent where this rule will be created.
        /// Format :
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*
        /// </param>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. The rule to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyRuleId">
        /// The ID to use for the rule, which will become the final component of
        /// the rule's resource name.
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(string parent, GatewaySecurityPolicyRule gatewaySecurityPolicyRule, string gatewaySecurityPolicyRuleId, st::CancellationToken cancellationToken) =>
            CreateGatewaySecurityPolicyRuleAsync(parent, gatewaySecurityPolicyRule, gatewaySecurityPolicyRuleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent where this rule will be created.
        /// Format :
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*
        /// </param>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. The rule to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyRuleId">
        /// The ID to use for the rule, which will become the final component of
        /// the rule's resource name.
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> CreateGatewaySecurityPolicyRule(GatewaySecurityPolicyName parent, GatewaySecurityPolicyRule gatewaySecurityPolicyRule, string gatewaySecurityPolicyRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicyRule(new CreateGatewaySecurityPolicyRuleRequest
            {
                ParentAsGatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewaySecurityPolicyRule = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRule, nameof(gatewaySecurityPolicyRule)),
                GatewaySecurityPolicyRuleId = gatewaySecurityPolicyRuleId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent where this rule will be created.
        /// Format :
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*
        /// </param>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. The rule to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyRuleId">
        /// The ID to use for the rule, which will become the final component of
        /// the rule's resource name.
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyName parent, GatewaySecurityPolicyRule gatewaySecurityPolicyRule, string gatewaySecurityPolicyRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewaySecurityPolicyRuleAsync(new CreateGatewaySecurityPolicyRuleRequest
            {
                ParentAsGatewaySecurityPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewaySecurityPolicyRule = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRule, nameof(gatewaySecurityPolicyRule)),
                GatewaySecurityPolicyRuleId = gatewaySecurityPolicyRuleId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent where this rule will be created.
        /// Format :
        /// projects/{project}/location/{location}/gatewaySecurityPolicies/*
        /// </param>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. The rule to be created.
        /// </param>
        /// <param name="gatewaySecurityPolicyRuleId">
        /// The ID to use for the rule, which will become the final component of
        /// the rule's resource name.
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyName parent, GatewaySecurityPolicyRule gatewaySecurityPolicyRule, string gatewaySecurityPolicyRuleId, st::CancellationToken cancellationToken) =>
            CreateGatewaySecurityPolicyRuleAsync(parent, gatewaySecurityPolicyRule, gatewaySecurityPolicyRuleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> UpdateGatewaySecurityPolicyRule(UpdateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> UpdateGatewaySecurityPolicyRuleAsync(UpdateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> UpdateGatewaySecurityPolicyRuleAsync(UpdateGatewaySecurityPolicyRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateGatewaySecurityPolicyRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGatewaySecurityPolicyRule</c>.</summary>
        public virtual lro::OperationsClient UpdateGatewaySecurityPolicyRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGatewaySecurityPolicyRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> PollOnceUpdateGatewaySecurityPolicyRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewaySecurityPolicyRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGatewaySecurityPolicyRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> PollOnceUpdateGatewaySecurityPolicyRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewaySecurityPolicyRuleOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. Updated GatewaySecurityPolicyRule resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GatewaySecurityPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> UpdateGatewaySecurityPolicyRule(GatewaySecurityPolicyRule gatewaySecurityPolicyRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGatewaySecurityPolicyRule(new UpdateGatewaySecurityPolicyRuleRequest
            {
                UpdateMask = updateMask,
                GatewaySecurityPolicyRule = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRule, nameof(gatewaySecurityPolicyRule)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. Updated GatewaySecurityPolicyRule resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GatewaySecurityPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> UpdateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRule gatewaySecurityPolicyRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGatewaySecurityPolicyRuleAsync(new UpdateGatewaySecurityPolicyRuleRequest
            {
                UpdateMask = updateMask,
                GatewaySecurityPolicyRule = gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyRule, nameof(gatewaySecurityPolicyRule)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="gatewaySecurityPolicyRule">
        /// Required. Updated GatewaySecurityPolicyRule resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// GatewaySecurityPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> UpdateGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRule gatewaySecurityPolicyRule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGatewaySecurityPolicyRuleAsync(gatewaySecurityPolicyRule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicyRule(DeleteGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(DeleteGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(DeleteGatewaySecurityPolicyRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteGatewaySecurityPolicyRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGatewaySecurityPolicyRule</c>.</summary>
        public virtual lro::OperationsClient DeleteGatewaySecurityPolicyRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGatewaySecurityPolicyRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGatewaySecurityPolicyRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewaySecurityPolicyRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGatewaySecurityPolicyRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGatewaySecurityPolicyRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewaySecurityPolicyRuleOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicyRule to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}/rules/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicyRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicyRule(new DeleteGatewaySecurityPolicyRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicyRule to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}/rules/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicyRuleAsync(new DeleteGatewaySecurityPolicyRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicyRule to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}/rules/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGatewaySecurityPolicyRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicyRule to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}/rules/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicyRule(GatewaySecurityPolicyRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicyRule(new DeleteGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicyRule to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}/rules/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewaySecurityPolicyRuleAsync(new DeleteGatewaySecurityPolicyRuleRequest
            {
                GatewaySecurityPolicyRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the GatewaySecurityPolicyRule to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/gatewaySecurityPolicies/{gatewaySecurityPolicy}/rules/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(GatewaySecurityPolicyRuleName name, st::CancellationToken cancellationToken) =>
            DeleteGatewaySecurityPolicyRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UrlList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUrlListsResponse, UrlList> ListUrlLists(ListUrlListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UrlList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUrlListsResponse, UrlList> ListUrlListsAsync(ListUrlListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the UrlLists should
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
        /// <returns>A pageable sequence of <see cref="UrlList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUrlListsResponse, UrlList> ListUrlLists(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUrlListsRequest request = new ListUrlListsRequest
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
            return ListUrlLists(request, callSettings);
        }

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the UrlLists should
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
        /// <returns>A pageable asynchronous sequence of <see cref="UrlList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUrlListsResponse, UrlList> ListUrlListsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUrlListsRequest request = new ListUrlListsRequest
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
            return ListUrlListsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the UrlLists should
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
        /// <returns>A pageable sequence of <see cref="UrlList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUrlListsResponse, UrlList> ListUrlLists(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUrlListsRequest request = new ListUrlListsRequest
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
            return ListUrlLists(request, callSettings);
        }

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the UrlLists should
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
        /// <returns>A pageable asynchronous sequence of <see cref="UrlList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUrlListsResponse, UrlList> ListUrlListsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUrlListsRequest request = new ListUrlListsRequest
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
            return ListUrlListsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlList GetUrlList(GetUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlList> GetUrlListAsync(GetUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlList> GetUrlListAsync(GetUrlListRequest request, st::CancellationToken cancellationToken) =>
            GetUrlListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to get. Must be in the format
        /// `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlList GetUrlList(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUrlList(new GetUrlListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to get. Must be in the format
        /// `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlList> GetUrlListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUrlListAsync(new GetUrlListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to get. Must be in the format
        /// `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlList> GetUrlListAsync(string name, st::CancellationToken cancellationToken) =>
            GetUrlListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to get. Must be in the format
        /// `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlList GetUrlList(UrlListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUrlList(new GetUrlListRequest
            {
                UrlListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to get. Must be in the format
        /// `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlList> GetUrlListAsync(UrlListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUrlListAsync(new GetUrlListRequest
            {
                UrlListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to get. Must be in the format
        /// `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlList> GetUrlListAsync(UrlListName name, st::CancellationToken cancellationToken) =>
            GetUrlListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> CreateUrlList(CreateUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(CreateUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(CreateUrlListRequest request, st::CancellationToken cancellationToken) =>
            CreateUrlListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateUrlList</c>.</summary>
        public virtual lro::OperationsClient CreateUrlListOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateUrlList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> PollOnceCreateUrlList(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UrlList, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateUrlListOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateUrlList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> PollOnceCreateUrlListAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UrlList, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateUrlListOperationsClient, callSettings);

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the UrlList. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="urlList">
        /// Required. UrlList resource to be created.
        /// </param>
        /// <param name="urlListId">
        /// Required. Short name of the UrlList resource to be created. This value
        /// should be 1-63 characters long, containing only letters, numbers, hyphens,
        /// and underscores, and should not start with a number. E.g. "url_list".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> CreateUrlList(string parent, UrlList urlList, string urlListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUrlList(new CreateUrlListRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UrlListId = gax::GaxPreconditions.CheckNotNullOrEmpty(urlListId, nameof(urlListId)),
                UrlList = gax::GaxPreconditions.CheckNotNull(urlList, nameof(urlList)),
            }, callSettings);

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the UrlList. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="urlList">
        /// Required. UrlList resource to be created.
        /// </param>
        /// <param name="urlListId">
        /// Required. Short name of the UrlList resource to be created. This value
        /// should be 1-63 characters long, containing only letters, numbers, hyphens,
        /// and underscores, and should not start with a number. E.g. "url_list".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(string parent, UrlList urlList, string urlListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUrlListAsync(new CreateUrlListRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UrlListId = gax::GaxPreconditions.CheckNotNullOrEmpty(urlListId, nameof(urlListId)),
                UrlList = gax::GaxPreconditions.CheckNotNull(urlList, nameof(urlList)),
            }, callSettings);

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the UrlList. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="urlList">
        /// Required. UrlList resource to be created.
        /// </param>
        /// <param name="urlListId">
        /// Required. Short name of the UrlList resource to be created. This value
        /// should be 1-63 characters long, containing only letters, numbers, hyphens,
        /// and underscores, and should not start with a number. E.g. "url_list".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(string parent, UrlList urlList, string urlListId, st::CancellationToken cancellationToken) =>
            CreateUrlListAsync(parent, urlList, urlListId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the UrlList. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="urlList">
        /// Required. UrlList resource to be created.
        /// </param>
        /// <param name="urlListId">
        /// Required. Short name of the UrlList resource to be created. This value
        /// should be 1-63 characters long, containing only letters, numbers, hyphens,
        /// and underscores, and should not start with a number. E.g. "url_list".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> CreateUrlList(gagr::LocationName parent, UrlList urlList, string urlListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUrlList(new CreateUrlListRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UrlListId = gax::GaxPreconditions.CheckNotNullOrEmpty(urlListId, nameof(urlListId)),
                UrlList = gax::GaxPreconditions.CheckNotNull(urlList, nameof(urlList)),
            }, callSettings);

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the UrlList. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="urlList">
        /// Required. UrlList resource to be created.
        /// </param>
        /// <param name="urlListId">
        /// Required. Short name of the UrlList resource to be created. This value
        /// should be 1-63 characters long, containing only letters, numbers, hyphens,
        /// and underscores, and should not start with a number. E.g. "url_list".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(gagr::LocationName parent, UrlList urlList, string urlListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUrlListAsync(new CreateUrlListRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UrlListId = gax::GaxPreconditions.CheckNotNullOrEmpty(urlListId, nameof(urlListId)),
                UrlList = gax::GaxPreconditions.CheckNotNull(urlList, nameof(urlList)),
            }, callSettings);

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the UrlList. Must be in
        /// the format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="urlList">
        /// Required. UrlList resource to be created.
        /// </param>
        /// <param name="urlListId">
        /// Required. Short name of the UrlList resource to be created. This value
        /// should be 1-63 characters long, containing only letters, numbers, hyphens,
        /// and underscores, and should not start with a number. E.g. "url_list".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(gagr::LocationName parent, UrlList urlList, string urlListId, st::CancellationToken cancellationToken) =>
            CreateUrlListAsync(parent, urlList, urlListId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> UpdateUrlList(UpdateUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> UpdateUrlListAsync(UpdateUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> UpdateUrlListAsync(UpdateUrlListRequest request, st::CancellationToken cancellationToken) =>
            UpdateUrlListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateUrlList</c>.</summary>
        public virtual lro::OperationsClient UpdateUrlListOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateUrlList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> PollOnceUpdateUrlList(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UrlList, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateUrlListOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateUrlList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> PollOnceUpdateUrlListAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UrlList, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateUrlListOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="urlList">
        /// Required. Updated UrlList resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// UrlList resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UrlList, OperationMetadata> UpdateUrlList(UrlList urlList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUrlList(new UpdateUrlListRequest
            {
                UpdateMask = updateMask,
                UrlList = gax::GaxPreconditions.CheckNotNull(urlList, nameof(urlList)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="urlList">
        /// Required. Updated UrlList resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// UrlList resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> UpdateUrlListAsync(UrlList urlList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUrlListAsync(new UpdateUrlListRequest
            {
                UpdateMask = updateMask,
                UrlList = gax::GaxPreconditions.CheckNotNull(urlList, nameof(urlList)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="urlList">
        /// Required. Updated UrlList resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// UrlList resource by the update.  The fields
        /// specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all fields will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UrlList, OperationMetadata>> UpdateUrlListAsync(UrlList urlList, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUrlListAsync(urlList, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUrlList(DeleteUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(DeleteUrlListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(DeleteUrlListRequest request, st::CancellationToken cancellationToken) =>
            DeleteUrlListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteUrlList</c>.</summary>
        public virtual lro::OperationsClient DeleteUrlListOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteUrlList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteUrlList(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteUrlListOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteUrlList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteUrlListAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteUrlListOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to delete. Must be in
        /// the format `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUrlList(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUrlList(new DeleteUrlListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to delete. Must be in
        /// the format `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUrlListAsync(new DeleteUrlListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to delete. Must be in
        /// the format `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUrlListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to delete. Must be in
        /// the format `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUrlList(UrlListName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUrlList(new DeleteUrlListRequest
            {
                UrlListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to delete. Must be in
        /// the format `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(UrlListName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUrlListAsync(new DeleteUrlListRequest
            {
                UrlListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the UrlList to delete. Must be in
        /// the format `projects/*/locations/{location}/urlLists/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(UrlListName name, st::CancellationToken cancellationToken) =>
            DeleteUrlListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPolicies(ListTlsInspectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPoliciesAsync(ListTlsInspectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsInspectionPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsInspectionPoliciesRequest request = new ListTlsInspectionPoliciesRequest
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
            return ListTlsInspectionPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsInspectionPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsInspectionPoliciesRequest request = new ListTlsInspectionPoliciesRequest
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
            return ListTlsInspectionPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsInspectionPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsInspectionPoliciesRequest request = new ListTlsInspectionPoliciesRequest
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
            return ListTlsInspectionPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the TlsInspectionPolicies
        /// should be listed, specified in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTlsInspectionPoliciesRequest request = new ListTlsInspectionPoliciesRequest
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
            return ListTlsInspectionPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TlsInspectionPolicy GetTlsInspectionPolicy(GetTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(GetTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(GetTlsInspectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetTlsInspectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TlsInspectionPolicy GetTlsInspectionPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsInspectionPolicy(new GetTlsInspectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsInspectionPolicyAsync(new GetTlsInspectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetTlsInspectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TlsInspectionPolicy GetTlsInspectionPolicy(TlsInspectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsInspectionPolicy(new GetTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(TlsInspectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTlsInspectionPolicyAsync(new GetTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to get. Must be in the format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(TlsInspectionPolicyName name, st::CancellationToken cancellationToken) =>
            GetTlsInspectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> CreateTlsInspectionPolicy(CreateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(CreateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(CreateTlsInspectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateTlsInspectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTlsInspectionPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateTlsInspectionPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTlsInspectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> PollOnceCreateTlsInspectionPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsInspectionPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTlsInspectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTlsInspectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> PollOnceCreateTlsInspectionPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsInspectionPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTlsInspectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsInspectionPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="tlsInspectionPolicy">
        /// Required. TlsInspectionPolicy resource to be created.
        /// </param>
        /// <param name="tlsInspectionPolicyId">
        /// Required. Short name of the TlsInspectionPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "tls_inspection_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> CreateTlsInspectionPolicy(string parent, TlsInspectionPolicy tlsInspectionPolicy, string tlsInspectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsInspectionPolicy(new CreateTlsInspectionPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TlsInspectionPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)),
                TlsInspectionPolicy = gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicy, nameof(tlsInspectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsInspectionPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="tlsInspectionPolicy">
        /// Required. TlsInspectionPolicy resource to be created.
        /// </param>
        /// <param name="tlsInspectionPolicyId">
        /// Required. Short name of the TlsInspectionPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "tls_inspection_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(string parent, TlsInspectionPolicy tlsInspectionPolicy, string tlsInspectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsInspectionPolicyAsync(new CreateTlsInspectionPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TlsInspectionPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)),
                TlsInspectionPolicy = gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicy, nameof(tlsInspectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsInspectionPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="tlsInspectionPolicy">
        /// Required. TlsInspectionPolicy resource to be created.
        /// </param>
        /// <param name="tlsInspectionPolicyId">
        /// Required. Short name of the TlsInspectionPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "tls_inspection_policy1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(string parent, TlsInspectionPolicy tlsInspectionPolicy, string tlsInspectionPolicyId, st::CancellationToken cancellationToken) =>
            CreateTlsInspectionPolicyAsync(parent, tlsInspectionPolicy, tlsInspectionPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsInspectionPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="tlsInspectionPolicy">
        /// Required. TlsInspectionPolicy resource to be created.
        /// </param>
        /// <param name="tlsInspectionPolicyId">
        /// Required. Short name of the TlsInspectionPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "tls_inspection_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> CreateTlsInspectionPolicy(gagr::LocationName parent, TlsInspectionPolicy tlsInspectionPolicy, string tlsInspectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsInspectionPolicy(new CreateTlsInspectionPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TlsInspectionPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)),
                TlsInspectionPolicy = gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicy, nameof(tlsInspectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsInspectionPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="tlsInspectionPolicy">
        /// Required. TlsInspectionPolicy resource to be created.
        /// </param>
        /// <param name="tlsInspectionPolicyId">
        /// Required. Short name of the TlsInspectionPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "tls_inspection_policy1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(gagr::LocationName parent, TlsInspectionPolicy tlsInspectionPolicy, string tlsInspectionPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTlsInspectionPolicyAsync(new CreateTlsInspectionPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TlsInspectionPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)),
                TlsInspectionPolicy = gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicy, nameof(tlsInspectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the TlsInspectionPolicy. Must be in the
        /// format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="tlsInspectionPolicy">
        /// Required. TlsInspectionPolicy resource to be created.
        /// </param>
        /// <param name="tlsInspectionPolicyId">
        /// Required. Short name of the TlsInspectionPolicy resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "tls_inspection_policy1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(gagr::LocationName parent, TlsInspectionPolicy tlsInspectionPolicy, string tlsInspectionPolicyId, st::CancellationToken cancellationToken) =>
            CreateTlsInspectionPolicyAsync(parent, tlsInspectionPolicy, tlsInspectionPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> UpdateTlsInspectionPolicy(UpdateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> UpdateTlsInspectionPolicyAsync(UpdateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> UpdateTlsInspectionPolicyAsync(UpdateTlsInspectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateTlsInspectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTlsInspectionPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateTlsInspectionPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTlsInspectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> PollOnceUpdateTlsInspectionPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsInspectionPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTlsInspectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTlsInspectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> PollOnceUpdateTlsInspectionPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TlsInspectionPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTlsInspectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="tlsInspectionPolicy">
        /// Required. Updated TlsInspectionPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TlsInspectionPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TlsInspectionPolicy, OperationMetadata> UpdateTlsInspectionPolicy(TlsInspectionPolicy tlsInspectionPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTlsInspectionPolicy(new UpdateTlsInspectionPolicyRequest
            {
                UpdateMask = updateMask,
                TlsInspectionPolicy = gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicy, nameof(tlsInspectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="tlsInspectionPolicy">
        /// Required. Updated TlsInspectionPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TlsInspectionPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> UpdateTlsInspectionPolicyAsync(TlsInspectionPolicy tlsInspectionPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTlsInspectionPolicyAsync(new UpdateTlsInspectionPolicyRequest
            {
                UpdateMask = updateMask,
                TlsInspectionPolicy = gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicy, nameof(tlsInspectionPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="tlsInspectionPolicy">
        /// Required. Updated TlsInspectionPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TlsInspectionPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> UpdateTlsInspectionPolicyAsync(TlsInspectionPolicy tlsInspectionPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTlsInspectionPolicyAsync(tlsInspectionPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsInspectionPolicy(DeleteTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(DeleteTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(DeleteTlsInspectionPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteTlsInspectionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTlsInspectionPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteTlsInspectionPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTlsInspectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTlsInspectionPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTlsInspectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTlsInspectionPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTlsInspectionPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTlsInspectionPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsInspectionPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsInspectionPolicy(new DeleteTlsInspectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsInspectionPolicyAsync(new DeleteTlsInspectionPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTlsInspectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsInspectionPolicy(TlsInspectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsInspectionPolicy(new DeleteTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(TlsInspectionPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTlsInspectionPolicyAsync(new DeleteTlsInspectionPolicyRequest
            {
                TlsInspectionPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the TlsInspectionPolicy to delete. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(TlsInspectionPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteTlsInspectionPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPolicies(ListAuthzPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPoliciesAsync(ListAuthzPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `AuthzPolicy` resources
        /// are listed, specified in the following format:
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
        /// <returns>A pageable sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthzPoliciesRequest request = new ListAuthzPoliciesRequest
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
            return ListAuthzPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `AuthzPolicy` resources
        /// are listed, specified in the following format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthzPoliciesRequest request = new ListAuthzPoliciesRequest
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
            return ListAuthzPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `AuthzPolicy` resources
        /// are listed, specified in the following format:
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
        /// <returns>A pageable sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthzPoliciesRequest request = new ListAuthzPoliciesRequest
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
            return ListAuthzPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `AuthzPolicy` resources
        /// are listed, specified in the following format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthzPoliciesRequest request = new ListAuthzPoliciesRequest
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
            return ListAuthzPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthzPolicy GetAuthzPolicy(GetAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthzPolicy> GetAuthzPolicyAsync(GetAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthzPolicy> GetAuthzPolicyAsync(GetAuthzPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAuthzPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `AuthzPolicy` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthzPolicy GetAuthzPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthzPolicy(new GetAuthzPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `AuthzPolicy` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthzPolicy> GetAuthzPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthzPolicyAsync(new GetAuthzPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `AuthzPolicy` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthzPolicy> GetAuthzPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAuthzPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `AuthzPolicy` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthzPolicy GetAuthzPolicy(AuthzPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthzPolicy(new GetAuthzPolicyRequest
            {
                AuthzPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `AuthzPolicy` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthzPolicy> GetAuthzPolicyAsync(AuthzPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthzPolicyAsync(new GetAuthzPolicyRequest
            {
                AuthzPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `AuthzPolicy` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthzPolicy> GetAuthzPolicyAsync(AuthzPolicyName name, st::CancellationToken cancellationToken) =>
            GetAuthzPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> CreateAuthzPolicy(CreateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(CreateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(CreateAuthzPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateAuthzPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAuthzPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateAuthzPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAuthzPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> PollOnceCreateAuthzPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthzPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAuthzPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAuthzPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> PollOnceCreateAuthzPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthzPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAuthzPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `AuthzPolicy` resource. Must be in
        /// the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="authzPolicyId">
        /// Required. User-provided ID of the `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> CreateAuthzPolicy(string parent, AuthzPolicy authzPolicy, string authzPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthzPolicy(new CreateAuthzPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AuthzPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authzPolicyId, nameof(authzPolicyId)),
                AuthzPolicy = gax::GaxPreconditions.CheckNotNull(authzPolicy, nameof(authzPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `AuthzPolicy` resource. Must be in
        /// the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="authzPolicyId">
        /// Required. User-provided ID of the `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(string parent, AuthzPolicy authzPolicy, string authzPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthzPolicyAsync(new CreateAuthzPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AuthzPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authzPolicyId, nameof(authzPolicyId)),
                AuthzPolicy = gax::GaxPreconditions.CheckNotNull(authzPolicy, nameof(authzPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `AuthzPolicy` resource. Must be in
        /// the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="authzPolicyId">
        /// Required. User-provided ID of the `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(string parent, AuthzPolicy authzPolicy, string authzPolicyId, st::CancellationToken cancellationToken) =>
            CreateAuthzPolicyAsync(parent, authzPolicy, authzPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `AuthzPolicy` resource. Must be in
        /// the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="authzPolicyId">
        /// Required. User-provided ID of the `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> CreateAuthzPolicy(gagr::LocationName parent, AuthzPolicy authzPolicy, string authzPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthzPolicy(new CreateAuthzPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AuthzPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authzPolicyId, nameof(authzPolicyId)),
                AuthzPolicy = gax::GaxPreconditions.CheckNotNull(authzPolicy, nameof(authzPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `AuthzPolicy` resource. Must be in
        /// the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="authzPolicyId">
        /// Required. User-provided ID of the `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(gagr::LocationName parent, AuthzPolicy authzPolicy, string authzPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAuthzPolicyAsync(new CreateAuthzPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AuthzPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(authzPolicyId, nameof(authzPolicyId)),
                AuthzPolicy = gax::GaxPreconditions.CheckNotNull(authzPolicy, nameof(authzPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `AuthzPolicy` resource. Must be in
        /// the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="authzPolicyId">
        /// Required. User-provided ID of the `AuthzPolicy` resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(gagr::LocationName parent, AuthzPolicy authzPolicy, string authzPolicyId, st::CancellationToken cancellationToken) =>
            CreateAuthzPolicyAsync(parent, authzPolicy, authzPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> UpdateAuthzPolicy(UpdateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> UpdateAuthzPolicyAsync(UpdateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> UpdateAuthzPolicyAsync(UpdateAuthzPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAuthzPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAuthzPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateAuthzPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAuthzPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> PollOnceUpdateAuthzPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthzPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAuthzPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAuthzPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> PollOnceUpdateAuthzPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthzPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAuthzPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Used to specify the fields to be overwritten in the
        /// `AuthzPolicy` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthzPolicy, OperationMetadata> UpdateAuthzPolicy(AuthzPolicy authzPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAuthzPolicy(new UpdateAuthzPolicyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                AuthzPolicy = gax::GaxPreconditions.CheckNotNull(authzPolicy, nameof(authzPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Used to specify the fields to be overwritten in the
        /// `AuthzPolicy` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> UpdateAuthzPolicyAsync(AuthzPolicy authzPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAuthzPolicyAsync(new UpdateAuthzPolicyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                AuthzPolicy = gax::GaxPreconditions.CheckNotNull(authzPolicy, nameof(authzPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="authzPolicy">
        /// Required. `AuthzPolicy` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Used to specify the fields to be overwritten in the
        /// `AuthzPolicy` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> UpdateAuthzPolicyAsync(AuthzPolicy authzPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAuthzPolicyAsync(authzPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthzPolicy(DeleteAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(DeleteAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(DeleteAuthzPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAuthzPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAuthzPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteAuthzPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAuthzPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAuthzPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAuthzPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAuthzPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAuthzPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAuthzPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `AuthzPolicy` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthzPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthzPolicy(new DeleteAuthzPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `AuthzPolicy` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthzPolicyAsync(new DeleteAuthzPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `AuthzPolicy` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAuthzPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `AuthzPolicy` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthzPolicy(AuthzPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthzPolicy(new DeleteAuthzPolicyRequest
            {
                AuthzPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `AuthzPolicy` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(AuthzPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthzPolicyAsync(new DeleteAuthzPolicyRequest
            {
                AuthzPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `AuthzPolicy` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/authzPolicies/{authz_policy}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(AuthzPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAuthzPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NetworkSecurity client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Network Security API provides resources to configure authentication and
    /// authorization policies. Refer to per API resource documentation for more
    /// information.
    /// </remarks>
    public sealed partial class NetworkSecurityClientImpl : NetworkSecurityClient
    {
        private readonly gaxgrpc::ApiCall<ListAuthorizationPoliciesRequest, ListAuthorizationPoliciesResponse> _callListAuthorizationPolicies;

        private readonly gaxgrpc::ApiCall<GetAuthorizationPolicyRequest, AuthorizationPolicy> _callGetAuthorizationPolicy;

        private readonly gaxgrpc::ApiCall<CreateAuthorizationPolicyRequest, lro::Operation> _callCreateAuthorizationPolicy;

        private readonly gaxgrpc::ApiCall<UpdateAuthorizationPolicyRequest, lro::Operation> _callUpdateAuthorizationPolicy;

        private readonly gaxgrpc::ApiCall<DeleteAuthorizationPolicyRequest, lro::Operation> _callDeleteAuthorizationPolicy;

        private readonly gaxgrpc::ApiCall<ListBackendAuthenticationConfigsRequest, ListBackendAuthenticationConfigsResponse> _callListBackendAuthenticationConfigs;

        private readonly gaxgrpc::ApiCall<GetBackendAuthenticationConfigRequest, BackendAuthenticationConfig> _callGetBackendAuthenticationConfig;

        private readonly gaxgrpc::ApiCall<CreateBackendAuthenticationConfigRequest, lro::Operation> _callCreateBackendAuthenticationConfig;

        private readonly gaxgrpc::ApiCall<UpdateBackendAuthenticationConfigRequest, lro::Operation> _callUpdateBackendAuthenticationConfig;

        private readonly gaxgrpc::ApiCall<DeleteBackendAuthenticationConfigRequest, lro::Operation> _callDeleteBackendAuthenticationConfig;

        private readonly gaxgrpc::ApiCall<ListServerTlsPoliciesRequest, ListServerTlsPoliciesResponse> _callListServerTlsPolicies;

        private readonly gaxgrpc::ApiCall<GetServerTlsPolicyRequest, ServerTlsPolicy> _callGetServerTlsPolicy;

        private readonly gaxgrpc::ApiCall<CreateServerTlsPolicyRequest, lro::Operation> _callCreateServerTlsPolicy;

        private readonly gaxgrpc::ApiCall<UpdateServerTlsPolicyRequest, lro::Operation> _callUpdateServerTlsPolicy;

        private readonly gaxgrpc::ApiCall<DeleteServerTlsPolicyRequest, lro::Operation> _callDeleteServerTlsPolicy;

        private readonly gaxgrpc::ApiCall<ListClientTlsPoliciesRequest, ListClientTlsPoliciesResponse> _callListClientTlsPolicies;

        private readonly gaxgrpc::ApiCall<GetClientTlsPolicyRequest, ClientTlsPolicy> _callGetClientTlsPolicy;

        private readonly gaxgrpc::ApiCall<CreateClientTlsPolicyRequest, lro::Operation> _callCreateClientTlsPolicy;

        private readonly gaxgrpc::ApiCall<UpdateClientTlsPolicyRequest, lro::Operation> _callUpdateClientTlsPolicy;

        private readonly gaxgrpc::ApiCall<DeleteClientTlsPolicyRequest, lro::Operation> _callDeleteClientTlsPolicy;

        private readonly gaxgrpc::ApiCall<ListGatewaySecurityPoliciesRequest, ListGatewaySecurityPoliciesResponse> _callListGatewaySecurityPolicies;

        private readonly gaxgrpc::ApiCall<GetGatewaySecurityPolicyRequest, GatewaySecurityPolicy> _callGetGatewaySecurityPolicy;

        private readonly gaxgrpc::ApiCall<CreateGatewaySecurityPolicyRequest, lro::Operation> _callCreateGatewaySecurityPolicy;

        private readonly gaxgrpc::ApiCall<UpdateGatewaySecurityPolicyRequest, lro::Operation> _callUpdateGatewaySecurityPolicy;

        private readonly gaxgrpc::ApiCall<DeleteGatewaySecurityPolicyRequest, lro::Operation> _callDeleteGatewaySecurityPolicy;

        private readonly gaxgrpc::ApiCall<ListGatewaySecurityPolicyRulesRequest, ListGatewaySecurityPolicyRulesResponse> _callListGatewaySecurityPolicyRules;

        private readonly gaxgrpc::ApiCall<GetGatewaySecurityPolicyRuleRequest, GatewaySecurityPolicyRule> _callGetGatewaySecurityPolicyRule;

        private readonly gaxgrpc::ApiCall<CreateGatewaySecurityPolicyRuleRequest, lro::Operation> _callCreateGatewaySecurityPolicyRule;

        private readonly gaxgrpc::ApiCall<UpdateGatewaySecurityPolicyRuleRequest, lro::Operation> _callUpdateGatewaySecurityPolicyRule;

        private readonly gaxgrpc::ApiCall<DeleteGatewaySecurityPolicyRuleRequest, lro::Operation> _callDeleteGatewaySecurityPolicyRule;

        private readonly gaxgrpc::ApiCall<ListUrlListsRequest, ListUrlListsResponse> _callListUrlLists;

        private readonly gaxgrpc::ApiCall<GetUrlListRequest, UrlList> _callGetUrlList;

        private readonly gaxgrpc::ApiCall<CreateUrlListRequest, lro::Operation> _callCreateUrlList;

        private readonly gaxgrpc::ApiCall<UpdateUrlListRequest, lro::Operation> _callUpdateUrlList;

        private readonly gaxgrpc::ApiCall<DeleteUrlListRequest, lro::Operation> _callDeleteUrlList;

        private readonly gaxgrpc::ApiCall<ListTlsInspectionPoliciesRequest, ListTlsInspectionPoliciesResponse> _callListTlsInspectionPolicies;

        private readonly gaxgrpc::ApiCall<GetTlsInspectionPolicyRequest, TlsInspectionPolicy> _callGetTlsInspectionPolicy;

        private readonly gaxgrpc::ApiCall<CreateTlsInspectionPolicyRequest, lro::Operation> _callCreateTlsInspectionPolicy;

        private readonly gaxgrpc::ApiCall<UpdateTlsInspectionPolicyRequest, lro::Operation> _callUpdateTlsInspectionPolicy;

        private readonly gaxgrpc::ApiCall<DeleteTlsInspectionPolicyRequest, lro::Operation> _callDeleteTlsInspectionPolicy;

        private readonly gaxgrpc::ApiCall<ListAuthzPoliciesRequest, ListAuthzPoliciesResponse> _callListAuthzPolicies;

        private readonly gaxgrpc::ApiCall<GetAuthzPolicyRequest, AuthzPolicy> _callGetAuthzPolicy;

        private readonly gaxgrpc::ApiCall<CreateAuthzPolicyRequest, lro::Operation> _callCreateAuthzPolicy;

        private readonly gaxgrpc::ApiCall<UpdateAuthzPolicyRequest, lro::Operation> _callUpdateAuthzPolicy;

        private readonly gaxgrpc::ApiCall<DeleteAuthzPolicyRequest, lro::Operation> _callDeleteAuthzPolicy;

        /// <summary>
        /// Constructs a client wrapper for the NetworkSecurity service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetworkSecuritySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetworkSecurityClientImpl(NetworkSecurity.NetworkSecurityClient grpcClient, NetworkSecuritySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetworkSecuritySettings effectiveSettings = settings ?? NetworkSecuritySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAuthorizationPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAuthorizationPolicyOperationsSettings, logger);
            UpdateAuthorizationPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAuthorizationPolicyOperationsSettings, logger);
            DeleteAuthorizationPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAuthorizationPolicyOperationsSettings, logger);
            CreateBackendAuthenticationConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackendAuthenticationConfigOperationsSettings, logger);
            UpdateBackendAuthenticationConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackendAuthenticationConfigOperationsSettings, logger);
            DeleteBackendAuthenticationConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackendAuthenticationConfigOperationsSettings, logger);
            CreateServerTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServerTlsPolicyOperationsSettings, logger);
            UpdateServerTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServerTlsPolicyOperationsSettings, logger);
            DeleteServerTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServerTlsPolicyOperationsSettings, logger);
            CreateClientTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClientTlsPolicyOperationsSettings, logger);
            UpdateClientTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClientTlsPolicyOperationsSettings, logger);
            DeleteClientTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClientTlsPolicyOperationsSettings, logger);
            CreateGatewaySecurityPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGatewaySecurityPolicyOperationsSettings, logger);
            UpdateGatewaySecurityPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGatewaySecurityPolicyOperationsSettings, logger);
            DeleteGatewaySecurityPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGatewaySecurityPolicyOperationsSettings, logger);
            CreateGatewaySecurityPolicyRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGatewaySecurityPolicyRuleOperationsSettings, logger);
            UpdateGatewaySecurityPolicyRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGatewaySecurityPolicyRuleOperationsSettings, logger);
            DeleteGatewaySecurityPolicyRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGatewaySecurityPolicyRuleOperationsSettings, logger);
            CreateUrlListOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateUrlListOperationsSettings, logger);
            UpdateUrlListOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateUrlListOperationsSettings, logger);
            DeleteUrlListOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteUrlListOperationsSettings, logger);
            CreateTlsInspectionPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTlsInspectionPolicyOperationsSettings, logger);
            UpdateTlsInspectionPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTlsInspectionPolicyOperationsSettings, logger);
            DeleteTlsInspectionPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTlsInspectionPolicyOperationsSettings, logger);
            CreateAuthzPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAuthzPolicyOperationsSettings, logger);
            UpdateAuthzPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAuthzPolicyOperationsSettings, logger);
            DeleteAuthzPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAuthzPolicyOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListAuthorizationPolicies = clientHelper.BuildApiCall<ListAuthorizationPoliciesRequest, ListAuthorizationPoliciesResponse>("ListAuthorizationPolicies", grpcClient.ListAuthorizationPoliciesAsync, grpcClient.ListAuthorizationPolicies, effectiveSettings.ListAuthorizationPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAuthorizationPolicies);
            Modify_ListAuthorizationPoliciesApiCall(ref _callListAuthorizationPolicies);
            _callGetAuthorizationPolicy = clientHelper.BuildApiCall<GetAuthorizationPolicyRequest, AuthorizationPolicy>("GetAuthorizationPolicy", grpcClient.GetAuthorizationPolicyAsync, grpcClient.GetAuthorizationPolicy, effectiveSettings.GetAuthorizationPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAuthorizationPolicy);
            Modify_GetAuthorizationPolicyApiCall(ref _callGetAuthorizationPolicy);
            _callCreateAuthorizationPolicy = clientHelper.BuildApiCall<CreateAuthorizationPolicyRequest, lro::Operation>("CreateAuthorizationPolicy", grpcClient.CreateAuthorizationPolicyAsync, grpcClient.CreateAuthorizationPolicy, effectiveSettings.CreateAuthorizationPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAuthorizationPolicy);
            Modify_CreateAuthorizationPolicyApiCall(ref _callCreateAuthorizationPolicy);
            _callUpdateAuthorizationPolicy = clientHelper.BuildApiCall<UpdateAuthorizationPolicyRequest, lro::Operation>("UpdateAuthorizationPolicy", grpcClient.UpdateAuthorizationPolicyAsync, grpcClient.UpdateAuthorizationPolicy, effectiveSettings.UpdateAuthorizationPolicySettings).WithGoogleRequestParam("authorization_policy.name", request => request.AuthorizationPolicy?.Name);
            Modify_ApiCall(ref _callUpdateAuthorizationPolicy);
            Modify_UpdateAuthorizationPolicyApiCall(ref _callUpdateAuthorizationPolicy);
            _callDeleteAuthorizationPolicy = clientHelper.BuildApiCall<DeleteAuthorizationPolicyRequest, lro::Operation>("DeleteAuthorizationPolicy", grpcClient.DeleteAuthorizationPolicyAsync, grpcClient.DeleteAuthorizationPolicy, effectiveSettings.DeleteAuthorizationPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAuthorizationPolicy);
            Modify_DeleteAuthorizationPolicyApiCall(ref _callDeleteAuthorizationPolicy);
            _callListBackendAuthenticationConfigs = clientHelper.BuildApiCall<ListBackendAuthenticationConfigsRequest, ListBackendAuthenticationConfigsResponse>("ListBackendAuthenticationConfigs", grpcClient.ListBackendAuthenticationConfigsAsync, grpcClient.ListBackendAuthenticationConfigs, effectiveSettings.ListBackendAuthenticationConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackendAuthenticationConfigs);
            Modify_ListBackendAuthenticationConfigsApiCall(ref _callListBackendAuthenticationConfigs);
            _callGetBackendAuthenticationConfig = clientHelper.BuildApiCall<GetBackendAuthenticationConfigRequest, BackendAuthenticationConfig>("GetBackendAuthenticationConfig", grpcClient.GetBackendAuthenticationConfigAsync, grpcClient.GetBackendAuthenticationConfig, effectiveSettings.GetBackendAuthenticationConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackendAuthenticationConfig);
            Modify_GetBackendAuthenticationConfigApiCall(ref _callGetBackendAuthenticationConfig);
            _callCreateBackendAuthenticationConfig = clientHelper.BuildApiCall<CreateBackendAuthenticationConfigRequest, lro::Operation>("CreateBackendAuthenticationConfig", grpcClient.CreateBackendAuthenticationConfigAsync, grpcClient.CreateBackendAuthenticationConfig, effectiveSettings.CreateBackendAuthenticationConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackendAuthenticationConfig);
            Modify_CreateBackendAuthenticationConfigApiCall(ref _callCreateBackendAuthenticationConfig);
            _callUpdateBackendAuthenticationConfig = clientHelper.BuildApiCall<UpdateBackendAuthenticationConfigRequest, lro::Operation>("UpdateBackendAuthenticationConfig", grpcClient.UpdateBackendAuthenticationConfigAsync, grpcClient.UpdateBackendAuthenticationConfig, effectiveSettings.UpdateBackendAuthenticationConfigSettings).WithGoogleRequestParam("backend_authentication_config.name", request => request.BackendAuthenticationConfig?.Name);
            Modify_ApiCall(ref _callUpdateBackendAuthenticationConfig);
            Modify_UpdateBackendAuthenticationConfigApiCall(ref _callUpdateBackendAuthenticationConfig);
            _callDeleteBackendAuthenticationConfig = clientHelper.BuildApiCall<DeleteBackendAuthenticationConfigRequest, lro::Operation>("DeleteBackendAuthenticationConfig", grpcClient.DeleteBackendAuthenticationConfigAsync, grpcClient.DeleteBackendAuthenticationConfig, effectiveSettings.DeleteBackendAuthenticationConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackendAuthenticationConfig);
            Modify_DeleteBackendAuthenticationConfigApiCall(ref _callDeleteBackendAuthenticationConfig);
            _callListServerTlsPolicies = clientHelper.BuildApiCall<ListServerTlsPoliciesRequest, ListServerTlsPoliciesResponse>("ListServerTlsPolicies", grpcClient.ListServerTlsPoliciesAsync, grpcClient.ListServerTlsPolicies, effectiveSettings.ListServerTlsPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServerTlsPolicies);
            Modify_ListServerTlsPoliciesApiCall(ref _callListServerTlsPolicies);
            _callGetServerTlsPolicy = clientHelper.BuildApiCall<GetServerTlsPolicyRequest, ServerTlsPolicy>("GetServerTlsPolicy", grpcClient.GetServerTlsPolicyAsync, grpcClient.GetServerTlsPolicy, effectiveSettings.GetServerTlsPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServerTlsPolicy);
            Modify_GetServerTlsPolicyApiCall(ref _callGetServerTlsPolicy);
            _callCreateServerTlsPolicy = clientHelper.BuildApiCall<CreateServerTlsPolicyRequest, lro::Operation>("CreateServerTlsPolicy", grpcClient.CreateServerTlsPolicyAsync, grpcClient.CreateServerTlsPolicy, effectiveSettings.CreateServerTlsPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServerTlsPolicy);
            Modify_CreateServerTlsPolicyApiCall(ref _callCreateServerTlsPolicy);
            _callUpdateServerTlsPolicy = clientHelper.BuildApiCall<UpdateServerTlsPolicyRequest, lro::Operation>("UpdateServerTlsPolicy", grpcClient.UpdateServerTlsPolicyAsync, grpcClient.UpdateServerTlsPolicy, effectiveSettings.UpdateServerTlsPolicySettings).WithGoogleRequestParam("server_tls_policy.name", request => request.ServerTlsPolicy?.Name);
            Modify_ApiCall(ref _callUpdateServerTlsPolicy);
            Modify_UpdateServerTlsPolicyApiCall(ref _callUpdateServerTlsPolicy);
            _callDeleteServerTlsPolicy = clientHelper.BuildApiCall<DeleteServerTlsPolicyRequest, lro::Operation>("DeleteServerTlsPolicy", grpcClient.DeleteServerTlsPolicyAsync, grpcClient.DeleteServerTlsPolicy, effectiveSettings.DeleteServerTlsPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServerTlsPolicy);
            Modify_DeleteServerTlsPolicyApiCall(ref _callDeleteServerTlsPolicy);
            _callListClientTlsPolicies = clientHelper.BuildApiCall<ListClientTlsPoliciesRequest, ListClientTlsPoliciesResponse>("ListClientTlsPolicies", grpcClient.ListClientTlsPoliciesAsync, grpcClient.ListClientTlsPolicies, effectiveSettings.ListClientTlsPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClientTlsPolicies);
            Modify_ListClientTlsPoliciesApiCall(ref _callListClientTlsPolicies);
            _callGetClientTlsPolicy = clientHelper.BuildApiCall<GetClientTlsPolicyRequest, ClientTlsPolicy>("GetClientTlsPolicy", grpcClient.GetClientTlsPolicyAsync, grpcClient.GetClientTlsPolicy, effectiveSettings.GetClientTlsPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetClientTlsPolicy);
            Modify_GetClientTlsPolicyApiCall(ref _callGetClientTlsPolicy);
            _callCreateClientTlsPolicy = clientHelper.BuildApiCall<CreateClientTlsPolicyRequest, lro::Operation>("CreateClientTlsPolicy", grpcClient.CreateClientTlsPolicyAsync, grpcClient.CreateClientTlsPolicy, effectiveSettings.CreateClientTlsPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateClientTlsPolicy);
            Modify_CreateClientTlsPolicyApiCall(ref _callCreateClientTlsPolicy);
            _callUpdateClientTlsPolicy = clientHelper.BuildApiCall<UpdateClientTlsPolicyRequest, lro::Operation>("UpdateClientTlsPolicy", grpcClient.UpdateClientTlsPolicyAsync, grpcClient.UpdateClientTlsPolicy, effectiveSettings.UpdateClientTlsPolicySettings).WithGoogleRequestParam("client_tls_policy.name", request => request.ClientTlsPolicy?.Name);
            Modify_ApiCall(ref _callUpdateClientTlsPolicy);
            Modify_UpdateClientTlsPolicyApiCall(ref _callUpdateClientTlsPolicy);
            _callDeleteClientTlsPolicy = clientHelper.BuildApiCall<DeleteClientTlsPolicyRequest, lro::Operation>("DeleteClientTlsPolicy", grpcClient.DeleteClientTlsPolicyAsync, grpcClient.DeleteClientTlsPolicy, effectiveSettings.DeleteClientTlsPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteClientTlsPolicy);
            Modify_DeleteClientTlsPolicyApiCall(ref _callDeleteClientTlsPolicy);
            _callListGatewaySecurityPolicies = clientHelper.BuildApiCall<ListGatewaySecurityPoliciesRequest, ListGatewaySecurityPoliciesResponse>("ListGatewaySecurityPolicies", grpcClient.ListGatewaySecurityPoliciesAsync, grpcClient.ListGatewaySecurityPolicies, effectiveSettings.ListGatewaySecurityPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGatewaySecurityPolicies);
            Modify_ListGatewaySecurityPoliciesApiCall(ref _callListGatewaySecurityPolicies);
            _callGetGatewaySecurityPolicy = clientHelper.BuildApiCall<GetGatewaySecurityPolicyRequest, GatewaySecurityPolicy>("GetGatewaySecurityPolicy", grpcClient.GetGatewaySecurityPolicyAsync, grpcClient.GetGatewaySecurityPolicy, effectiveSettings.GetGatewaySecurityPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGatewaySecurityPolicy);
            Modify_GetGatewaySecurityPolicyApiCall(ref _callGetGatewaySecurityPolicy);
            _callCreateGatewaySecurityPolicy = clientHelper.BuildApiCall<CreateGatewaySecurityPolicyRequest, lro::Operation>("CreateGatewaySecurityPolicy", grpcClient.CreateGatewaySecurityPolicyAsync, grpcClient.CreateGatewaySecurityPolicy, effectiveSettings.CreateGatewaySecurityPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGatewaySecurityPolicy);
            Modify_CreateGatewaySecurityPolicyApiCall(ref _callCreateGatewaySecurityPolicy);
            _callUpdateGatewaySecurityPolicy = clientHelper.BuildApiCall<UpdateGatewaySecurityPolicyRequest, lro::Operation>("UpdateGatewaySecurityPolicy", grpcClient.UpdateGatewaySecurityPolicyAsync, grpcClient.UpdateGatewaySecurityPolicy, effectiveSettings.UpdateGatewaySecurityPolicySettings).WithGoogleRequestParam("gateway_security_policy.name", request => request.GatewaySecurityPolicy?.Name);
            Modify_ApiCall(ref _callUpdateGatewaySecurityPolicy);
            Modify_UpdateGatewaySecurityPolicyApiCall(ref _callUpdateGatewaySecurityPolicy);
            _callDeleteGatewaySecurityPolicy = clientHelper.BuildApiCall<DeleteGatewaySecurityPolicyRequest, lro::Operation>("DeleteGatewaySecurityPolicy", grpcClient.DeleteGatewaySecurityPolicyAsync, grpcClient.DeleteGatewaySecurityPolicy, effectiveSettings.DeleteGatewaySecurityPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGatewaySecurityPolicy);
            Modify_DeleteGatewaySecurityPolicyApiCall(ref _callDeleteGatewaySecurityPolicy);
            _callListGatewaySecurityPolicyRules = clientHelper.BuildApiCall<ListGatewaySecurityPolicyRulesRequest, ListGatewaySecurityPolicyRulesResponse>("ListGatewaySecurityPolicyRules", grpcClient.ListGatewaySecurityPolicyRulesAsync, grpcClient.ListGatewaySecurityPolicyRules, effectiveSettings.ListGatewaySecurityPolicyRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGatewaySecurityPolicyRules);
            Modify_ListGatewaySecurityPolicyRulesApiCall(ref _callListGatewaySecurityPolicyRules);
            _callGetGatewaySecurityPolicyRule = clientHelper.BuildApiCall<GetGatewaySecurityPolicyRuleRequest, GatewaySecurityPolicyRule>("GetGatewaySecurityPolicyRule", grpcClient.GetGatewaySecurityPolicyRuleAsync, grpcClient.GetGatewaySecurityPolicyRule, effectiveSettings.GetGatewaySecurityPolicyRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGatewaySecurityPolicyRule);
            Modify_GetGatewaySecurityPolicyRuleApiCall(ref _callGetGatewaySecurityPolicyRule);
            _callCreateGatewaySecurityPolicyRule = clientHelper.BuildApiCall<CreateGatewaySecurityPolicyRuleRequest, lro::Operation>("CreateGatewaySecurityPolicyRule", grpcClient.CreateGatewaySecurityPolicyRuleAsync, grpcClient.CreateGatewaySecurityPolicyRule, effectiveSettings.CreateGatewaySecurityPolicyRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGatewaySecurityPolicyRule);
            Modify_CreateGatewaySecurityPolicyRuleApiCall(ref _callCreateGatewaySecurityPolicyRule);
            _callUpdateGatewaySecurityPolicyRule = clientHelper.BuildApiCall<UpdateGatewaySecurityPolicyRuleRequest, lro::Operation>("UpdateGatewaySecurityPolicyRule", grpcClient.UpdateGatewaySecurityPolicyRuleAsync, grpcClient.UpdateGatewaySecurityPolicyRule, effectiveSettings.UpdateGatewaySecurityPolicyRuleSettings).WithGoogleRequestParam("gateway_security_policy_rule.name", request => request.GatewaySecurityPolicyRule?.Name);
            Modify_ApiCall(ref _callUpdateGatewaySecurityPolicyRule);
            Modify_UpdateGatewaySecurityPolicyRuleApiCall(ref _callUpdateGatewaySecurityPolicyRule);
            _callDeleteGatewaySecurityPolicyRule = clientHelper.BuildApiCall<DeleteGatewaySecurityPolicyRuleRequest, lro::Operation>("DeleteGatewaySecurityPolicyRule", grpcClient.DeleteGatewaySecurityPolicyRuleAsync, grpcClient.DeleteGatewaySecurityPolicyRule, effectiveSettings.DeleteGatewaySecurityPolicyRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGatewaySecurityPolicyRule);
            Modify_DeleteGatewaySecurityPolicyRuleApiCall(ref _callDeleteGatewaySecurityPolicyRule);
            _callListUrlLists = clientHelper.BuildApiCall<ListUrlListsRequest, ListUrlListsResponse>("ListUrlLists", grpcClient.ListUrlListsAsync, grpcClient.ListUrlLists, effectiveSettings.ListUrlListsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUrlLists);
            Modify_ListUrlListsApiCall(ref _callListUrlLists);
            _callGetUrlList = clientHelper.BuildApiCall<GetUrlListRequest, UrlList>("GetUrlList", grpcClient.GetUrlListAsync, grpcClient.GetUrlList, effectiveSettings.GetUrlListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUrlList);
            Modify_GetUrlListApiCall(ref _callGetUrlList);
            _callCreateUrlList = clientHelper.BuildApiCall<CreateUrlListRequest, lro::Operation>("CreateUrlList", grpcClient.CreateUrlListAsync, grpcClient.CreateUrlList, effectiveSettings.CreateUrlListSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUrlList);
            Modify_CreateUrlListApiCall(ref _callCreateUrlList);
            _callUpdateUrlList = clientHelper.BuildApiCall<UpdateUrlListRequest, lro::Operation>("UpdateUrlList", grpcClient.UpdateUrlListAsync, grpcClient.UpdateUrlList, effectiveSettings.UpdateUrlListSettings).WithGoogleRequestParam("url_list.name", request => request.UrlList?.Name);
            Modify_ApiCall(ref _callUpdateUrlList);
            Modify_UpdateUrlListApiCall(ref _callUpdateUrlList);
            _callDeleteUrlList = clientHelper.BuildApiCall<DeleteUrlListRequest, lro::Operation>("DeleteUrlList", grpcClient.DeleteUrlListAsync, grpcClient.DeleteUrlList, effectiveSettings.DeleteUrlListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUrlList);
            Modify_DeleteUrlListApiCall(ref _callDeleteUrlList);
            _callListTlsInspectionPolicies = clientHelper.BuildApiCall<ListTlsInspectionPoliciesRequest, ListTlsInspectionPoliciesResponse>("ListTlsInspectionPolicies", grpcClient.ListTlsInspectionPoliciesAsync, grpcClient.ListTlsInspectionPolicies, effectiveSettings.ListTlsInspectionPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTlsInspectionPolicies);
            Modify_ListTlsInspectionPoliciesApiCall(ref _callListTlsInspectionPolicies);
            _callGetTlsInspectionPolicy = clientHelper.BuildApiCall<GetTlsInspectionPolicyRequest, TlsInspectionPolicy>("GetTlsInspectionPolicy", grpcClient.GetTlsInspectionPolicyAsync, grpcClient.GetTlsInspectionPolicy, effectiveSettings.GetTlsInspectionPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTlsInspectionPolicy);
            Modify_GetTlsInspectionPolicyApiCall(ref _callGetTlsInspectionPolicy);
            _callCreateTlsInspectionPolicy = clientHelper.BuildApiCall<CreateTlsInspectionPolicyRequest, lro::Operation>("CreateTlsInspectionPolicy", grpcClient.CreateTlsInspectionPolicyAsync, grpcClient.CreateTlsInspectionPolicy, effectiveSettings.CreateTlsInspectionPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTlsInspectionPolicy);
            Modify_CreateTlsInspectionPolicyApiCall(ref _callCreateTlsInspectionPolicy);
            _callUpdateTlsInspectionPolicy = clientHelper.BuildApiCall<UpdateTlsInspectionPolicyRequest, lro::Operation>("UpdateTlsInspectionPolicy", grpcClient.UpdateTlsInspectionPolicyAsync, grpcClient.UpdateTlsInspectionPolicy, effectiveSettings.UpdateTlsInspectionPolicySettings).WithGoogleRequestParam("tls_inspection_policy.name", request => request.TlsInspectionPolicy?.Name);
            Modify_ApiCall(ref _callUpdateTlsInspectionPolicy);
            Modify_UpdateTlsInspectionPolicyApiCall(ref _callUpdateTlsInspectionPolicy);
            _callDeleteTlsInspectionPolicy = clientHelper.BuildApiCall<DeleteTlsInspectionPolicyRequest, lro::Operation>("DeleteTlsInspectionPolicy", grpcClient.DeleteTlsInspectionPolicyAsync, grpcClient.DeleteTlsInspectionPolicy, effectiveSettings.DeleteTlsInspectionPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTlsInspectionPolicy);
            Modify_DeleteTlsInspectionPolicyApiCall(ref _callDeleteTlsInspectionPolicy);
            _callListAuthzPolicies = clientHelper.BuildApiCall<ListAuthzPoliciesRequest, ListAuthzPoliciesResponse>("ListAuthzPolicies", grpcClient.ListAuthzPoliciesAsync, grpcClient.ListAuthzPolicies, effectiveSettings.ListAuthzPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAuthzPolicies);
            Modify_ListAuthzPoliciesApiCall(ref _callListAuthzPolicies);
            _callGetAuthzPolicy = clientHelper.BuildApiCall<GetAuthzPolicyRequest, AuthzPolicy>("GetAuthzPolicy", grpcClient.GetAuthzPolicyAsync, grpcClient.GetAuthzPolicy, effectiveSettings.GetAuthzPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAuthzPolicy);
            Modify_GetAuthzPolicyApiCall(ref _callGetAuthzPolicy);
            _callCreateAuthzPolicy = clientHelper.BuildApiCall<CreateAuthzPolicyRequest, lro::Operation>("CreateAuthzPolicy", grpcClient.CreateAuthzPolicyAsync, grpcClient.CreateAuthzPolicy, effectiveSettings.CreateAuthzPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAuthzPolicy);
            Modify_CreateAuthzPolicyApiCall(ref _callCreateAuthzPolicy);
            _callUpdateAuthzPolicy = clientHelper.BuildApiCall<UpdateAuthzPolicyRequest, lro::Operation>("UpdateAuthzPolicy", grpcClient.UpdateAuthzPolicyAsync, grpcClient.UpdateAuthzPolicy, effectiveSettings.UpdateAuthzPolicySettings).WithGoogleRequestParam("authz_policy.name", request => request.AuthzPolicy?.Name);
            Modify_ApiCall(ref _callUpdateAuthzPolicy);
            Modify_UpdateAuthzPolicyApiCall(ref _callUpdateAuthzPolicy);
            _callDeleteAuthzPolicy = clientHelper.BuildApiCall<DeleteAuthzPolicyRequest, lro::Operation>("DeleteAuthzPolicy", grpcClient.DeleteAuthzPolicyAsync, grpcClient.DeleteAuthzPolicy, effectiveSettings.DeleteAuthzPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAuthzPolicy);
            Modify_DeleteAuthzPolicyApiCall(ref _callDeleteAuthzPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAuthorizationPoliciesApiCall(ref gaxgrpc::ApiCall<ListAuthorizationPoliciesRequest, ListAuthorizationPoliciesResponse> call);

        partial void Modify_GetAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<GetAuthorizationPolicyRequest, AuthorizationPolicy> call);

        partial void Modify_CreateAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<CreateAuthorizationPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAuthorizationPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAuthorizationPolicyRequest, lro::Operation> call);

        partial void Modify_ListBackendAuthenticationConfigsApiCall(ref gaxgrpc::ApiCall<ListBackendAuthenticationConfigsRequest, ListBackendAuthenticationConfigsResponse> call);

        partial void Modify_GetBackendAuthenticationConfigApiCall(ref gaxgrpc::ApiCall<GetBackendAuthenticationConfigRequest, BackendAuthenticationConfig> call);

        partial void Modify_CreateBackendAuthenticationConfigApiCall(ref gaxgrpc::ApiCall<CreateBackendAuthenticationConfigRequest, lro::Operation> call);

        partial void Modify_UpdateBackendAuthenticationConfigApiCall(ref gaxgrpc::ApiCall<UpdateBackendAuthenticationConfigRequest, lro::Operation> call);

        partial void Modify_DeleteBackendAuthenticationConfigApiCall(ref gaxgrpc::ApiCall<DeleteBackendAuthenticationConfigRequest, lro::Operation> call);

        partial void Modify_ListServerTlsPoliciesApiCall(ref gaxgrpc::ApiCall<ListServerTlsPoliciesRequest, ListServerTlsPoliciesResponse> call);

        partial void Modify_GetServerTlsPolicyApiCall(ref gaxgrpc::ApiCall<GetServerTlsPolicyRequest, ServerTlsPolicy> call);

        partial void Modify_CreateServerTlsPolicyApiCall(ref gaxgrpc::ApiCall<CreateServerTlsPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateServerTlsPolicyApiCall(ref gaxgrpc::ApiCall<UpdateServerTlsPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteServerTlsPolicyApiCall(ref gaxgrpc::ApiCall<DeleteServerTlsPolicyRequest, lro::Operation> call);

        partial void Modify_ListClientTlsPoliciesApiCall(ref gaxgrpc::ApiCall<ListClientTlsPoliciesRequest, ListClientTlsPoliciesResponse> call);

        partial void Modify_GetClientTlsPolicyApiCall(ref gaxgrpc::ApiCall<GetClientTlsPolicyRequest, ClientTlsPolicy> call);

        partial void Modify_CreateClientTlsPolicyApiCall(ref gaxgrpc::ApiCall<CreateClientTlsPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateClientTlsPolicyApiCall(ref gaxgrpc::ApiCall<UpdateClientTlsPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteClientTlsPolicyApiCall(ref gaxgrpc::ApiCall<DeleteClientTlsPolicyRequest, lro::Operation> call);

        partial void Modify_ListGatewaySecurityPoliciesApiCall(ref gaxgrpc::ApiCall<ListGatewaySecurityPoliciesRequest, ListGatewaySecurityPoliciesResponse> call);

        partial void Modify_GetGatewaySecurityPolicyApiCall(ref gaxgrpc::ApiCall<GetGatewaySecurityPolicyRequest, GatewaySecurityPolicy> call);

        partial void Modify_CreateGatewaySecurityPolicyApiCall(ref gaxgrpc::ApiCall<CreateGatewaySecurityPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateGatewaySecurityPolicyApiCall(ref gaxgrpc::ApiCall<UpdateGatewaySecurityPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteGatewaySecurityPolicyApiCall(ref gaxgrpc::ApiCall<DeleteGatewaySecurityPolicyRequest, lro::Operation> call);

        partial void Modify_ListGatewaySecurityPolicyRulesApiCall(ref gaxgrpc::ApiCall<ListGatewaySecurityPolicyRulesRequest, ListGatewaySecurityPolicyRulesResponse> call);

        partial void Modify_GetGatewaySecurityPolicyRuleApiCall(ref gaxgrpc::ApiCall<GetGatewaySecurityPolicyRuleRequest, GatewaySecurityPolicyRule> call);

        partial void Modify_CreateGatewaySecurityPolicyRuleApiCall(ref gaxgrpc::ApiCall<CreateGatewaySecurityPolicyRuleRequest, lro::Operation> call);

        partial void Modify_UpdateGatewaySecurityPolicyRuleApiCall(ref gaxgrpc::ApiCall<UpdateGatewaySecurityPolicyRuleRequest, lro::Operation> call);

        partial void Modify_DeleteGatewaySecurityPolicyRuleApiCall(ref gaxgrpc::ApiCall<DeleteGatewaySecurityPolicyRuleRequest, lro::Operation> call);

        partial void Modify_ListUrlListsApiCall(ref gaxgrpc::ApiCall<ListUrlListsRequest, ListUrlListsResponse> call);

        partial void Modify_GetUrlListApiCall(ref gaxgrpc::ApiCall<GetUrlListRequest, UrlList> call);

        partial void Modify_CreateUrlListApiCall(ref gaxgrpc::ApiCall<CreateUrlListRequest, lro::Operation> call);

        partial void Modify_UpdateUrlListApiCall(ref gaxgrpc::ApiCall<UpdateUrlListRequest, lro::Operation> call);

        partial void Modify_DeleteUrlListApiCall(ref gaxgrpc::ApiCall<DeleteUrlListRequest, lro::Operation> call);

        partial void Modify_ListTlsInspectionPoliciesApiCall(ref gaxgrpc::ApiCall<ListTlsInspectionPoliciesRequest, ListTlsInspectionPoliciesResponse> call);

        partial void Modify_GetTlsInspectionPolicyApiCall(ref gaxgrpc::ApiCall<GetTlsInspectionPolicyRequest, TlsInspectionPolicy> call);

        partial void Modify_CreateTlsInspectionPolicyApiCall(ref gaxgrpc::ApiCall<CreateTlsInspectionPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateTlsInspectionPolicyApiCall(ref gaxgrpc::ApiCall<UpdateTlsInspectionPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteTlsInspectionPolicyApiCall(ref gaxgrpc::ApiCall<DeleteTlsInspectionPolicyRequest, lro::Operation> call);

        partial void Modify_ListAuthzPoliciesApiCall(ref gaxgrpc::ApiCall<ListAuthzPoliciesRequest, ListAuthzPoliciesResponse> call);

        partial void Modify_GetAuthzPolicyApiCall(ref gaxgrpc::ApiCall<GetAuthzPolicyRequest, AuthzPolicy> call);

        partial void Modify_CreateAuthzPolicyApiCall(ref gaxgrpc::ApiCall<CreateAuthzPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateAuthzPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAuthzPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteAuthzPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAuthzPolicyRequest, lro::Operation> call);

        partial void OnConstruction(NetworkSecurity.NetworkSecurityClient grpcClient, NetworkSecuritySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkSecurity client</summary>
        public override NetworkSecurity.NetworkSecurityClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListAuthorizationPoliciesRequest(ref ListAuthorizationPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAuthorizationPolicyRequest(ref GetAuthorizationPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAuthorizationPolicyRequest(ref CreateAuthorizationPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAuthorizationPolicyRequest(ref UpdateAuthorizationPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAuthorizationPolicyRequest(ref DeleteAuthorizationPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackendAuthenticationConfigsRequest(ref ListBackendAuthenticationConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackendAuthenticationConfigRequest(ref GetBackendAuthenticationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackendAuthenticationConfigRequest(ref CreateBackendAuthenticationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackendAuthenticationConfigRequest(ref UpdateBackendAuthenticationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackendAuthenticationConfigRequest(ref DeleteBackendAuthenticationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServerTlsPoliciesRequest(ref ListServerTlsPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServerTlsPolicyRequest(ref GetServerTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServerTlsPolicyRequest(ref CreateServerTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServerTlsPolicyRequest(ref UpdateServerTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServerTlsPolicyRequest(ref DeleteServerTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListClientTlsPoliciesRequest(ref ListClientTlsPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClientTlsPolicyRequest(ref GetClientTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClientTlsPolicyRequest(ref CreateClientTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClientTlsPolicyRequest(ref UpdateClientTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClientTlsPolicyRequest(ref DeleteClientTlsPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGatewaySecurityPoliciesRequest(ref ListGatewaySecurityPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGatewaySecurityPolicyRequest(ref GetGatewaySecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGatewaySecurityPolicyRequest(ref CreateGatewaySecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGatewaySecurityPolicyRequest(ref UpdateGatewaySecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGatewaySecurityPolicyRequest(ref DeleteGatewaySecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGatewaySecurityPolicyRulesRequest(ref ListGatewaySecurityPolicyRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGatewaySecurityPolicyRuleRequest(ref GetGatewaySecurityPolicyRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGatewaySecurityPolicyRuleRequest(ref CreateGatewaySecurityPolicyRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGatewaySecurityPolicyRuleRequest(ref UpdateGatewaySecurityPolicyRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGatewaySecurityPolicyRuleRequest(ref DeleteGatewaySecurityPolicyRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUrlListsRequest(ref ListUrlListsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUrlListRequest(ref GetUrlListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUrlListRequest(ref CreateUrlListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUrlListRequest(ref UpdateUrlListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUrlListRequest(ref DeleteUrlListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTlsInspectionPoliciesRequest(ref ListTlsInspectionPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTlsInspectionPolicyRequest(ref GetTlsInspectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTlsInspectionPolicyRequest(ref CreateTlsInspectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTlsInspectionPolicyRequest(ref UpdateTlsInspectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTlsInspectionPolicyRequest(ref DeleteTlsInspectionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAuthzPoliciesRequest(ref ListAuthzPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAuthzPolicyRequest(ref GetAuthzPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAuthzPolicyRequest(ref CreateAuthzPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAuthzPolicyRequest(ref UpdateAuthzPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAuthzPolicyRequest(ref DeleteAuthzPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPolicies(ListAuthorizationPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthorizationPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAuthorizationPoliciesRequest, ListAuthorizationPoliciesResponse, AuthorizationPolicy>(_callListAuthorizationPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists AuthorizationPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizationPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAuthorizationPoliciesResponse, AuthorizationPolicy> ListAuthorizationPoliciesAsync(ListAuthorizationPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthorizationPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAuthorizationPoliciesRequest, ListAuthorizationPoliciesResponse, AuthorizationPolicy>(_callListAuthorizationPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthorizationPolicy GetAuthorizationPolicy(GetAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthorizationPolicyRequest(ref request, ref callSettings);
            return _callGetAuthorizationPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthorizationPolicy> GetAuthorizationPolicyAsync(GetAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthorizationPolicyRequest(ref request, ref callSettings);
            return _callGetAuthorizationPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAuthorizationPolicy</c>.</summary>
        public override lro::OperationsClient CreateAuthorizationPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AuthorizationPolicy, OperationMetadata> CreateAuthorizationPolicy(CreateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAuthorizationPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthorizationPolicy, OperationMetadata>(_callCreateAuthorizationPolicy.Sync(request, callSettings), CreateAuthorizationPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new AuthorizationPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> CreateAuthorizationPolicyAsync(CreateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAuthorizationPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthorizationPolicy, OperationMetadata>(await _callCreateAuthorizationPolicy.Async(request, callSettings).ConfigureAwait(false), CreateAuthorizationPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAuthorizationPolicy</c>.</summary>
        public override lro::OperationsClient UpdateAuthorizationPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AuthorizationPolicy, OperationMetadata> UpdateAuthorizationPolicy(UpdateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAuthorizationPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthorizationPolicy, OperationMetadata>(_callUpdateAuthorizationPolicy.Sync(request, callSettings), UpdateAuthorizationPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AuthorizationPolicy, OperationMetadata>> UpdateAuthorizationPolicyAsync(UpdateAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAuthorizationPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthorizationPolicy, OperationMetadata>(await _callUpdateAuthorizationPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateAuthorizationPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAuthorizationPolicy</c>.</summary>
        public override lro::OperationsClient DeleteAuthorizationPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthorizationPolicy(DeleteAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthorizationPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAuthorizationPolicy.Sync(request, callSettings), DeleteAuthorizationPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single AuthorizationPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthorizationPolicyAsync(DeleteAuthorizationPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthorizationPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAuthorizationPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteAuthorizationPolicyOperationsClient);
        }

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigs(ListBackendAuthenticationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackendAuthenticationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackendAuthenticationConfigsRequest, ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig>(_callListBackendAuthenticationConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists BackendAuthenticationConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackendAuthenticationConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig> ListBackendAuthenticationConfigsAsync(ListBackendAuthenticationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackendAuthenticationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackendAuthenticationConfigsRequest, ListBackendAuthenticationConfigsResponse, BackendAuthenticationConfig>(_callListBackendAuthenticationConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackendAuthenticationConfig GetBackendAuthenticationConfig(GetBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return _callGetBackendAuthenticationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackendAuthenticationConfig> GetBackendAuthenticationConfigAsync(GetBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return _callGetBackendAuthenticationConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBackendAuthenticationConfig</c>.</summary>
        public override lro::OperationsClient CreateBackendAuthenticationConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackendAuthenticationConfig, OperationMetadata> CreateBackendAuthenticationConfig(CreateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<BackendAuthenticationConfig, OperationMetadata>(_callCreateBackendAuthenticationConfig.Sync(request, callSettings), CreateBackendAuthenticationConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new BackendAuthenticationConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> CreateBackendAuthenticationConfigAsync(CreateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<BackendAuthenticationConfig, OperationMetadata>(await _callCreateBackendAuthenticationConfig.Async(request, callSettings).ConfigureAwait(false), CreateBackendAuthenticationConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBackendAuthenticationConfig</c>.</summary>
        public override lro::OperationsClient UpdateBackendAuthenticationConfigOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackendAuthenticationConfig, OperationMetadata> UpdateBackendAuthenticationConfig(UpdateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<BackendAuthenticationConfig, OperationMetadata>(_callUpdateBackendAuthenticationConfig.Sync(request, callSettings), UpdateBackendAuthenticationConfigOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackendAuthenticationConfig, OperationMetadata>> UpdateBackendAuthenticationConfigAsync(UpdateBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<BackendAuthenticationConfig, OperationMetadata>(await _callUpdateBackendAuthenticationConfig.Async(request, callSettings).ConfigureAwait(false), UpdateBackendAuthenticationConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackendAuthenticationConfig</c>.</summary>
        public override lro::OperationsClient DeleteBackendAuthenticationConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackendAuthenticationConfig(DeleteBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackendAuthenticationConfig.Sync(request, callSettings), DeleteBackendAuthenticationConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a single BackendAuthenticationConfig to
        /// BackendAuthenticationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackendAuthenticationConfigAsync(DeleteBackendAuthenticationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackendAuthenticationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackendAuthenticationConfig.Async(request, callSettings).ConfigureAwait(false), DeleteBackendAuthenticationConfigOperationsClient);
        }

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPolicies(ListServerTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServerTlsPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServerTlsPoliciesRequest, ListServerTlsPoliciesResponse, ServerTlsPolicy>(_callListServerTlsPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists ServerTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServerTlsPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServerTlsPoliciesResponse, ServerTlsPolicy> ListServerTlsPoliciesAsync(ListServerTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServerTlsPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServerTlsPoliciesRequest, ListServerTlsPoliciesResponse, ServerTlsPolicy>(_callListServerTlsPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServerTlsPolicy GetServerTlsPolicy(GetServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServerTlsPolicyRequest(ref request, ref callSettings);
            return _callGetServerTlsPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServerTlsPolicy> GetServerTlsPolicyAsync(GetServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServerTlsPolicyRequest(ref request, ref callSettings);
            return _callGetServerTlsPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServerTlsPolicy</c>.</summary>
        public override lro::OperationsClient CreateServerTlsPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServerTlsPolicy, OperationMetadata> CreateServerTlsPolicy(CreateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServerTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServerTlsPolicy, OperationMetadata>(_callCreateServerTlsPolicy.Sync(request, callSettings), CreateServerTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new ServerTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> CreateServerTlsPolicyAsync(CreateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServerTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServerTlsPolicy, OperationMetadata>(await _callCreateServerTlsPolicy.Async(request, callSettings).ConfigureAwait(false), CreateServerTlsPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServerTlsPolicy</c>.</summary>
        public override lro::OperationsClient UpdateServerTlsPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServerTlsPolicy, OperationMetadata> UpdateServerTlsPolicy(UpdateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServerTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServerTlsPolicy, OperationMetadata>(_callUpdateServerTlsPolicy.Sync(request, callSettings), UpdateServerTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServerTlsPolicy, OperationMetadata>> UpdateServerTlsPolicyAsync(UpdateServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServerTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ServerTlsPolicy, OperationMetadata>(await _callUpdateServerTlsPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateServerTlsPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServerTlsPolicy</c>.</summary>
        public override lro::OperationsClient DeleteServerTlsPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServerTlsPolicy(DeleteServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServerTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServerTlsPolicy.Sync(request, callSettings), DeleteServerTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single ServerTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServerTlsPolicyAsync(DeleteServerTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServerTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServerTlsPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteServerTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPolicies(ListClientTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClientTlsPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClientTlsPoliciesRequest, ListClientTlsPoliciesResponse, ClientTlsPolicy>(_callListClientTlsPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists ClientTlsPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ClientTlsPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClientTlsPoliciesResponse, ClientTlsPolicy> ListClientTlsPoliciesAsync(ListClientTlsPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClientTlsPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClientTlsPoliciesRequest, ListClientTlsPoliciesResponse, ClientTlsPolicy>(_callListClientTlsPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClientTlsPolicy GetClientTlsPolicy(GetClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClientTlsPolicyRequest(ref request, ref callSettings);
            return _callGetClientTlsPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClientTlsPolicy> GetClientTlsPolicyAsync(GetClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClientTlsPolicyRequest(ref request, ref callSettings);
            return _callGetClientTlsPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateClientTlsPolicy</c>.</summary>
        public override lro::OperationsClient CreateClientTlsPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ClientTlsPolicy, OperationMetadata> CreateClientTlsPolicy(CreateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ClientTlsPolicy, OperationMetadata>(_callCreateClientTlsPolicy.Sync(request, callSettings), CreateClientTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new ClientTlsPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> CreateClientTlsPolicyAsync(CreateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ClientTlsPolicy, OperationMetadata>(await _callCreateClientTlsPolicy.Async(request, callSettings).ConfigureAwait(false), CreateClientTlsPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateClientTlsPolicy</c>.</summary>
        public override lro::OperationsClient UpdateClientTlsPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ClientTlsPolicy, OperationMetadata> UpdateClientTlsPolicy(UpdateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClientTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ClientTlsPolicy, OperationMetadata>(_callUpdateClientTlsPolicy.Sync(request, callSettings), UpdateClientTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ClientTlsPolicy, OperationMetadata>> UpdateClientTlsPolicyAsync(UpdateClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClientTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<ClientTlsPolicy, OperationMetadata>(await _callUpdateClientTlsPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateClientTlsPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteClientTlsPolicy</c>.</summary>
        public override lro::OperationsClient DeleteClientTlsPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteClientTlsPolicy(DeleteClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClientTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteClientTlsPolicy.Sync(request, callSettings), DeleteClientTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single ClientTlsPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClientTlsPolicyAsync(DeleteClientTlsPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClientTlsPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteClientTlsPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteClientTlsPolicyOperationsClient);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPolicies(ListGatewaySecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaySecurityPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGatewaySecurityPoliciesRequest, ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy>(_callListGatewaySecurityPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy> ListGatewaySecurityPoliciesAsync(ListGatewaySecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaySecurityPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGatewaySecurityPoliciesRequest, ListGatewaySecurityPoliciesResponse, GatewaySecurityPolicy>(_callListGatewaySecurityPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GatewaySecurityPolicy GetGatewaySecurityPolicy(GetGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return _callGetGatewaySecurityPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GatewaySecurityPolicy> GetGatewaySecurityPolicyAsync(GetGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return _callGetGatewaySecurityPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGatewaySecurityPolicy</c>.</summary>
        public override lro::OperationsClient CreateGatewaySecurityPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GatewaySecurityPolicy, OperationMetadata> CreateGatewaySecurityPolicy(CreateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicy, OperationMetadata>(_callCreateGatewaySecurityPolicy.Sync(request, callSettings), CreateGatewaySecurityPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> CreateGatewaySecurityPolicyAsync(CreateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicy, OperationMetadata>(await _callCreateGatewaySecurityPolicy.Async(request, callSettings).ConfigureAwait(false), CreateGatewaySecurityPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGatewaySecurityPolicy</c>.</summary>
        public override lro::OperationsClient UpdateGatewaySecurityPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GatewaySecurityPolicy, OperationMetadata> UpdateGatewaySecurityPolicy(UpdateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicy, OperationMetadata>(_callUpdateGatewaySecurityPolicy.Sync(request, callSettings), UpdateGatewaySecurityPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GatewaySecurityPolicy, OperationMetadata>> UpdateGatewaySecurityPolicyAsync(UpdateGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicy, OperationMetadata>(await _callUpdateGatewaySecurityPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateGatewaySecurityPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGatewaySecurityPolicy</c>.</summary>
        public override lro::OperationsClient DeleteGatewaySecurityPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicy(DeleteGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGatewaySecurityPolicy.Sync(request, callSettings), DeleteGatewaySecurityPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single GatewaySecurityPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyAsync(DeleteGatewaySecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewaySecurityPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGatewaySecurityPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteGatewaySecurityPolicyOperationsClient);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public override gax::PagedEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRules(ListGatewaySecurityPolicyRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaySecurityPolicyRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGatewaySecurityPolicyRulesRequest, ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule>(_callListGatewaySecurityPolicyRules, request, callSettings);
        }

        /// <summary>
        /// Lists GatewaySecurityPolicyRules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GatewaySecurityPolicyRule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule> ListGatewaySecurityPolicyRulesAsync(ListGatewaySecurityPolicyRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaySecurityPolicyRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGatewaySecurityPolicyRulesRequest, ListGatewaySecurityPolicyRulesResponse, GatewaySecurityPolicyRule>(_callListGatewaySecurityPolicyRules, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GatewaySecurityPolicyRule GetGatewaySecurityPolicyRule(GetGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return _callGetGatewaySecurityPolicyRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GatewaySecurityPolicyRule> GetGatewaySecurityPolicyRuleAsync(GetGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return _callGetGatewaySecurityPolicyRule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGatewaySecurityPolicyRule</c>.</summary>
        public override lro::OperationsClient CreateGatewaySecurityPolicyRuleOperationsClient { get; }

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> CreateGatewaySecurityPolicyRule(CreateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>(_callCreateGatewaySecurityPolicyRule.Sync(request, callSettings), CreateGatewaySecurityPolicyRuleOperationsClient);
        }

        /// <summary>
        /// Creates a new GatewaySecurityPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> CreateGatewaySecurityPolicyRuleAsync(CreateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>(await _callCreateGatewaySecurityPolicyRule.Async(request, callSettings).ConfigureAwait(false), CreateGatewaySecurityPolicyRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGatewaySecurityPolicyRule</c>.</summary>
        public override lro::OperationsClient UpdateGatewaySecurityPolicyRuleOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GatewaySecurityPolicyRule, OperationMetadata> UpdateGatewaySecurityPolicyRule(UpdateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>(_callUpdateGatewaySecurityPolicyRule.Sync(request, callSettings), UpdateGatewaySecurityPolicyRuleOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>> UpdateGatewaySecurityPolicyRuleAsync(UpdateGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return new lro::Operation<GatewaySecurityPolicyRule, OperationMetadata>(await _callUpdateGatewaySecurityPolicyRule.Async(request, callSettings).ConfigureAwait(false), UpdateGatewaySecurityPolicyRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGatewaySecurityPolicyRule</c>.</summary>
        public override lro::OperationsClient DeleteGatewaySecurityPolicyRuleOperationsClient { get; }

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGatewaySecurityPolicyRule(DeleteGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGatewaySecurityPolicyRule.Sync(request, callSettings), DeleteGatewaySecurityPolicyRuleOperationsClient);
        }

        /// <summary>
        /// Deletes a single GatewaySecurityPolicyRule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewaySecurityPolicyRuleAsync(DeleteGatewaySecurityPolicyRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewaySecurityPolicyRuleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGatewaySecurityPolicyRule.Async(request, callSettings).ConfigureAwait(false), DeleteGatewaySecurityPolicyRuleOperationsClient);
        }

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UrlList"/> resources.</returns>
        public override gax::PagedEnumerable<ListUrlListsResponse, UrlList> ListUrlLists(ListUrlListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUrlListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUrlListsRequest, ListUrlListsResponse, UrlList>(_callListUrlLists, request, callSettings);
        }

        /// <summary>
        /// Lists UrlLists in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UrlList"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUrlListsResponse, UrlList> ListUrlListsAsync(ListUrlListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUrlListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUrlListsRequest, ListUrlListsResponse, UrlList>(_callListUrlLists, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UrlList GetUrlList(GetUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUrlListRequest(ref request, ref callSettings);
            return _callGetUrlList.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UrlList> GetUrlListAsync(GetUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUrlListRequest(ref request, ref callSettings);
            return _callGetUrlList.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateUrlList</c>.</summary>
        public override lro::OperationsClient CreateUrlListOperationsClient { get; }

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UrlList, OperationMetadata> CreateUrlList(CreateUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUrlListRequest(ref request, ref callSettings);
            return new lro::Operation<UrlList, OperationMetadata>(_callCreateUrlList.Sync(request, callSettings), CreateUrlListOperationsClient);
        }

        /// <summary>
        /// Creates a new UrlList in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UrlList, OperationMetadata>> CreateUrlListAsync(CreateUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUrlListRequest(ref request, ref callSettings);
            return new lro::Operation<UrlList, OperationMetadata>(await _callCreateUrlList.Async(request, callSettings).ConfigureAwait(false), CreateUrlListOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateUrlList</c>.</summary>
        public override lro::OperationsClient UpdateUrlListOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UrlList, OperationMetadata> UpdateUrlList(UpdateUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUrlListRequest(ref request, ref callSettings);
            return new lro::Operation<UrlList, OperationMetadata>(_callUpdateUrlList.Sync(request, callSettings), UpdateUrlListOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UrlList, OperationMetadata>> UpdateUrlListAsync(UpdateUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUrlListRequest(ref request, ref callSettings);
            return new lro::Operation<UrlList, OperationMetadata>(await _callUpdateUrlList.Async(request, callSettings).ConfigureAwait(false), UpdateUrlListOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteUrlList</c>.</summary>
        public override lro::OperationsClient DeleteUrlListOperationsClient { get; }

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteUrlList(DeleteUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUrlListRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteUrlList.Sync(request, callSettings), DeleteUrlListOperationsClient);
        }

        /// <summary>
        /// Deletes a single UrlList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUrlListAsync(DeleteUrlListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUrlListRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteUrlList.Async(request, callSettings).ConfigureAwait(false), DeleteUrlListOperationsClient);
        }

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPolicies(ListTlsInspectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTlsInspectionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTlsInspectionPoliciesRequest, ListTlsInspectionPoliciesResponse, TlsInspectionPolicy>(_callListTlsInspectionPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists TlsInspectionPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TlsInspectionPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTlsInspectionPoliciesResponse, TlsInspectionPolicy> ListTlsInspectionPoliciesAsync(ListTlsInspectionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTlsInspectionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTlsInspectionPoliciesRequest, ListTlsInspectionPoliciesResponse, TlsInspectionPolicy>(_callListTlsInspectionPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TlsInspectionPolicy GetTlsInspectionPolicy(GetTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTlsInspectionPolicyRequest(ref request, ref callSettings);
            return _callGetTlsInspectionPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TlsInspectionPolicy> GetTlsInspectionPolicyAsync(GetTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTlsInspectionPolicyRequest(ref request, ref callSettings);
            return _callGetTlsInspectionPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTlsInspectionPolicy</c>.</summary>
        public override lro::OperationsClient CreateTlsInspectionPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TlsInspectionPolicy, OperationMetadata> CreateTlsInspectionPolicy(CreateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTlsInspectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<TlsInspectionPolicy, OperationMetadata>(_callCreateTlsInspectionPolicy.Sync(request, callSettings), CreateTlsInspectionPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new TlsInspectionPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> CreateTlsInspectionPolicyAsync(CreateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTlsInspectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<TlsInspectionPolicy, OperationMetadata>(await _callCreateTlsInspectionPolicy.Async(request, callSettings).ConfigureAwait(false), CreateTlsInspectionPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTlsInspectionPolicy</c>.</summary>
        public override lro::OperationsClient UpdateTlsInspectionPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TlsInspectionPolicy, OperationMetadata> UpdateTlsInspectionPolicy(UpdateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTlsInspectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<TlsInspectionPolicy, OperationMetadata>(_callUpdateTlsInspectionPolicy.Sync(request, callSettings), UpdateTlsInspectionPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TlsInspectionPolicy, OperationMetadata>> UpdateTlsInspectionPolicyAsync(UpdateTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTlsInspectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<TlsInspectionPolicy, OperationMetadata>(await _callUpdateTlsInspectionPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateTlsInspectionPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTlsInspectionPolicy</c>.</summary>
        public override lro::OperationsClient DeleteTlsInspectionPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTlsInspectionPolicy(DeleteTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTlsInspectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTlsInspectionPolicy.Sync(request, callSettings), DeleteTlsInspectionPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single TlsInspectionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTlsInspectionPolicyAsync(DeleteTlsInspectionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTlsInspectionPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTlsInspectionPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteTlsInspectionPolicyOperationsClient);
        }

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPolicies(ListAuthzPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthzPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAuthzPoliciesRequest, ListAuthzPoliciesResponse, AuthzPolicy>(_callListAuthzPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists AuthzPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthzPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAuthzPoliciesResponse, AuthzPolicy> ListAuthzPoliciesAsync(ListAuthzPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthzPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAuthzPoliciesRequest, ListAuthzPoliciesResponse, AuthzPolicy>(_callListAuthzPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthzPolicy GetAuthzPolicy(GetAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthzPolicyRequest(ref request, ref callSettings);
            return _callGetAuthzPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthzPolicy> GetAuthzPolicyAsync(GetAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthzPolicyRequest(ref request, ref callSettings);
            return _callGetAuthzPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAuthzPolicy</c>.</summary>
        public override lro::OperationsClient CreateAuthzPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AuthzPolicy, OperationMetadata> CreateAuthzPolicy(CreateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAuthzPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthzPolicy, OperationMetadata>(_callCreateAuthzPolicy.Sync(request, callSettings), CreateAuthzPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new AuthzPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> CreateAuthzPolicyAsync(CreateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAuthzPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthzPolicy, OperationMetadata>(await _callCreateAuthzPolicy.Async(request, callSettings).ConfigureAwait(false), CreateAuthzPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAuthzPolicy</c>.</summary>
        public override lro::OperationsClient UpdateAuthzPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AuthzPolicy, OperationMetadata> UpdateAuthzPolicy(UpdateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAuthzPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthzPolicy, OperationMetadata>(_callUpdateAuthzPolicy.Sync(request, callSettings), UpdateAuthzPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AuthzPolicy, OperationMetadata>> UpdateAuthzPolicyAsync(UpdateAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAuthzPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AuthzPolicy, OperationMetadata>(await _callUpdateAuthzPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateAuthzPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAuthzPolicy</c>.</summary>
        public override lro::OperationsClient DeleteAuthzPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthzPolicy(DeleteAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthzPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAuthzPolicy.Sync(request, callSettings), DeleteAuthzPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single AuthzPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthzPolicyAsync(DeleteAuthzPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthzPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAuthzPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteAuthzPolicyOperationsClient);
        }
    }

    public partial class ListAuthorizationPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackendAuthenticationConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServerTlsPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClientTlsPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGatewaySecurityPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGatewaySecurityPolicyRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUrlListsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTlsInspectionPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuthzPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuthorizationPoliciesResponse : gaxgrpc::IPageResponse<AuthorizationPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuthorizationPolicy> GetEnumerator() => AuthorizationPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackendAuthenticationConfigsResponse : gaxgrpc::IPageResponse<BackendAuthenticationConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackendAuthenticationConfig> GetEnumerator() =>
            BackendAuthenticationConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServerTlsPoliciesResponse : gaxgrpc::IPageResponse<ServerTlsPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServerTlsPolicy> GetEnumerator() => ServerTlsPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListClientTlsPoliciesResponse : gaxgrpc::IPageResponse<ClientTlsPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ClientTlsPolicy> GetEnumerator() => ClientTlsPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGatewaySecurityPoliciesResponse : gaxgrpc::IPageResponse<GatewaySecurityPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GatewaySecurityPolicy> GetEnumerator() => GatewaySecurityPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGatewaySecurityPolicyRulesResponse : gaxgrpc::IPageResponse<GatewaySecurityPolicyRule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GatewaySecurityPolicyRule> GetEnumerator() => GatewaySecurityPolicyRules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUrlListsResponse : gaxgrpc::IPageResponse<UrlList>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UrlList> GetEnumerator() => UrlLists.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTlsInspectionPoliciesResponse : gaxgrpc::IPageResponse<TlsInspectionPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TlsInspectionPolicy> GetEnumerator() => TlsInspectionPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAuthzPoliciesResponse : gaxgrpc::IPageResponse<AuthzPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuthzPolicy> GetEnumerator() => AuthzPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NetworkSecurity
    {
        public partial class NetworkSecurityClient
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

    public static partial class NetworkSecurity
    {
        public partial class NetworkSecurityClient
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
