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
    /// <summary>Settings for <see cref="FirewallActivationClient"/> instances.</summary>
    public sealed partial class FirewallActivationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FirewallActivationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FirewallActivationSettings"/>.</returns>
        public static FirewallActivationSettings GetDefault() => new FirewallActivationSettings();

        /// <summary>Constructs a new <see cref="FirewallActivationSettings"/> object with default settings.</summary>
        public FirewallActivationSettings()
        {
        }

        private FirewallActivationSettings(FirewallActivationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListFirewallEndpointsSettings = existing.ListFirewallEndpointsSettings;
            ListProjectFirewallEndpointsSettings = existing.ListProjectFirewallEndpointsSettings;
            GetFirewallEndpointSettings = existing.GetFirewallEndpointSettings;
            GetProjectFirewallEndpointSettings = existing.GetProjectFirewallEndpointSettings;
            CreateFirewallEndpointSettings = existing.CreateFirewallEndpointSettings;
            CreateFirewallEndpointOperationsSettings = existing.CreateFirewallEndpointOperationsSettings.Clone();
            CreateProjectFirewallEndpointSettings = existing.CreateProjectFirewallEndpointSettings;
            CreateProjectFirewallEndpointOperationsSettings = existing.CreateProjectFirewallEndpointOperationsSettings.Clone();
            DeleteFirewallEndpointSettings = existing.DeleteFirewallEndpointSettings;
            DeleteFirewallEndpointOperationsSettings = existing.DeleteFirewallEndpointOperationsSettings.Clone();
            DeleteProjectFirewallEndpointSettings = existing.DeleteProjectFirewallEndpointSettings;
            DeleteProjectFirewallEndpointOperationsSettings = existing.DeleteProjectFirewallEndpointOperationsSettings.Clone();
            UpdateFirewallEndpointSettings = existing.UpdateFirewallEndpointSettings;
            UpdateFirewallEndpointOperationsSettings = existing.UpdateFirewallEndpointOperationsSettings.Clone();
            UpdateProjectFirewallEndpointSettings = existing.UpdateProjectFirewallEndpointSettings;
            UpdateProjectFirewallEndpointOperationsSettings = existing.UpdateProjectFirewallEndpointOperationsSettings.Clone();
            ListFirewallEndpointAssociationsSettings = existing.ListFirewallEndpointAssociationsSettings;
            GetFirewallEndpointAssociationSettings = existing.GetFirewallEndpointAssociationSettings;
            CreateFirewallEndpointAssociationSettings = existing.CreateFirewallEndpointAssociationSettings;
            CreateFirewallEndpointAssociationOperationsSettings = existing.CreateFirewallEndpointAssociationOperationsSettings.Clone();
            DeleteFirewallEndpointAssociationSettings = existing.DeleteFirewallEndpointAssociationSettings;
            DeleteFirewallEndpointAssociationOperationsSettings = existing.DeleteFirewallEndpointAssociationOperationsSettings.Clone();
            UpdateFirewallEndpointAssociationSettings = existing.UpdateFirewallEndpointAssociationSettings;
            UpdateFirewallEndpointAssociationOperationsSettings = existing.UpdateFirewallEndpointAssociationOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirewallActivationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.ListFirewallEndpoints</c> and
        /// <c>FirewallActivationClient.ListFirewallEndpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFirewallEndpointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.ListProjectFirewallEndpoints</c> and
        /// <c>FirewallActivationClient.ListProjectFirewallEndpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProjectFirewallEndpointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.GetFirewallEndpoint</c> and <c>FirewallActivationClient.GetFirewallEndpointAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.GetProjectFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.GetProjectFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProjectFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.CreateFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.CreateFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.CreateFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.CreateFirewallEndpointAsync</c>.
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
        public lro::OperationsSettings CreateFirewallEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.CreateProjectFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.CreateProjectFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProjectFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.CreateProjectFirewallEndpoint</c>
        /// and <c>FirewallActivationClient.CreateProjectFirewallEndpointAsync</c>.
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
        public lro::OperationsSettings CreateProjectFirewallEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.DeleteFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.DeleteFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.DeleteFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.DeleteFirewallEndpointAsync</c>.
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
        public lro::OperationsSettings DeleteFirewallEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.DeleteProjectFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.DeleteProjectFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProjectFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.DeleteProjectFirewallEndpoint</c>
        /// and <c>FirewallActivationClient.DeleteProjectFirewallEndpointAsync</c>.
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
        public lro::OperationsSettings DeleteProjectFirewallEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.UpdateFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.UpdateFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.UpdateFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.UpdateFirewallEndpointAsync</c>.
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
        public lro::OperationsSettings UpdateFirewallEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.UpdateProjectFirewallEndpoint</c> and
        /// <c>FirewallActivationClient.UpdateProjectFirewallEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProjectFirewallEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.UpdateProjectFirewallEndpoint</c>
        /// and <c>FirewallActivationClient.UpdateProjectFirewallEndpointAsync</c>.
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
        public lro::OperationsSettings UpdateProjectFirewallEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.ListFirewallEndpointAssociations</c> and
        /// <c>FirewallActivationClient.ListFirewallEndpointAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFirewallEndpointAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.GetFirewallEndpointAssociation</c> and
        /// <c>FirewallActivationClient.GetFirewallEndpointAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFirewallEndpointAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.CreateFirewallEndpointAssociation</c> and
        /// <c>FirewallActivationClient.CreateFirewallEndpointAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFirewallEndpointAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.CreateFirewallEndpointAssociation</c>
        ///  and <c>FirewallActivationClient.CreateFirewallEndpointAssociationAsync</c>.
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
        public lro::OperationsSettings CreateFirewallEndpointAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.DeleteFirewallEndpointAssociation</c> and
        /// <c>FirewallActivationClient.DeleteFirewallEndpointAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFirewallEndpointAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.DeleteFirewallEndpointAssociation</c>
        ///  and <c>FirewallActivationClient.DeleteFirewallEndpointAssociationAsync</c>.
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
        public lro::OperationsSettings DeleteFirewallEndpointAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallActivationClient.UpdateFirewallEndpointAssociation</c> and
        /// <c>FirewallActivationClient.UpdateFirewallEndpointAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFirewallEndpointAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirewallActivationClient.UpdateFirewallEndpointAssociation</c>
        ///  and <c>FirewallActivationClient.UpdateFirewallEndpointAssociationAsync</c>.
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
        public lro::OperationsSettings UpdateFirewallEndpointAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="FirewallActivationSettings"/> object.</returns>
        public FirewallActivationSettings Clone() => new FirewallActivationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirewallActivationClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FirewallActivationClientBuilder : gaxgrpc::ClientBuilderBase<FirewallActivationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FirewallActivationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FirewallActivationClientBuilder() : base(FirewallActivationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FirewallActivationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FirewallActivationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FirewallActivationClient Build()
        {
            FirewallActivationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FirewallActivationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FirewallActivationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FirewallActivationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirewallActivationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FirewallActivationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirewallActivationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirewallActivationClient.ChannelPool;
    }

    /// <summary>FirewallActivation client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Firewall Endpoints and Associations.
    /// </remarks>
    public abstract partial class FirewallActivationClient
    {
        /// <summary>
        /// The default endpoint for the FirewallActivation service, which is a host of "networksecurity.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default FirewallActivation scopes.</summary>
        /// <remarks>
        /// The default FirewallActivation scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FirewallActivation.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FirewallActivationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FirewallActivationClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FirewallActivationClient"/>.</returns>
        public static stt::Task<FirewallActivationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FirewallActivationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FirewallActivationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FirewallActivationClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="FirewallActivationClient"/>.</returns>
        public static FirewallActivationClient Create() => new FirewallActivationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FirewallActivationClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FirewallActivationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FirewallActivationClient"/>.</returns>
        internal static FirewallActivationClient Create(grpccore::CallInvoker callInvoker, FirewallActivationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FirewallActivation.FirewallActivationClient grpcClient = new FirewallActivation.FirewallActivationClient(callInvoker);
            return new FirewallActivationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FirewallActivation client</summary>
        public virtual FirewallActivation.FirewallActivationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpoints(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpointsAsync(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListFirewallEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListFirewallEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpoints(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFirewallEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpointsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFirewallEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListFirewallEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListFirewallEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpoints(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpointsAsync(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListProjectFirewallEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListProjectFirewallEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpoints(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectFirewallEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpointsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectFirewallEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListProjectFirewallEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEndpointsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
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
            return ListProjectFirewallEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpoint GetFirewallEndpoint(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(GetFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpoint GetFirewallEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpoint(new GetFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpointAsync(new GetFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpoint GetFirewallEndpoint(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpoint(new GetFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpointAsync(new GetFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(FirewallEndpointName name, st::CancellationToken cancellationToken) =>
            GetFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpoint GetProjectFirewallEndpoint(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(GetFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetProjectFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpoint GetProjectFirewallEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectFirewallEndpoint(new GetFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectFirewallEndpointAsync(new GetFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetProjectFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpoint GetProjectFirewallEndpoint(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectFirewallEndpoint(new GetFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectFirewallEndpointAsync(new GetFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(FirewallEndpointName name, st::CancellationToken cancellationToken) =>
            GetProjectFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateFirewallEndpoint(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(CreateFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFirewallEndpoint</c>.</summary>
        public virtual lro::OperationsClient CreateFirewallEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> PollOnceCreateFirewallEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> PollOnceCreateFirewallEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateFirewallEndpoint(string parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpoint(new CreateFirewallEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(string parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAsync(new CreateFirewallEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(string parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateFirewallEndpoint(OrganizationLocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpoint(new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(OrganizationLocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAsync(new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(OrganizationLocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateFirewallEndpoint(gagr::LocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpoint(new CreateFirewallEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(gagr::LocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAsync(new CreateFirewallEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(gagr::LocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateProjectFirewallEndpoint(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(CreateFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateProjectFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateProjectFirewallEndpoint</c>.</summary>
        public virtual lro::OperationsClient CreateProjectFirewallEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateProjectFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> PollOnceCreateProjectFirewallEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProjectFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateProjectFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> PollOnceCreateProjectFirewallEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProjectFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateProjectFirewallEndpoint(string parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectFirewallEndpoint(new CreateFirewallEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(string parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectFirewallEndpointAsync(new CreateFirewallEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(string parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, st::CancellationToken cancellationToken) =>
            CreateProjectFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateProjectFirewallEndpoint(OrganizationLocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectFirewallEndpoint(new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(OrganizationLocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectFirewallEndpointAsync(new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(OrganizationLocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, st::CancellationToken cancellationToken) =>
            CreateProjectFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> CreateProjectFirewallEndpoint(gagr::LocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectFirewallEndpoint(new CreateFirewallEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(gagr::LocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectFirewallEndpointAsync(new CreateFirewallEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpoint">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointId">
        /// Required. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(gagr::LocationName parent, FirewallEndpoint firewallEndpoint, string firewallEndpointId, st::CancellationToken cancellationToken) =>
            CreateProjectFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpoint(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(DeleteFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFirewallEndpoint</c>.</summary>
        public virtual lro::OperationsClient DeleteFirewallEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFirewallEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFirewallEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpoint(new DeleteFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpointAsync(new DeleteFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpoint(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpoint(new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpointAsync(new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(FirewallEndpointName name, st::CancellationToken cancellationToken) =>
            DeleteFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProjectFirewallEndpoint(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(DeleteFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteProjectFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProjectFirewallEndpoint</c>.</summary>
        public virtual lro::OperationsClient DeleteProjectFirewallEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProjectFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteProjectFirewallEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProjectFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProjectFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteProjectFirewallEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProjectFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProjectFirewallEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProjectFirewallEndpoint(new DeleteFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProjectFirewallEndpointAsync(new DeleteFirewallEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProjectFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProjectFirewallEndpoint(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProjectFirewallEndpoint(new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(FirewallEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProjectFirewallEndpointAsync(new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(FirewallEndpointName name, st::CancellationToken cancellationToken) =>
            DeleteProjectFirewallEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> UpdateFirewallEndpoint(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateFirewallEndpointAsync(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateFirewallEndpointAsync(UpdateFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFirewallEndpoint</c>.</summary>
        public virtual lro::OperationsClient UpdateFirewallEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> PollOnceUpdateFirewallEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> PollOnceUpdateFirewallEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="firewallEndpoint">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Endpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> UpdateFirewallEndpoint(FirewallEndpoint firewallEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFirewallEndpoint(new UpdateFirewallEndpointRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="firewallEndpoint">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Endpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateFirewallEndpointAsync(FirewallEndpoint firewallEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFirewallEndpointAsync(new UpdateFirewallEndpointRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="firewallEndpoint">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Endpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateFirewallEndpointAsync(FirewallEndpoint firewallEndpoint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFirewallEndpointAsync(firewallEndpoint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> UpdateProjectFirewallEndpoint(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateProjectFirewallEndpointAsync(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateProjectFirewallEndpointAsync(UpdateFirewallEndpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateProjectFirewallEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateProjectFirewallEndpoint</c>.</summary>
        public virtual lro::OperationsClient UpdateProjectFirewallEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateProjectFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> PollOnceUpdateProjectFirewallEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProjectFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateProjectFirewallEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> PollOnceUpdateProjectFirewallEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpoint, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProjectFirewallEndpointOperationsClient, callSettings);

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="firewallEndpoint">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Endpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpoint, OperationMetadata> UpdateProjectFirewallEndpoint(FirewallEndpoint firewallEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectFirewallEndpoint(new UpdateFirewallEndpointRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="firewallEndpoint">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Endpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateProjectFirewallEndpointAsync(FirewallEndpoint firewallEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectFirewallEndpointAsync(new UpdateFirewallEndpointRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FirewallEndpoint = gax::GaxPreconditions.CheckNotNull(firewallEndpoint, nameof(firewallEndpoint)),
            }, callSettings);

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="firewallEndpoint">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Endpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateProjectFirewallEndpointAsync(FirewallEndpoint firewallEndpoint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProjectFirewallEndpointAsync(firewallEndpoint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociations(ListFirewallEndpointAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociationsAsync(ListFirewallEndpointAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAssociationsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointAssociationsRequest request = new ListFirewallEndpointAssociationsRequest
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
            return ListFirewallEndpointAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAssociationsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointAssociationsRequest request = new ListFirewallEndpointAssociationsRequest
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
            return ListFirewallEndpointAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAssociationsRequest
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
        /// <returns>A pageable sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointAssociationsRequest request = new ListFirewallEndpointAssociationsRequest
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
            return ListFirewallEndpointAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAssociationsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFirewallEndpointAssociationsRequest request = new ListFirewallEndpointAssociationsRequest
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
            return ListFirewallEndpointAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpointAssociation GetFirewallEndpointAssociation(GetFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(GetFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(GetFirewallEndpointAssociationRequest request, st::CancellationToken cancellationToken) =>
            GetFirewallEndpointAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpointAssociation GetFirewallEndpointAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpointAssociation(new GetFirewallEndpointAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpointAssociationAsync(new GetFirewallEndpointAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            GetFirewallEndpointAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallEndpointAssociation GetFirewallEndpointAssociation(FirewallEndpointAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpointAssociation(new GetFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(FirewallEndpointAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFirewallEndpointAssociationAsync(new GetFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(FirewallEndpointAssociationName name, st::CancellationToken cancellationToken) =>
            GetFirewallEndpointAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> CreateFirewallEndpointAssociation(CreateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(CreateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(CreateFirewallEndpointAssociationRequest request, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFirewallEndpointAssociation</c>.</summary>
        public virtual lro::OperationsClient CreateFirewallEndpointAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFirewallEndpointAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> PollOnceCreateFirewallEndpointAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpointAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFirewallEndpointAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFirewallEndpointAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> PollOnceCreateFirewallEndpointAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpointAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFirewallEndpointAssociationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointAssociationId">
        /// Optional. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_association_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> CreateFirewallEndpointAssociation(string parent, FirewallEndpointAssociation firewallEndpointAssociation, string firewallEndpointAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAssociation(new CreateFirewallEndpointAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirewallEndpointAssociationId = firewallEndpointAssociationId ?? "",
                FirewallEndpointAssociation = gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociation, nameof(firewallEndpointAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointAssociationId">
        /// Optional. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_association_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(string parent, FirewallEndpointAssociation firewallEndpointAssociation, string firewallEndpointAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAssociationAsync(new CreateFirewallEndpointAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FirewallEndpointAssociationId = firewallEndpointAssociationId ?? "",
                FirewallEndpointAssociation = gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociation, nameof(firewallEndpointAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointAssociationId">
        /// Optional. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_association_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(string parent, FirewallEndpointAssociation firewallEndpointAssociation, string firewallEndpointAssociationId, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAssociationAsync(parent, firewallEndpointAssociation, firewallEndpointAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointAssociationId">
        /// Optional. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_association_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> CreateFirewallEndpointAssociation(gagr::LocationName parent, FirewallEndpointAssociation firewallEndpointAssociation, string firewallEndpointAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAssociation(new CreateFirewallEndpointAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointAssociationId = firewallEndpointAssociationId ?? "",
                FirewallEndpointAssociation = gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociation, nameof(firewallEndpointAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointAssociationId">
        /// Optional. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_association_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(gagr::LocationName parent, FirewallEndpointAssociation firewallEndpointAssociation, string firewallEndpointAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFirewallEndpointAssociationAsync(new CreateFirewallEndpointAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FirewallEndpointAssociationId = firewallEndpointAssociationId ?? "",
                FirewallEndpointAssociation = gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociation, nameof(firewallEndpointAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="firewallEndpointAssociationId">
        /// Optional. Id of the requesting object.
        /// If auto-generating Id server-side, remove this field and
        /// firewall_endpoint_association_id from the method_signature of Create RPC.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(gagr::LocationName parent, FirewallEndpointAssociation firewallEndpointAssociation, string firewallEndpointAssociationId, st::CancellationToken cancellationToken) =>
            CreateFirewallEndpointAssociationAsync(parent, firewallEndpointAssociation, firewallEndpointAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpointAssociation(DeleteFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(DeleteFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(DeleteFirewallEndpointAssociationRequest request, st::CancellationToken cancellationToken) =>
            DeleteFirewallEndpointAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFirewallEndpointAssociation</c>.</summary>
        public virtual lro::OperationsClient DeleteFirewallEndpointAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFirewallEndpointAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFirewallEndpointAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFirewallEndpointAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFirewallEndpointAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFirewallEndpointAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFirewallEndpointAssociationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpointAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpointAssociation(new DeleteFirewallEndpointAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpointAssociationAsync(new DeleteFirewallEndpointAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFirewallEndpointAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpointAssociation(FirewallEndpointAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpointAssociation(new DeleteFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(FirewallEndpointAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFirewallEndpointAssociationAsync(new DeleteFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(FirewallEndpointAssociationName name, st::CancellationToken cancellationToken) =>
            DeleteFirewallEndpointAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> UpdateFirewallEndpointAssociation(UpdateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> UpdateFirewallEndpointAssociationAsync(UpdateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> UpdateFirewallEndpointAssociationAsync(UpdateFirewallEndpointAssociationRequest request, st::CancellationToken cancellationToken) =>
            UpdateFirewallEndpointAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFirewallEndpointAssociation</c>.</summary>
        public virtual lro::OperationsClient UpdateFirewallEndpointAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFirewallEndpointAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> PollOnceUpdateFirewallEndpointAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpointAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFirewallEndpointAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFirewallEndpointAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> PollOnceUpdateFirewallEndpointAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FirewallEndpointAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFirewallEndpointAssociationOperationsClient, callSettings);

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Association resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FirewallEndpointAssociation, OperationMetadata> UpdateFirewallEndpointAssociation(FirewallEndpointAssociation firewallEndpointAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFirewallEndpointAssociation(new UpdateFirewallEndpointAssociationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FirewallEndpointAssociation = gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociation, nameof(firewallEndpointAssociation)),
            }, callSettings);

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Association resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> UpdateFirewallEndpointAssociationAsync(FirewallEndpointAssociation firewallEndpointAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFirewallEndpointAssociationAsync(new UpdateFirewallEndpointAssociationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FirewallEndpointAssociation = gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociation, nameof(firewallEndpointAssociation)),
            }, callSettings);

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="firewallEndpointAssociation">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Association resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> UpdateFirewallEndpointAssociationAsync(FirewallEndpointAssociation firewallEndpointAssociation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFirewallEndpointAssociationAsync(firewallEndpointAssociation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FirewallActivation client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Firewall Endpoints and Associations.
    /// </remarks>
    public sealed partial class FirewallActivationClientImpl : FirewallActivationClient
    {
        private readonly gaxgrpc::ApiCall<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse> _callListFirewallEndpoints;

        private readonly gaxgrpc::ApiCall<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse> _callListProjectFirewallEndpoints;

        private readonly gaxgrpc::ApiCall<GetFirewallEndpointRequest, FirewallEndpoint> _callGetFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<GetFirewallEndpointRequest, FirewallEndpoint> _callGetProjectFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<CreateFirewallEndpointRequest, lro::Operation> _callCreateFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<CreateFirewallEndpointRequest, lro::Operation> _callCreateProjectFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<DeleteFirewallEndpointRequest, lro::Operation> _callDeleteFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<DeleteFirewallEndpointRequest, lro::Operation> _callDeleteProjectFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<UpdateFirewallEndpointRequest, lro::Operation> _callUpdateFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<UpdateFirewallEndpointRequest, lro::Operation> _callUpdateProjectFirewallEndpoint;

        private readonly gaxgrpc::ApiCall<ListFirewallEndpointAssociationsRequest, ListFirewallEndpointAssociationsResponse> _callListFirewallEndpointAssociations;

        private readonly gaxgrpc::ApiCall<GetFirewallEndpointAssociationRequest, FirewallEndpointAssociation> _callGetFirewallEndpointAssociation;

        private readonly gaxgrpc::ApiCall<CreateFirewallEndpointAssociationRequest, lro::Operation> _callCreateFirewallEndpointAssociation;

        private readonly gaxgrpc::ApiCall<DeleteFirewallEndpointAssociationRequest, lro::Operation> _callDeleteFirewallEndpointAssociation;

        private readonly gaxgrpc::ApiCall<UpdateFirewallEndpointAssociationRequest, lro::Operation> _callUpdateFirewallEndpointAssociation;

        /// <summary>
        /// Constructs a client wrapper for the FirewallActivation service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirewallActivationSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FirewallActivationClientImpl(FirewallActivation.FirewallActivationClient grpcClient, FirewallActivationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FirewallActivationSettings effectiveSettings = settings ?? FirewallActivationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFirewallEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFirewallEndpointOperationsSettings, logger);
            CreateProjectFirewallEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateProjectFirewallEndpointOperationsSettings, logger);
            DeleteFirewallEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFirewallEndpointOperationsSettings, logger);
            DeleteProjectFirewallEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProjectFirewallEndpointOperationsSettings, logger);
            UpdateFirewallEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFirewallEndpointOperationsSettings, logger);
            UpdateProjectFirewallEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateProjectFirewallEndpointOperationsSettings, logger);
            CreateFirewallEndpointAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFirewallEndpointAssociationOperationsSettings, logger);
            DeleteFirewallEndpointAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFirewallEndpointAssociationOperationsSettings, logger);
            UpdateFirewallEndpointAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFirewallEndpointAssociationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListFirewallEndpoints = clientHelper.BuildApiCall<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse>("ListFirewallEndpoints", grpcClient.ListFirewallEndpointsAsync, grpcClient.ListFirewallEndpoints, effectiveSettings.ListFirewallEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFirewallEndpoints);
            Modify_ListFirewallEndpointsApiCall(ref _callListFirewallEndpoints);
            _callListProjectFirewallEndpoints = clientHelper.BuildApiCall<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse>("ListProjectFirewallEndpoints", grpcClient.ListProjectFirewallEndpointsAsync, grpcClient.ListProjectFirewallEndpoints, effectiveSettings.ListProjectFirewallEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProjectFirewallEndpoints);
            Modify_ListProjectFirewallEndpointsApiCall(ref _callListProjectFirewallEndpoints);
            _callGetFirewallEndpoint = clientHelper.BuildApiCall<GetFirewallEndpointRequest, FirewallEndpoint>("GetFirewallEndpoint", grpcClient.GetFirewallEndpointAsync, grpcClient.GetFirewallEndpoint, effectiveSettings.GetFirewallEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFirewallEndpoint);
            Modify_GetFirewallEndpointApiCall(ref _callGetFirewallEndpoint);
            _callGetProjectFirewallEndpoint = clientHelper.BuildApiCall<GetFirewallEndpointRequest, FirewallEndpoint>("GetProjectFirewallEndpoint", grpcClient.GetProjectFirewallEndpointAsync, grpcClient.GetProjectFirewallEndpoint, effectiveSettings.GetProjectFirewallEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProjectFirewallEndpoint);
            Modify_GetProjectFirewallEndpointApiCall(ref _callGetProjectFirewallEndpoint);
            _callCreateFirewallEndpoint = clientHelper.BuildApiCall<CreateFirewallEndpointRequest, lro::Operation>("CreateFirewallEndpoint", grpcClient.CreateFirewallEndpointAsync, grpcClient.CreateFirewallEndpoint, effectiveSettings.CreateFirewallEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFirewallEndpoint);
            Modify_CreateFirewallEndpointApiCall(ref _callCreateFirewallEndpoint);
            _callCreateProjectFirewallEndpoint = clientHelper.BuildApiCall<CreateFirewallEndpointRequest, lro::Operation>("CreateProjectFirewallEndpoint", grpcClient.CreateProjectFirewallEndpointAsync, grpcClient.CreateProjectFirewallEndpoint, effectiveSettings.CreateProjectFirewallEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProjectFirewallEndpoint);
            Modify_CreateProjectFirewallEndpointApiCall(ref _callCreateProjectFirewallEndpoint);
            _callDeleteFirewallEndpoint = clientHelper.BuildApiCall<DeleteFirewallEndpointRequest, lro::Operation>("DeleteFirewallEndpoint", grpcClient.DeleteFirewallEndpointAsync, grpcClient.DeleteFirewallEndpoint, effectiveSettings.DeleteFirewallEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFirewallEndpoint);
            Modify_DeleteFirewallEndpointApiCall(ref _callDeleteFirewallEndpoint);
            _callDeleteProjectFirewallEndpoint = clientHelper.BuildApiCall<DeleteFirewallEndpointRequest, lro::Operation>("DeleteProjectFirewallEndpoint", grpcClient.DeleteProjectFirewallEndpointAsync, grpcClient.DeleteProjectFirewallEndpoint, effectiveSettings.DeleteProjectFirewallEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProjectFirewallEndpoint);
            Modify_DeleteProjectFirewallEndpointApiCall(ref _callDeleteProjectFirewallEndpoint);
            _callUpdateFirewallEndpoint = clientHelper.BuildApiCall<UpdateFirewallEndpointRequest, lro::Operation>("UpdateFirewallEndpoint", grpcClient.UpdateFirewallEndpointAsync, grpcClient.UpdateFirewallEndpoint, effectiveSettings.UpdateFirewallEndpointSettings).WithGoogleRequestParam("firewall_endpoint.name", request => request.FirewallEndpoint?.Name);
            Modify_ApiCall(ref _callUpdateFirewallEndpoint);
            Modify_UpdateFirewallEndpointApiCall(ref _callUpdateFirewallEndpoint);
            _callUpdateProjectFirewallEndpoint = clientHelper.BuildApiCall<UpdateFirewallEndpointRequest, lro::Operation>("UpdateProjectFirewallEndpoint", grpcClient.UpdateProjectFirewallEndpointAsync, grpcClient.UpdateProjectFirewallEndpoint, effectiveSettings.UpdateProjectFirewallEndpointSettings).WithGoogleRequestParam("firewall_endpoint.name", request => request.FirewallEndpoint?.Name);
            Modify_ApiCall(ref _callUpdateProjectFirewallEndpoint);
            Modify_UpdateProjectFirewallEndpointApiCall(ref _callUpdateProjectFirewallEndpoint);
            _callListFirewallEndpointAssociations = clientHelper.BuildApiCall<ListFirewallEndpointAssociationsRequest, ListFirewallEndpointAssociationsResponse>("ListFirewallEndpointAssociations", grpcClient.ListFirewallEndpointAssociationsAsync, grpcClient.ListFirewallEndpointAssociations, effectiveSettings.ListFirewallEndpointAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFirewallEndpointAssociations);
            Modify_ListFirewallEndpointAssociationsApiCall(ref _callListFirewallEndpointAssociations);
            _callGetFirewallEndpointAssociation = clientHelper.BuildApiCall<GetFirewallEndpointAssociationRequest, FirewallEndpointAssociation>("GetFirewallEndpointAssociation", grpcClient.GetFirewallEndpointAssociationAsync, grpcClient.GetFirewallEndpointAssociation, effectiveSettings.GetFirewallEndpointAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFirewallEndpointAssociation);
            Modify_GetFirewallEndpointAssociationApiCall(ref _callGetFirewallEndpointAssociation);
            _callCreateFirewallEndpointAssociation = clientHelper.BuildApiCall<CreateFirewallEndpointAssociationRequest, lro::Operation>("CreateFirewallEndpointAssociation", grpcClient.CreateFirewallEndpointAssociationAsync, grpcClient.CreateFirewallEndpointAssociation, effectiveSettings.CreateFirewallEndpointAssociationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFirewallEndpointAssociation);
            Modify_CreateFirewallEndpointAssociationApiCall(ref _callCreateFirewallEndpointAssociation);
            _callDeleteFirewallEndpointAssociation = clientHelper.BuildApiCall<DeleteFirewallEndpointAssociationRequest, lro::Operation>("DeleteFirewallEndpointAssociation", grpcClient.DeleteFirewallEndpointAssociationAsync, grpcClient.DeleteFirewallEndpointAssociation, effectiveSettings.DeleteFirewallEndpointAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFirewallEndpointAssociation);
            Modify_DeleteFirewallEndpointAssociationApiCall(ref _callDeleteFirewallEndpointAssociation);
            _callUpdateFirewallEndpointAssociation = clientHelper.BuildApiCall<UpdateFirewallEndpointAssociationRequest, lro::Operation>("UpdateFirewallEndpointAssociation", grpcClient.UpdateFirewallEndpointAssociationAsync, grpcClient.UpdateFirewallEndpointAssociation, effectiveSettings.UpdateFirewallEndpointAssociationSettings).WithGoogleRequestParam("firewall_endpoint_association.name", request => request.FirewallEndpointAssociation?.Name);
            Modify_ApiCall(ref _callUpdateFirewallEndpointAssociation);
            Modify_UpdateFirewallEndpointAssociationApiCall(ref _callUpdateFirewallEndpointAssociation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListFirewallEndpointsApiCall(ref gaxgrpc::ApiCall<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse> call);

        partial void Modify_ListProjectFirewallEndpointsApiCall(ref gaxgrpc::ApiCall<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse> call);

        partial void Modify_GetFirewallEndpointApiCall(ref gaxgrpc::ApiCall<GetFirewallEndpointRequest, FirewallEndpoint> call);

        partial void Modify_GetProjectFirewallEndpointApiCall(ref gaxgrpc::ApiCall<GetFirewallEndpointRequest, FirewallEndpoint> call);

        partial void Modify_CreateFirewallEndpointApiCall(ref gaxgrpc::ApiCall<CreateFirewallEndpointRequest, lro::Operation> call);

        partial void Modify_CreateProjectFirewallEndpointApiCall(ref gaxgrpc::ApiCall<CreateFirewallEndpointRequest, lro::Operation> call);

        partial void Modify_DeleteFirewallEndpointApiCall(ref gaxgrpc::ApiCall<DeleteFirewallEndpointRequest, lro::Operation> call);

        partial void Modify_DeleteProjectFirewallEndpointApiCall(ref gaxgrpc::ApiCall<DeleteFirewallEndpointRequest, lro::Operation> call);

        partial void Modify_UpdateFirewallEndpointApiCall(ref gaxgrpc::ApiCall<UpdateFirewallEndpointRequest, lro::Operation> call);

        partial void Modify_UpdateProjectFirewallEndpointApiCall(ref gaxgrpc::ApiCall<UpdateFirewallEndpointRequest, lro::Operation> call);

        partial void Modify_ListFirewallEndpointAssociationsApiCall(ref gaxgrpc::ApiCall<ListFirewallEndpointAssociationsRequest, ListFirewallEndpointAssociationsResponse> call);

        partial void Modify_GetFirewallEndpointAssociationApiCall(ref gaxgrpc::ApiCall<GetFirewallEndpointAssociationRequest, FirewallEndpointAssociation> call);

        partial void Modify_CreateFirewallEndpointAssociationApiCall(ref gaxgrpc::ApiCall<CreateFirewallEndpointAssociationRequest, lro::Operation> call);

        partial void Modify_DeleteFirewallEndpointAssociationApiCall(ref gaxgrpc::ApiCall<DeleteFirewallEndpointAssociationRequest, lro::Operation> call);

        partial void Modify_UpdateFirewallEndpointAssociationApiCall(ref gaxgrpc::ApiCall<UpdateFirewallEndpointAssociationRequest, lro::Operation> call);

        partial void OnConstruction(FirewallActivation.FirewallActivationClient grpcClient, FirewallActivationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FirewallActivation client</summary>
        public override FirewallActivation.FirewallActivationClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListFirewallEndpointsRequest(ref ListFirewallEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFirewallEndpointRequest(ref GetFirewallEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFirewallEndpointRequest(ref CreateFirewallEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFirewallEndpointRequest(ref DeleteFirewallEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFirewallEndpointRequest(ref UpdateFirewallEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFirewallEndpointAssociationsRequest(ref ListFirewallEndpointAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFirewallEndpointAssociationRequest(ref GetFirewallEndpointAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFirewallEndpointAssociationRequest(ref CreateFirewallEndpointAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFirewallEndpointAssociationRequest(ref DeleteFirewallEndpointAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFirewallEndpointAssociationRequest(ref UpdateFirewallEndpointAssociationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpoints(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse, FirewallEndpoint>(_callListFirewallEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListFirewallEndpointsAsync(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse, FirewallEndpoint>(_callListFirewallEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpoints(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse, FirewallEndpoint>(_callListProjectFirewallEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists FirewallEndpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> ListProjectFirewallEndpointsAsync(ListFirewallEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFirewallEndpointsRequest, ListFirewallEndpointsResponse, FirewallEndpoint>(_callListProjectFirewallEndpoints, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallEndpoint GetFirewallEndpoint(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallEndpointRequest(ref request, ref callSettings);
            return _callGetFirewallEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallEndpoint> GetFirewallEndpointAsync(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallEndpointRequest(ref request, ref callSettings);
            return _callGetFirewallEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallEndpoint GetProjectFirewallEndpoint(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallEndpointRequest(ref request, ref callSettings);
            return _callGetProjectFirewallEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallEndpoint> GetProjectFirewallEndpointAsync(GetFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallEndpointRequest(ref request, ref callSettings);
            return _callGetProjectFirewallEndpoint.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFirewallEndpoint</c>.</summary>
        public override lro::OperationsClient CreateFirewallEndpointOperationsClient { get; }

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FirewallEndpoint, OperationMetadata> CreateFirewallEndpoint(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(_callCreateFirewallEndpoint.Sync(request, callSettings), CreateFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Creates a new FirewallEndpoint in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateFirewallEndpointAsync(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(await _callCreateFirewallEndpoint.Async(request, callSettings).ConfigureAwait(false), CreateFirewallEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateProjectFirewallEndpoint</c>.</summary>
        public override lro::OperationsClient CreateProjectFirewallEndpointOperationsClient { get; }

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FirewallEndpoint, OperationMetadata> CreateProjectFirewallEndpoint(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(_callCreateProjectFirewallEndpoint.Sync(request, callSettings), CreateProjectFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Creates a new FirewallEndpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> CreateProjectFirewallEndpointAsync(CreateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(await _callCreateProjectFirewallEndpoint.Async(request, callSettings).ConfigureAwait(false), CreateProjectFirewallEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFirewallEndpoint</c>.</summary>
        public override lro::OperationsClient DeleteFirewallEndpointOperationsClient { get; }

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpoint(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFirewallEndpoint.Sync(request, callSettings), DeleteFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Deletes a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAsync(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFirewallEndpoint.Async(request, callSettings).ConfigureAwait(false), DeleteFirewallEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteProjectFirewallEndpoint</c>.</summary>
        public override lro::OperationsClient DeleteProjectFirewallEndpointOperationsClient { get; }

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteProjectFirewallEndpoint(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteProjectFirewallEndpoint.Sync(request, callSettings), DeleteProjectFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Deletes a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProjectFirewallEndpointAsync(DeleteFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteProjectFirewallEndpoint.Async(request, callSettings).ConfigureAwait(false), DeleteProjectFirewallEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFirewallEndpoint</c>.</summary>
        public override lro::OperationsClient UpdateFirewallEndpointOperationsClient { get; }

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FirewallEndpoint, OperationMetadata> UpdateFirewallEndpoint(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(_callUpdateFirewallEndpoint.Sync(request, callSettings), UpdateFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Update a single org Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateFirewallEndpointAsync(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(await _callUpdateFirewallEndpoint.Async(request, callSettings).ConfigureAwait(false), UpdateFirewallEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateProjectFirewallEndpoint</c>.</summary>
        public override lro::OperationsClient UpdateProjectFirewallEndpointOperationsClient { get; }

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FirewallEndpoint, OperationMetadata> UpdateProjectFirewallEndpoint(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(_callUpdateProjectFirewallEndpoint.Sync(request, callSettings), UpdateProjectFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Update a single project Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FirewallEndpoint, OperationMetadata>> UpdateProjectFirewallEndpointAsync(UpdateFirewallEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFirewallEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpoint, OperationMetadata>(await _callUpdateProjectFirewallEndpoint.Async(request, callSettings).ConfigureAwait(false), UpdateProjectFirewallEndpointOperationsClient);
        }

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public override gax::PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociations(ListFirewallEndpointAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallEndpointAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFirewallEndpointAssociationsRequest, ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation>(_callListFirewallEndpointAssociations, request, callSettings);
        }

        /// <summary>
        /// Lists Associations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallEndpointAssociation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> ListFirewallEndpointAssociationsAsync(ListFirewallEndpointAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFirewallEndpointAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFirewallEndpointAssociationsRequest, ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation>(_callListFirewallEndpointAssociations, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallEndpointAssociation GetFirewallEndpointAssociation(GetFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return _callGetFirewallEndpointAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallEndpointAssociation> GetFirewallEndpointAssociationAsync(GetFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return _callGetFirewallEndpointAssociation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFirewallEndpointAssociation</c>.</summary>
        public override lro::OperationsClient CreateFirewallEndpointAssociationOperationsClient { get; }

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FirewallEndpointAssociation, OperationMetadata> CreateFirewallEndpointAssociation(CreateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpointAssociation, OperationMetadata>(_callCreateFirewallEndpointAssociation.Sync(request, callSettings), CreateFirewallEndpointAssociationOperationsClient);
        }

        /// <summary>
        /// Creates a new FirewallEndpointAssociation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> CreateFirewallEndpointAssociationAsync(CreateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpointAssociation, OperationMetadata>(await _callCreateFirewallEndpointAssociation.Async(request, callSettings).ConfigureAwait(false), CreateFirewallEndpointAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFirewallEndpointAssociation</c>.</summary>
        public override lro::OperationsClient DeleteFirewallEndpointAssociationOperationsClient { get; }

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFirewallEndpointAssociation(DeleteFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFirewallEndpointAssociation.Sync(request, callSettings), DeleteFirewallEndpointAssociationOperationsClient);
        }

        /// <summary>
        /// Deletes a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFirewallEndpointAssociationAsync(DeleteFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFirewallEndpointAssociation.Async(request, callSettings).ConfigureAwait(false), DeleteFirewallEndpointAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFirewallEndpointAssociation</c>.</summary>
        public override lro::OperationsClient UpdateFirewallEndpointAssociationOperationsClient { get; }

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FirewallEndpointAssociation, OperationMetadata> UpdateFirewallEndpointAssociation(UpdateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpointAssociation, OperationMetadata>(_callUpdateFirewallEndpointAssociation.Sync(request, callSettings), UpdateFirewallEndpointAssociationOperationsClient);
        }

        /// <summary>
        /// Update a single FirewallEndpointAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FirewallEndpointAssociation, OperationMetadata>> UpdateFirewallEndpointAssociationAsync(UpdateFirewallEndpointAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFirewallEndpointAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<FirewallEndpointAssociation, OperationMetadata>(await _callUpdateFirewallEndpointAssociation.Async(request, callSettings).ConfigureAwait(false), UpdateFirewallEndpointAssociationOperationsClient);
        }
    }

    public partial class ListFirewallEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFirewallEndpointAssociationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFirewallEndpointsResponse : gaxgrpc::IPageResponse<FirewallEndpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FirewallEndpoint> GetEnumerator() => FirewallEndpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFirewallEndpointAssociationsResponse : gaxgrpc::IPageResponse<FirewallEndpointAssociation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FirewallEndpointAssociation> GetEnumerator() =>
            FirewallEndpointAssociations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class FirewallActivation
    {
        public partial class FirewallActivationClient
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

    public static partial class FirewallActivation
    {
        public partial class FirewallActivationClient
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
