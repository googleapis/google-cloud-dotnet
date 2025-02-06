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

namespace Google.Cloud.NetworkSecurity.V1Beta1
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkSecurity.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

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
            CreateServerTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServerTlsPolicyOperationsSettings, logger);
            UpdateServerTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServerTlsPolicyOperationsSettings, logger);
            DeleteServerTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServerTlsPolicyOperationsSettings, logger);
            CreateClientTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClientTlsPolicyOperationsSettings, logger);
            UpdateClientTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClientTlsPolicyOperationsSettings, logger);
            DeleteClientTlsPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClientTlsPolicyOperationsSettings, logger);
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
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAuthorizationPoliciesApiCall(ref gaxgrpc::ApiCall<ListAuthorizationPoliciesRequest, ListAuthorizationPoliciesResponse> call);

        partial void Modify_GetAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<GetAuthorizationPolicyRequest, AuthorizationPolicy> call);

        partial void Modify_CreateAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<CreateAuthorizationPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAuthorizationPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteAuthorizationPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAuthorizationPolicyRequest, lro::Operation> call);

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
    }

    public partial class ListAuthorizationPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServerTlsPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClientTlsPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuthorizationPoliciesResponse : gaxgrpc::IPageResponse<AuthorizationPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuthorizationPolicy> GetEnumerator() => AuthorizationPolicies.GetEnumerator();

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
