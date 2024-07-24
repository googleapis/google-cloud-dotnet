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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using gt = Google.Type;
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

namespace Google.Cloud.Domains.V1Beta1
{
    /// <summary>Settings for <see cref="DomainsClient"/> instances.</summary>
    public sealed partial class DomainsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DomainsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DomainsSettings"/>.</returns>
        public static DomainsSettings GetDefault() => new DomainsSettings();

        /// <summary>Constructs a new <see cref="DomainsSettings"/> object with default settings.</summary>
        public DomainsSettings()
        {
        }

        private DomainsSettings(DomainsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchDomainsSettings = existing.SearchDomainsSettings;
            RetrieveRegisterParametersSettings = existing.RetrieveRegisterParametersSettings;
            RegisterDomainSettings = existing.RegisterDomainSettings;
            RegisterDomainOperationsSettings = existing.RegisterDomainOperationsSettings.Clone();
            RetrieveTransferParametersSettings = existing.RetrieveTransferParametersSettings;
            TransferDomainSettings = existing.TransferDomainSettings;
            TransferDomainOperationsSettings = existing.TransferDomainOperationsSettings.Clone();
            ListRegistrationsSettings = existing.ListRegistrationsSettings;
            GetRegistrationSettings = existing.GetRegistrationSettings;
            UpdateRegistrationSettings = existing.UpdateRegistrationSettings;
            UpdateRegistrationOperationsSettings = existing.UpdateRegistrationOperationsSettings.Clone();
            ConfigureManagementSettingsSettings = existing.ConfigureManagementSettingsSettings;
            ConfigureManagementSettingsOperationsSettings = existing.ConfigureManagementSettingsOperationsSettings.Clone();
            ConfigureDnsSettingsSettings = existing.ConfigureDnsSettingsSettings;
            ConfigureDnsSettingsOperationsSettings = existing.ConfigureDnsSettingsOperationsSettings.Clone();
            ConfigureContactSettingsSettings = existing.ConfigureContactSettingsSettings;
            ConfigureContactSettingsOperationsSettings = existing.ConfigureContactSettingsOperationsSettings.Clone();
            ExportRegistrationSettings = existing.ExportRegistrationSettings;
            ExportRegistrationOperationsSettings = existing.ExportRegistrationOperationsSettings.Clone();
            DeleteRegistrationSettings = existing.DeleteRegistrationSettings;
            DeleteRegistrationOperationsSettings = existing.DeleteRegistrationOperationsSettings.Clone();
            RetrieveAuthorizationCodeSettings = existing.RetrieveAuthorizationCodeSettings;
            ResetAuthorizationCodeSettings = existing.ResetAuthorizationCodeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DomainsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DomainsClient.SearchDomains</c>
        ///  and <c>DomainsClient.SearchDomainsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchDomainsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.RetrieveRegisterParameters</c> and <c>DomainsClient.RetrieveRegisterParametersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveRegisterParametersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.RegisterDomain</c> and <c>DomainsClient.RegisterDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegisterDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.RegisterDomain</c> and
        /// <c>DomainsClient.RegisterDomainAsync</c>.
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
        public lro::OperationsSettings RegisterDomainOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.RetrieveTransferParameters</c> and <c>DomainsClient.RetrieveTransferParametersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveTransferParametersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.TransferDomain</c> and <c>DomainsClient.TransferDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TransferDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.TransferDomain</c> and
        /// <c>DomainsClient.TransferDomainAsync</c>.
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
        public lro::OperationsSettings TransferDomainOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.ListRegistrations</c> and <c>DomainsClient.ListRegistrationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRegistrationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.GetRegistration</c> and <c>DomainsClient.GetRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRegistrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.UpdateRegistration</c> and <c>DomainsClient.UpdateRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRegistrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.UpdateRegistration</c> and
        /// <c>DomainsClient.UpdateRegistrationAsync</c>.
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
        public lro::OperationsSettings UpdateRegistrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.ConfigureManagementSettings</c> and <c>DomainsClient.ConfigureManagementSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConfigureManagementSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.ConfigureManagementSettings</c> and
        /// <c>DomainsClient.ConfigureManagementSettingsAsync</c>.
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
        public lro::OperationsSettings ConfigureManagementSettingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.ConfigureDnsSettings</c> and <c>DomainsClient.ConfigureDnsSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConfigureDnsSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.ConfigureDnsSettings</c> and
        /// <c>DomainsClient.ConfigureDnsSettingsAsync</c>.
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
        public lro::OperationsSettings ConfigureDnsSettingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.ConfigureContactSettings</c> and <c>DomainsClient.ConfigureContactSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConfigureContactSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.ConfigureContactSettings</c> and
        /// <c>DomainsClient.ConfigureContactSettingsAsync</c>.
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
        public lro::OperationsSettings ConfigureContactSettingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.ExportRegistration</c> and <c>DomainsClient.ExportRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportRegistrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.ExportRegistration</c> and
        /// <c>DomainsClient.ExportRegistrationAsync</c>.
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
        public lro::OperationsSettings ExportRegistrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.DeleteRegistration</c> and <c>DomainsClient.DeleteRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRegistrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainsClient.DeleteRegistration</c> and
        /// <c>DomainsClient.DeleteRegistrationAsync</c>.
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
        public lro::OperationsSettings DeleteRegistrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.RetrieveAuthorizationCode</c> and <c>DomainsClient.RetrieveAuthorizationCodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveAuthorizationCodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainsClient.ResetAuthorizationCode</c> and <c>DomainsClient.ResetAuthorizationCodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetAuthorizationCodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DomainsSettings"/> object.</returns>
        public DomainsSettings Clone() => new DomainsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DomainsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DomainsClientBuilder : gaxgrpc::ClientBuilderBase<DomainsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DomainsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DomainsClientBuilder() : base(DomainsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DomainsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DomainsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DomainsClient Build()
        {
            DomainsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DomainsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DomainsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DomainsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DomainsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DomainsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DomainsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DomainsClient.ChannelPool;
    }

    /// <summary>Domains client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Domains API enables management and configuration of domain names.
    /// </remarks>
    public abstract partial class DomainsClient
    {
        /// <summary>
        /// The default endpoint for the Domains service, which is a host of "domains.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "domains.googleapis.com:443";

        /// <summary>The default Domains scopes.</summary>
        /// <remarks>
        /// The default Domains scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Domains.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DomainsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="DomainsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DomainsClient"/>.</returns>
        public static stt::Task<DomainsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DomainsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DomainsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="DomainsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DomainsClient"/>.</returns>
        public static DomainsClient Create() => new DomainsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DomainsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DomainsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DomainsClient"/>.</returns>
        internal static DomainsClient Create(grpccore::CallInvoker callInvoker, DomainsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Domains.DomainsClient grpcClient = new Domains.DomainsClient(callInvoker);
            return new DomainsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Domains client</summary>
        public virtual Domains.DomainsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchDomainsResponse SearchDomains(SearchDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDomainsResponse> SearchDomainsAsync(SearchDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDomainsResponse> SearchDomainsAsync(SearchDomainsRequest request, st::CancellationToken cancellationToken) =>
            SearchDomainsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="query">
        /// Required. String used to search for available domain names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchDomainsResponse SearchDomains(string location, string query, gaxgrpc::CallSettings callSettings = null) =>
            SearchDomains(new SearchDomainsRequest
            {
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="query">
        /// Required. String used to search for available domain names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDomainsResponse> SearchDomainsAsync(string location, string query, gaxgrpc::CallSettings callSettings = null) =>
            SearchDomainsAsync(new SearchDomainsRequest
            {
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="query">
        /// Required. String used to search for available domain names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDomainsResponse> SearchDomainsAsync(string location, string query, st::CancellationToken cancellationToken) =>
            SearchDomainsAsync(location, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="query">
        /// Required. String used to search for available domain names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchDomainsResponse SearchDomains(gagr::LocationName location, string query, gaxgrpc::CallSettings callSettings = null) =>
            SearchDomains(new SearchDomainsRequest
            {
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="query">
        /// Required. String used to search for available domain names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDomainsResponse> SearchDomainsAsync(gagr::LocationName location, string query, gaxgrpc::CallSettings callSettings = null) =>
            SearchDomainsAsync(new SearchDomainsRequest
            {
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="query">
        /// Required. String used to search for available domain names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDomainsResponse> SearchDomainsAsync(gagr::LocationName location, string query, st::CancellationToken cancellationToken) =>
            SearchDomainsAsync(location, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveRegisterParametersResponse RetrieveRegisterParameters(RetrieveRegisterParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(RetrieveRegisterParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(RetrieveRegisterParametersRequest request, st::CancellationToken cancellationToken) =>
            RetrieveRegisterParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveRegisterParametersResponse RetrieveRegisterParameters(string location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveRegisterParameters(new RetrieveRegisterParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(string location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveRegisterParametersAsync(new RetrieveRegisterParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(string location, string domainName, st::CancellationToken cancellationToken) =>
            RetrieveRegisterParametersAsync(location, domainName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveRegisterParametersResponse RetrieveRegisterParameters(gagr::LocationName location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveRegisterParameters(new RetrieveRegisterParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(gagr::LocationName location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveRegisterParametersAsync(new RetrieveRegisterParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(gagr::LocationName location, string domainName, st::CancellationToken cancellationToken) =>
            RetrieveRegisterParametersAsync(location, domainName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> RegisterDomain(RegisterDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(RegisterDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(RegisterDomainRequest request, st::CancellationToken cancellationToken) =>
            RegisterDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RegisterDomain</c>.</summary>
        public virtual lro::OperationsClient RegisterDomainOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RegisterDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceRegisterDomain(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterDomainOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RegisterDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceRegisterDomainAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterDomainOperationsClient, callSettings);

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Yearly price to register or renew the domain.
        /// The value that should be put here can be obtained from
        /// RetrieveRegisterParameters or SearchDomains calls.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> RegisterDomain(string parent, Registration registration, gt::Money yearlyPrice, gaxgrpc::CallSettings callSettings = null) =>
            RegisterDomain(new RegisterDomainRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
            }, callSettings);

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Yearly price to register or renew the domain.
        /// The value that should be put here can be obtained from
        /// RetrieveRegisterParameters or SearchDomains calls.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(string parent, Registration registration, gt::Money yearlyPrice, gaxgrpc::CallSettings callSettings = null) =>
            RegisterDomainAsync(new RegisterDomainRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
            }, callSettings);

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Yearly price to register or renew the domain.
        /// The value that should be put here can be obtained from
        /// RetrieveRegisterParameters or SearchDomains calls.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(string parent, Registration registration, gt::Money yearlyPrice, st::CancellationToken cancellationToken) =>
            RegisterDomainAsync(parent, registration, yearlyPrice, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Yearly price to register or renew the domain.
        /// The value that should be put here can be obtained from
        /// RetrieveRegisterParameters or SearchDomains calls.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> RegisterDomain(gagr::LocationName parent, Registration registration, gt::Money yearlyPrice, gaxgrpc::CallSettings callSettings = null) =>
            RegisterDomain(new RegisterDomainRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
            }, callSettings);

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Yearly price to register or renew the domain.
        /// The value that should be put here can be obtained from
        /// RetrieveRegisterParameters or SearchDomains calls.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(gagr::LocationName parent, Registration registration, gt::Money yearlyPrice, gaxgrpc::CallSettings callSettings = null) =>
            RegisterDomainAsync(new RegisterDomainRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
            }, callSettings);

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Yearly price to register or renew the domain.
        /// The value that should be put here can be obtained from
        /// RetrieveRegisterParameters or SearchDomains calls.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(gagr::LocationName parent, Registration registration, gt::Money yearlyPrice, st::CancellationToken cancellationToken) =>
            RegisterDomainAsync(parent, registration, yearlyPrice, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveTransferParametersResponse RetrieveTransferParameters(RetrieveTransferParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(RetrieveTransferParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(RetrieveTransferParametersRequest request, st::CancellationToken cancellationToken) =>
            RetrieveTransferParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveTransferParametersResponse RetrieveTransferParameters(string location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveTransferParameters(new RetrieveTransferParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(string location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveTransferParametersAsync(new RetrieveTransferParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(string location, string domainName, st::CancellationToken cancellationToken) =>
            RetrieveTransferParametersAsync(location, domainName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveTransferParametersResponse RetrieveTransferParameters(gagr::LocationName location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveTransferParameters(new RetrieveTransferParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(gagr::LocationName location, string domainName, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveTransferParametersAsync(new RetrieveTransferParametersRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNullOrEmpty(domainName, nameof(domainName)),
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="location">
        /// Required. The location. Must be in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="domainName">
        /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(gagr::LocationName location, string domainName, st::CancellationToken cancellationToken) =>
            RetrieveTransferParametersAsync(location, domainName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> TransferDomain(TransferDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(TransferDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(TransferDomainRequest request, st::CancellationToken cancellationToken) =>
            TransferDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TransferDomain</c>.</summary>
        public virtual lro::OperationsClient TransferDomainOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TransferDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceTransferDomain(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TransferDomainOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TransferDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceTransferDomainAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TransferDomainOperationsClient, callSettings);

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// 
        /// You can leave `registration.dns_settings` unset to import the
        /// domain's current DNS configuration from its current registrar. Use this
        /// option only if you are sure that the domain's current DNS service
        /// does not cease upon transfer, as is often the case for DNS services
        /// provided for free by the registrar.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year.
        /// Call `RetrieveTransferParameters` to obtain the price, which you must
        /// acknowledge.
        /// </param>
        /// <param name="authorizationCode">
        /// The domain's transfer authorization code. You can obtain this from the
        /// domain's current registrar.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> TransferDomain(string parent, Registration registration, gt::Money yearlyPrice, AuthorizationCode authorizationCode, gaxgrpc::CallSettings callSettings = null) =>
            TransferDomain(new TransferDomainRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
                AuthorizationCode = authorizationCode,
            }, callSettings);

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// 
        /// You can leave `registration.dns_settings` unset to import the
        /// domain's current DNS configuration from its current registrar. Use this
        /// option only if you are sure that the domain's current DNS service
        /// does not cease upon transfer, as is often the case for DNS services
        /// provided for free by the registrar.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year.
        /// Call `RetrieveTransferParameters` to obtain the price, which you must
        /// acknowledge.
        /// </param>
        /// <param name="authorizationCode">
        /// The domain's transfer authorization code. You can obtain this from the
        /// domain's current registrar.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(string parent, Registration registration, gt::Money yearlyPrice, AuthorizationCode authorizationCode, gaxgrpc::CallSettings callSettings = null) =>
            TransferDomainAsync(new TransferDomainRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
                AuthorizationCode = authorizationCode,
            }, callSettings);

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// 
        /// You can leave `registration.dns_settings` unset to import the
        /// domain's current DNS configuration from its current registrar. Use this
        /// option only if you are sure that the domain's current DNS service
        /// does not cease upon transfer, as is often the case for DNS services
        /// provided for free by the registrar.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year.
        /// Call `RetrieveTransferParameters` to obtain the price, which you must
        /// acknowledge.
        /// </param>
        /// <param name="authorizationCode">
        /// The domain's transfer authorization code. You can obtain this from the
        /// domain's current registrar.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(string parent, Registration registration, gt::Money yearlyPrice, AuthorizationCode authorizationCode, st::CancellationToken cancellationToken) =>
            TransferDomainAsync(parent, registration, yearlyPrice, authorizationCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// 
        /// You can leave `registration.dns_settings` unset to import the
        /// domain's current DNS configuration from its current registrar. Use this
        /// option only if you are sure that the domain's current DNS service
        /// does not cease upon transfer, as is often the case for DNS services
        /// provided for free by the registrar.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year.
        /// Call `RetrieveTransferParameters` to obtain the price, which you must
        /// acknowledge.
        /// </param>
        /// <param name="authorizationCode">
        /// The domain's transfer authorization code. You can obtain this from the
        /// domain's current registrar.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> TransferDomain(gagr::LocationName parent, Registration registration, gt::Money yearlyPrice, AuthorizationCode authorizationCode, gaxgrpc::CallSettings callSettings = null) =>
            TransferDomain(new TransferDomainRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
                AuthorizationCode = authorizationCode,
            }, callSettings);

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// 
        /// You can leave `registration.dns_settings` unset to import the
        /// domain's current DNS configuration from its current registrar. Use this
        /// option only if you are sure that the domain's current DNS service
        /// does not cease upon transfer, as is often the case for DNS services
        /// provided for free by the registrar.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year.
        /// Call `RetrieveTransferParameters` to obtain the price, which you must
        /// acknowledge.
        /// </param>
        /// <param name="authorizationCode">
        /// The domain's transfer authorization code. You can obtain this from the
        /// domain's current registrar.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(gagr::LocationName parent, Registration registration, gt::Money yearlyPrice, AuthorizationCode authorizationCode, gaxgrpc::CallSettings callSettings = null) =>
            TransferDomainAsync(new TransferDomainRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Registration = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                YearlyPrice = gax::GaxPreconditions.CheckNotNull(yearlyPrice, nameof(yearlyPrice)),
                AuthorizationCode = authorizationCode,
            }, callSettings);

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Registration`. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="registration">
        /// Required. The complete `Registration` resource to be created.
        /// 
        /// You can leave `registration.dns_settings` unset to import the
        /// domain's current DNS configuration from its current registrar. Use this
        /// option only if you are sure that the domain's current DNS service
        /// does not cease upon transfer, as is often the case for DNS services
        /// provided for free by the registrar.
        /// </param>
        /// <param name="yearlyPrice">
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year.
        /// Call `RetrieveTransferParameters` to obtain the price, which you must
        /// acknowledge.
        /// </param>
        /// <param name="authorizationCode">
        /// The domain's transfer authorization code. You can obtain this from the
        /// domain's current registrar.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(gagr::LocationName parent, Registration registration, gt::Money yearlyPrice, AuthorizationCode authorizationCode, st::CancellationToken cancellationToken) =>
            TransferDomainAsync(parent, registration, yearlyPrice, authorizationCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Registration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegistrationsResponse, Registration> ListRegistrations(ListRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Registration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegistrationsResponse, Registration> ListRegistrationsAsync(ListRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which to list `Registration`s, specified in
        /// the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Registration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegistrationsResponse, Registration> ListRegistrations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegistrationsRequest request = new ListRegistrationsRequest
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
            return ListRegistrations(request, callSettings);
        }

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which to list `Registration`s, specified in
        /// the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Registration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegistrationsResponse, Registration> ListRegistrationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegistrationsRequest request = new ListRegistrationsRequest
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
            return ListRegistrationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which to list `Registration`s, specified in
        /// the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Registration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegistrationsResponse, Registration> ListRegistrations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegistrationsRequest request = new ListRegistrationsRequest
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
            return ListRegistrations(request, callSettings);
        }

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which to list `Registration`s, specified in
        /// the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Registration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegistrationsResponse, Registration> ListRegistrationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegistrationsRequest request = new ListRegistrationsRequest
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
            return ListRegistrationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Registration GetRegistration(GetRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Registration> GetRegistrationAsync(GetRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Registration> GetRegistrationAsync(GetRegistrationRequest request, st::CancellationToken cancellationToken) =>
            GetRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to get, in the format
        /// `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Registration GetRegistration(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegistration(new GetRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to get, in the format
        /// `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Registration> GetRegistrationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegistrationAsync(new GetRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to get, in the format
        /// `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Registration> GetRegistrationAsync(string name, st::CancellationToken cancellationToken) =>
            GetRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to get, in the format
        /// `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Registration GetRegistration(RegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegistration(new GetRegistrationRequest
            {
                RegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to get, in the format
        /// `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Registration> GetRegistrationAsync(RegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegistrationAsync(new GetRegistrationRequest
            {
                RegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to get, in the format
        /// `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Registration> GetRegistrationAsync(RegistrationName name, st::CancellationToken cancellationToken) =>
            GetRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> UpdateRegistration(UpdateRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> UpdateRegistrationAsync(UpdateRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> UpdateRegistrationAsync(UpdateRegistrationRequest request, st::CancellationToken cancellationToken) =>
            UpdateRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRegistration</c>.</summary>
        public virtual lro::OperationsClient UpdateRegistrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRegistration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceUpdateRegistration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRegistrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRegistration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceUpdateRegistrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRegistrationOperationsClient, callSettings);

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="registration">
        /// Fields of the `Registration` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the labels are being updated, the `update_mask` is
        /// `"labels"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> UpdateRegistration(Registration registration, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRegistration(new UpdateRegistrationRequest
            {
                Registration = registration,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="registration">
        /// Fields of the `Registration` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the labels are being updated, the `update_mask` is
        /// `"labels"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> UpdateRegistrationAsync(Registration registration, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRegistrationAsync(new UpdateRegistrationRequest
            {
                Registration = registration,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="registration">
        /// Fields of the `Registration` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the labels are being updated, the `update_mask` is
        /// `"labels"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> UpdateRegistrationAsync(Registration registration, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRegistrationAsync(registration, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureManagementSettings(ConfigureManagementSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(ConfigureManagementSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(ConfigureManagementSettingsRequest request, st::CancellationToken cancellationToken) =>
            ConfigureManagementSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ConfigureManagementSettings</c>.</summary>
        public virtual lro::OperationsClient ConfigureManagementSettingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConfigureManagementSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceConfigureManagementSettings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConfigureManagementSettingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConfigureManagementSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceConfigureManagementSettingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConfigureManagementSettingsOperationsClient, callSettings);

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose management settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="managementSettings">
        /// Fields of the `ManagementSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the transfer lock is being updated, the `update_mask`
        /// is `"transfer_lock_state"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureManagementSettings(string registration, ManagementSettings managementSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureManagementSettings(new ConfigureManagementSettingsRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
                ManagementSettings = managementSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose management settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="managementSettings">
        /// Fields of the `ManagementSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the transfer lock is being updated, the `update_mask`
        /// is `"transfer_lock_state"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(string registration, ManagementSettings managementSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureManagementSettingsAsync(new ConfigureManagementSettingsRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
                ManagementSettings = managementSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose management settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="managementSettings">
        /// Fields of the `ManagementSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the transfer lock is being updated, the `update_mask`
        /// is `"transfer_lock_state"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(string registration, ManagementSettings managementSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            ConfigureManagementSettingsAsync(registration, managementSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose management settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="managementSettings">
        /// Fields of the `ManagementSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the transfer lock is being updated, the `update_mask`
        /// is `"transfer_lock_state"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureManagementSettings(RegistrationName registration, ManagementSettings managementSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureManagementSettings(new ConfigureManagementSettingsRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                ManagementSettings = managementSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose management settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="managementSettings">
        /// Fields of the `ManagementSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the transfer lock is being updated, the `update_mask`
        /// is `"transfer_lock_state"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(RegistrationName registration, ManagementSettings managementSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureManagementSettingsAsync(new ConfigureManagementSettingsRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                ManagementSettings = managementSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose management settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="managementSettings">
        /// Fields of the `ManagementSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the transfer lock is being updated, the `update_mask`
        /// is `"transfer_lock_state"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(RegistrationName registration, ManagementSettings managementSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            ConfigureManagementSettingsAsync(registration, managementSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureDnsSettings(ConfigureDnsSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(ConfigureDnsSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(ConfigureDnsSettingsRequest request, st::CancellationToken cancellationToken) =>
            ConfigureDnsSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ConfigureDnsSettings</c>.</summary>
        public virtual lro::OperationsClient ConfigureDnsSettingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ConfigureDnsSettings</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceConfigureDnsSettings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConfigureDnsSettingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConfigureDnsSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceConfigureDnsSettingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConfigureDnsSettingsOperationsClient, callSettings);

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose DNS settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="dnsSettings">
        /// Fields of the `DnsSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the name servers are being updated for an existing
        /// Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`.
        /// 
        /// When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing
        /// from a Google Domains DNS configuration to a Custom DNS configuration, the
        /// `update_mask` is `"custom_dns"`. //
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureDnsSettings(string registration, DnsSettings dnsSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureDnsSettings(new ConfigureDnsSettingsRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
                DnsSettings = dnsSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose DNS settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="dnsSettings">
        /// Fields of the `DnsSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the name servers are being updated for an existing
        /// Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`.
        /// 
        /// When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing
        /// from a Google Domains DNS configuration to a Custom DNS configuration, the
        /// `update_mask` is `"custom_dns"`. //
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(string registration, DnsSettings dnsSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureDnsSettingsAsync(new ConfigureDnsSettingsRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
                DnsSettings = dnsSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose DNS settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="dnsSettings">
        /// Fields of the `DnsSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the name servers are being updated for an existing
        /// Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`.
        /// 
        /// When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing
        /// from a Google Domains DNS configuration to a Custom DNS configuration, the
        /// `update_mask` is `"custom_dns"`. //
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(string registration, DnsSettings dnsSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            ConfigureDnsSettingsAsync(registration, dnsSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose DNS settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="dnsSettings">
        /// Fields of the `DnsSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the name servers are being updated for an existing
        /// Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`.
        /// 
        /// When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing
        /// from a Google Domains DNS configuration to a Custom DNS configuration, the
        /// `update_mask` is `"custom_dns"`. //
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureDnsSettings(RegistrationName registration, DnsSettings dnsSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureDnsSettings(new ConfigureDnsSettingsRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                DnsSettings = dnsSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose DNS settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="dnsSettings">
        /// Fields of the `DnsSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the name servers are being updated for an existing
        /// Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`.
        /// 
        /// When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing
        /// from a Google Domains DNS configuration to a Custom DNS configuration, the
        /// `update_mask` is `"custom_dns"`. //
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(RegistrationName registration, DnsSettings dnsSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureDnsSettingsAsync(new ConfigureDnsSettingsRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                DnsSettings = dnsSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose DNS settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="dnsSettings">
        /// Fields of the `DnsSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the name servers are being updated for an existing
        /// Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`.
        /// 
        /// When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing
        /// from a Google Domains DNS configuration to a Custom DNS configuration, the
        /// `update_mask` is `"custom_dns"`. //
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(RegistrationName registration, DnsSettings dnsSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            ConfigureDnsSettingsAsync(registration, dnsSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureContactSettings(ConfigureContactSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(ConfigureContactSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(ConfigureContactSettingsRequest request, st::CancellationToken cancellationToken) =>
            ConfigureContactSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ConfigureContactSettings</c>.</summary>
        public virtual lro::OperationsClient ConfigureContactSettingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConfigureContactSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceConfigureContactSettings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConfigureContactSettingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ConfigureContactSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceConfigureContactSettingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ConfigureContactSettingsOperationsClient, callSettings);

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose contact settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="contactSettings">
        /// Fields of the `ContactSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the registrant contact is being updated, the
        /// `update_mask` is `"registrant_contact"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureContactSettings(string registration, ContactSettings contactSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureContactSettings(new ConfigureContactSettingsRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
                ContactSettings = contactSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose contact settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="contactSettings">
        /// Fields of the `ContactSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the registrant contact is being updated, the
        /// `update_mask` is `"registrant_contact"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(string registration, ContactSettings contactSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureContactSettingsAsync(new ConfigureContactSettingsRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
                ContactSettings = contactSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose contact settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="contactSettings">
        /// Fields of the `ContactSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the registrant contact is being updated, the
        /// `update_mask` is `"registrant_contact"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(string registration, ContactSettings contactSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            ConfigureContactSettingsAsync(registration, contactSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose contact settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="contactSettings">
        /// Fields of the `ContactSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the registrant contact is being updated, the
        /// `update_mask` is `"registrant_contact"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ConfigureContactSettings(RegistrationName registration, ContactSettings contactSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureContactSettings(new ConfigureContactSettingsRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                ContactSettings = contactSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose contact settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="contactSettings">
        /// Fields of the `ContactSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the registrant contact is being updated, the
        /// `update_mask` is `"registrant_contact"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(RegistrationName registration, ContactSettings contactSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureContactSettingsAsync(new ConfigureContactSettingsRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
                ContactSettings = contactSettings,
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose contact settings are being updated,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="contactSettings">
        /// Fields of the `ContactSettings` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask describing which fields to update as a comma-separated list.
        /// For example, if only the registrant contact is being updated, the
        /// `update_mask` is `"registrant_contact"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(RegistrationName registration, ContactSettings contactSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            ConfigureContactSettingsAsync(registration, contactSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ExportRegistration(ExportRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(ExportRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(ExportRegistrationRequest request, st::CancellationToken cancellationToken) =>
            ExportRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportRegistration</c>.</summary>
        public virtual lro::OperationsClient ExportRegistrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportRegistration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> PollOnceExportRegistration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportRegistrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportRegistration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> PollOnceExportRegistrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Registration, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportRegistrationOperationsClient, callSettings);

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to export,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ExportRegistration(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegistration(new ExportRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to export,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegistrationAsync(new ExportRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to export,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(string name, st::CancellationToken cancellationToken) =>
            ExportRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to export,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Registration, OperationMetadata> ExportRegistration(RegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegistration(new ExportRegistrationRequest
            {
                RegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to export,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(RegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegistrationAsync(new ExportRegistrationRequest
            {
                RegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to export,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(RegistrationName name, st::CancellationToken cancellationToken) =>
            ExportRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRegistration(DeleteRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(DeleteRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(DeleteRegistrationRequest request, st::CancellationToken cancellationToken) =>
            DeleteRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRegistration</c>.</summary>
        public virtual lro::OperationsClient DeleteRegistrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRegistration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRegistration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRegistrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRegistration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRegistrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRegistrationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to delete,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRegistration(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegistration(new DeleteRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to delete,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegistrationAsync(new DeleteRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to delete,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to delete,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRegistration(RegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegistration(new DeleteRegistrationRequest
            {
                RegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to delete,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(RegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegistrationAsync(new DeleteRegistrationRequest
            {
                RegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Registration` to delete,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(RegistrationName name, st::CancellationToken cancellationToken) =>
            DeleteRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationCode RetrieveAuthorizationCode(RetrieveAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(RetrieveAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(RetrieveAuthorizationCodeRequest request, st::CancellationToken cancellationToken) =>
            RetrieveAuthorizationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being retrieved,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationCode RetrieveAuthorizationCode(string registration, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveAuthorizationCode(new RetrieveAuthorizationCodeRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being retrieved,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(string registration, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveAuthorizationCodeAsync(new RetrieveAuthorizationCodeRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being retrieved,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(string registration, st::CancellationToken cancellationToken) =>
            RetrieveAuthorizationCodeAsync(registration, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being retrieved,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationCode RetrieveAuthorizationCode(RegistrationName registration, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveAuthorizationCode(new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being retrieved,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(RegistrationName registration, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveAuthorizationCodeAsync(new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being retrieved,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(RegistrationName registration, st::CancellationToken cancellationToken) =>
            RetrieveAuthorizationCodeAsync(registration, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationCode ResetAuthorizationCode(ResetAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(ResetAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(ResetAuthorizationCodeRequest request, st::CancellationToken cancellationToken) =>
            ResetAuthorizationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being reset,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationCode ResetAuthorizationCode(string registration, gaxgrpc::CallSettings callSettings = null) =>
            ResetAuthorizationCode(new ResetAuthorizationCodeRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being reset,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(string registration, gaxgrpc::CallSettings callSettings = null) =>
            ResetAuthorizationCodeAsync(new ResetAuthorizationCodeRequest
            {
                Registration = gax::GaxPreconditions.CheckNotNullOrEmpty(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being reset,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(string registration, st::CancellationToken cancellationToken) =>
            ResetAuthorizationCodeAsync(registration, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being reset,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizationCode ResetAuthorizationCode(RegistrationName registration, gaxgrpc::CallSettings callSettings = null) =>
            ResetAuthorizationCode(new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being reset,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(RegistrationName registration, gaxgrpc::CallSettings callSettings = null) =>
            ResetAuthorizationCodeAsync(new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = gax::GaxPreconditions.CheckNotNull(registration, nameof(registration)),
            }, callSettings);

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="registration">
        /// Required. The name of the `Registration` whose authorization code is being reset,
        /// in the format `projects/*/locations/*/registrations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(RegistrationName registration, st::CancellationToken cancellationToken) =>
            ResetAuthorizationCodeAsync(registration, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Domains client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Domains API enables management and configuration of domain names.
    /// </remarks>
    public sealed partial class DomainsClientImpl : DomainsClient
    {
        private readonly gaxgrpc::ApiCall<SearchDomainsRequest, SearchDomainsResponse> _callSearchDomains;

        private readonly gaxgrpc::ApiCall<RetrieveRegisterParametersRequest, RetrieveRegisterParametersResponse> _callRetrieveRegisterParameters;

        private readonly gaxgrpc::ApiCall<RegisterDomainRequest, lro::Operation> _callRegisterDomain;

        private readonly gaxgrpc::ApiCall<RetrieveTransferParametersRequest, RetrieveTransferParametersResponse> _callRetrieveTransferParameters;

        private readonly gaxgrpc::ApiCall<TransferDomainRequest, lro::Operation> _callTransferDomain;

        private readonly gaxgrpc::ApiCall<ListRegistrationsRequest, ListRegistrationsResponse> _callListRegistrations;

        private readonly gaxgrpc::ApiCall<GetRegistrationRequest, Registration> _callGetRegistration;

        private readonly gaxgrpc::ApiCall<UpdateRegistrationRequest, lro::Operation> _callUpdateRegistration;

        private readonly gaxgrpc::ApiCall<ConfigureManagementSettingsRequest, lro::Operation> _callConfigureManagementSettings;

        private readonly gaxgrpc::ApiCall<ConfigureDnsSettingsRequest, lro::Operation> _callConfigureDnsSettings;

        private readonly gaxgrpc::ApiCall<ConfigureContactSettingsRequest, lro::Operation> _callConfigureContactSettings;

        private readonly gaxgrpc::ApiCall<ExportRegistrationRequest, lro::Operation> _callExportRegistration;

        private readonly gaxgrpc::ApiCall<DeleteRegistrationRequest, lro::Operation> _callDeleteRegistration;

        private readonly gaxgrpc::ApiCall<RetrieveAuthorizationCodeRequest, AuthorizationCode> _callRetrieveAuthorizationCode;

        private readonly gaxgrpc::ApiCall<ResetAuthorizationCodeRequest, AuthorizationCode> _callResetAuthorizationCode;

        /// <summary>
        /// Constructs a client wrapper for the Domains service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DomainsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DomainsClientImpl(Domains.DomainsClient grpcClient, DomainsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DomainsSettings effectiveSettings = settings ?? DomainsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RegisterDomainOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RegisterDomainOperationsSettings, logger);
            TransferDomainOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TransferDomainOperationsSettings, logger);
            UpdateRegistrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRegistrationOperationsSettings, logger);
            ConfigureManagementSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ConfigureManagementSettingsOperationsSettings, logger);
            ConfigureDnsSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ConfigureDnsSettingsOperationsSettings, logger);
            ConfigureContactSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ConfigureContactSettingsOperationsSettings, logger);
            ExportRegistrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportRegistrationOperationsSettings, logger);
            DeleteRegistrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRegistrationOperationsSettings, logger);
            _callSearchDomains = clientHelper.BuildApiCall<SearchDomainsRequest, SearchDomainsResponse>("SearchDomains", grpcClient.SearchDomainsAsync, grpcClient.SearchDomains, effectiveSettings.SearchDomainsSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callSearchDomains);
            Modify_SearchDomainsApiCall(ref _callSearchDomains);
            _callRetrieveRegisterParameters = clientHelper.BuildApiCall<RetrieveRegisterParametersRequest, RetrieveRegisterParametersResponse>("RetrieveRegisterParameters", grpcClient.RetrieveRegisterParametersAsync, grpcClient.RetrieveRegisterParameters, effectiveSettings.RetrieveRegisterParametersSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callRetrieveRegisterParameters);
            Modify_RetrieveRegisterParametersApiCall(ref _callRetrieveRegisterParameters);
            _callRegisterDomain = clientHelper.BuildApiCall<RegisterDomainRequest, lro::Operation>("RegisterDomain", grpcClient.RegisterDomainAsync, grpcClient.RegisterDomain, effectiveSettings.RegisterDomainSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRegisterDomain);
            Modify_RegisterDomainApiCall(ref _callRegisterDomain);
            _callRetrieveTransferParameters = clientHelper.BuildApiCall<RetrieveTransferParametersRequest, RetrieveTransferParametersResponse>("RetrieveTransferParameters", grpcClient.RetrieveTransferParametersAsync, grpcClient.RetrieveTransferParameters, effectiveSettings.RetrieveTransferParametersSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callRetrieveTransferParameters);
            Modify_RetrieveTransferParametersApiCall(ref _callRetrieveTransferParameters);
            _callTransferDomain = clientHelper.BuildApiCall<TransferDomainRequest, lro::Operation>("TransferDomain", grpcClient.TransferDomainAsync, grpcClient.TransferDomain, effectiveSettings.TransferDomainSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTransferDomain);
            Modify_TransferDomainApiCall(ref _callTransferDomain);
            _callListRegistrations = clientHelper.BuildApiCall<ListRegistrationsRequest, ListRegistrationsResponse>("ListRegistrations", grpcClient.ListRegistrationsAsync, grpcClient.ListRegistrations, effectiveSettings.ListRegistrationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRegistrations);
            Modify_ListRegistrationsApiCall(ref _callListRegistrations);
            _callGetRegistration = clientHelper.BuildApiCall<GetRegistrationRequest, Registration>("GetRegistration", grpcClient.GetRegistrationAsync, grpcClient.GetRegistration, effectiveSettings.GetRegistrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRegistration);
            Modify_GetRegistrationApiCall(ref _callGetRegistration);
            _callUpdateRegistration = clientHelper.BuildApiCall<UpdateRegistrationRequest, lro::Operation>("UpdateRegistration", grpcClient.UpdateRegistrationAsync, grpcClient.UpdateRegistration, effectiveSettings.UpdateRegistrationSettings).WithGoogleRequestParam("registration.name", request => request.Registration?.Name);
            Modify_ApiCall(ref _callUpdateRegistration);
            Modify_UpdateRegistrationApiCall(ref _callUpdateRegistration);
            _callConfigureManagementSettings = clientHelper.BuildApiCall<ConfigureManagementSettingsRequest, lro::Operation>("ConfigureManagementSettings", grpcClient.ConfigureManagementSettingsAsync, grpcClient.ConfigureManagementSettings, effectiveSettings.ConfigureManagementSettingsSettings).WithGoogleRequestParam("registration", request => request.Registration);
            Modify_ApiCall(ref _callConfigureManagementSettings);
            Modify_ConfigureManagementSettingsApiCall(ref _callConfigureManagementSettings);
            _callConfigureDnsSettings = clientHelper.BuildApiCall<ConfigureDnsSettingsRequest, lro::Operation>("ConfigureDnsSettings", grpcClient.ConfigureDnsSettingsAsync, grpcClient.ConfigureDnsSettings, effectiveSettings.ConfigureDnsSettingsSettings).WithGoogleRequestParam("registration", request => request.Registration);
            Modify_ApiCall(ref _callConfigureDnsSettings);
            Modify_ConfigureDnsSettingsApiCall(ref _callConfigureDnsSettings);
            _callConfigureContactSettings = clientHelper.BuildApiCall<ConfigureContactSettingsRequest, lro::Operation>("ConfigureContactSettings", grpcClient.ConfigureContactSettingsAsync, grpcClient.ConfigureContactSettings, effectiveSettings.ConfigureContactSettingsSettings).WithGoogleRequestParam("registration", request => request.Registration);
            Modify_ApiCall(ref _callConfigureContactSettings);
            Modify_ConfigureContactSettingsApiCall(ref _callConfigureContactSettings);
            _callExportRegistration = clientHelper.BuildApiCall<ExportRegistrationRequest, lro::Operation>("ExportRegistration", grpcClient.ExportRegistrationAsync, grpcClient.ExportRegistration, effectiveSettings.ExportRegistrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportRegistration);
            Modify_ExportRegistrationApiCall(ref _callExportRegistration);
            _callDeleteRegistration = clientHelper.BuildApiCall<DeleteRegistrationRequest, lro::Operation>("DeleteRegistration", grpcClient.DeleteRegistrationAsync, grpcClient.DeleteRegistration, effectiveSettings.DeleteRegistrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRegistration);
            Modify_DeleteRegistrationApiCall(ref _callDeleteRegistration);
            _callRetrieveAuthorizationCode = clientHelper.BuildApiCall<RetrieveAuthorizationCodeRequest, AuthorizationCode>("RetrieveAuthorizationCode", grpcClient.RetrieveAuthorizationCodeAsync, grpcClient.RetrieveAuthorizationCode, effectiveSettings.RetrieveAuthorizationCodeSettings).WithGoogleRequestParam("registration", request => request.Registration);
            Modify_ApiCall(ref _callRetrieveAuthorizationCode);
            Modify_RetrieveAuthorizationCodeApiCall(ref _callRetrieveAuthorizationCode);
            _callResetAuthorizationCode = clientHelper.BuildApiCall<ResetAuthorizationCodeRequest, AuthorizationCode>("ResetAuthorizationCode", grpcClient.ResetAuthorizationCodeAsync, grpcClient.ResetAuthorizationCode, effectiveSettings.ResetAuthorizationCodeSettings).WithGoogleRequestParam("registration", request => request.Registration);
            Modify_ApiCall(ref _callResetAuthorizationCode);
            Modify_ResetAuthorizationCodeApiCall(ref _callResetAuthorizationCode);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchDomainsApiCall(ref gaxgrpc::ApiCall<SearchDomainsRequest, SearchDomainsResponse> call);

        partial void Modify_RetrieveRegisterParametersApiCall(ref gaxgrpc::ApiCall<RetrieveRegisterParametersRequest, RetrieveRegisterParametersResponse> call);

        partial void Modify_RegisterDomainApiCall(ref gaxgrpc::ApiCall<RegisterDomainRequest, lro::Operation> call);

        partial void Modify_RetrieveTransferParametersApiCall(ref gaxgrpc::ApiCall<RetrieveTransferParametersRequest, RetrieveTransferParametersResponse> call);

        partial void Modify_TransferDomainApiCall(ref gaxgrpc::ApiCall<TransferDomainRequest, lro::Operation> call);

        partial void Modify_ListRegistrationsApiCall(ref gaxgrpc::ApiCall<ListRegistrationsRequest, ListRegistrationsResponse> call);

        partial void Modify_GetRegistrationApiCall(ref gaxgrpc::ApiCall<GetRegistrationRequest, Registration> call);

        partial void Modify_UpdateRegistrationApiCall(ref gaxgrpc::ApiCall<UpdateRegistrationRequest, lro::Operation> call);

        partial void Modify_ConfigureManagementSettingsApiCall(ref gaxgrpc::ApiCall<ConfigureManagementSettingsRequest, lro::Operation> call);

        partial void Modify_ConfigureDnsSettingsApiCall(ref gaxgrpc::ApiCall<ConfigureDnsSettingsRequest, lro::Operation> call);

        partial void Modify_ConfigureContactSettingsApiCall(ref gaxgrpc::ApiCall<ConfigureContactSettingsRequest, lro::Operation> call);

        partial void Modify_ExportRegistrationApiCall(ref gaxgrpc::ApiCall<ExportRegistrationRequest, lro::Operation> call);

        partial void Modify_DeleteRegistrationApiCall(ref gaxgrpc::ApiCall<DeleteRegistrationRequest, lro::Operation> call);

        partial void Modify_RetrieveAuthorizationCodeApiCall(ref gaxgrpc::ApiCall<RetrieveAuthorizationCodeRequest, AuthorizationCode> call);

        partial void Modify_ResetAuthorizationCodeApiCall(ref gaxgrpc::ApiCall<ResetAuthorizationCodeRequest, AuthorizationCode> call);

        partial void OnConstruction(Domains.DomainsClient grpcClient, DomainsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Domains client</summary>
        public override Domains.DomainsClient GrpcClient { get; }

        partial void Modify_SearchDomainsRequest(ref SearchDomainsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveRegisterParametersRequest(ref RetrieveRegisterParametersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterDomainRequest(ref RegisterDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveTransferParametersRequest(ref RetrieveTransferParametersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TransferDomainRequest(ref TransferDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegistrationsRequest(ref ListRegistrationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegistrationRequest(ref GetRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRegistrationRequest(ref UpdateRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ConfigureManagementSettingsRequest(ref ConfigureManagementSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ConfigureDnsSettingsRequest(ref ConfigureDnsSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ConfigureContactSettingsRequest(ref ConfigureContactSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportRegistrationRequest(ref ExportRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegistrationRequest(ref DeleteRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveAuthorizationCodeRequest(ref RetrieveAuthorizationCodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetAuthorizationCodeRequest(ref ResetAuthorizationCodeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchDomainsResponse SearchDomains(SearchDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDomainsRequest(ref request, ref callSettings);
            return _callSearchDomains.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches for available domain names similar to the provided query.
        /// 
        /// Availability results from this method are approximate; call
        /// `RetrieveRegisterParameters` on a domain before registering to confirm
        /// availability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchDomainsResponse> SearchDomainsAsync(SearchDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDomainsRequest(ref request, ref callSettings);
            return _callSearchDomains.Async(request, callSettings);
        }

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveRegisterParametersResponse RetrieveRegisterParameters(RetrieveRegisterParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveRegisterParametersRequest(ref request, ref callSettings);
            return _callRetrieveRegisterParameters.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets parameters needed to register a new domain name, including price and
        /// up-to-date availability. Use the returned values to call `RegisterDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveRegisterParametersResponse> RetrieveRegisterParametersAsync(RetrieveRegisterParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveRegisterParametersRequest(ref request, ref callSettings);
            return _callRetrieveRegisterParameters.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RegisterDomain</c>.</summary>
        public override lro::OperationsClient RegisterDomainOperationsClient { get; }

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> RegisterDomain(RegisterDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callRegisterDomain.Sync(request, callSettings), RegisterDomainOperationsClient);
        }

        /// <summary>
        /// Registers a new domain name and creates a corresponding `Registration`
        /// resource.
        /// 
        /// Call `RetrieveRegisterParameters` first to check availability of the domain
        /// name and determine parameters like price that are needed to build a call to
        /// this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
        /// minutes, indicating that the domain was successfully registered. If the
        /// resource ends up in state `REGISTRATION_FAILED`, it indicates that the
        /// domain was not registered successfully, and you can safely delete the
        /// resource and retry registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> RegisterDomainAsync(RegisterDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callRegisterDomain.Async(request, callSettings).ConfigureAwait(false), RegisterDomainOperationsClient);
        }

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveTransferParametersResponse RetrieveTransferParameters(RetrieveTransferParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveTransferParametersRequest(ref request, ref callSettings);
            return _callRetrieveTransferParameters.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets parameters needed to transfer a domain name from another registrar to
        /// Cloud Domains. For domains managed by Google Domains, transferring to Cloud
        /// Domains is not supported.
        /// 
        /// 
        /// Use the returned values to call `TransferDomain`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveTransferParametersResponse> RetrieveTransferParametersAsync(RetrieveTransferParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveTransferParametersRequest(ref request, ref callSettings);
            return _callRetrieveTransferParameters.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TransferDomain</c>.</summary>
        public override lro::OperationsClient TransferDomainOperationsClient { get; }

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> TransferDomain(TransferDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callTransferDomain.Sync(request, callSettings), TransferDomainOperationsClient);
        }

        /// <summary>
        /// Transfers a domain name from another registrar to Cloud Domains.  For
        /// domains managed by Google Domains, transferring to Cloud Domains is not
        /// supported.
        /// 
        /// 
        /// Before calling this method, go to the domain's current registrar to unlock
        /// the domain for transfer and retrieve the domain's transfer authorization
        /// code. Then call `RetrieveTransferParameters` to confirm that the domain is
        /// unlocked and to get values needed to build a call to this method.
        /// 
        /// A successful call creates a `Registration` resource in state
        /// `TRANSFER_PENDING`. It can take several days to complete the transfer
        /// process. The registrant can often speed up this process by approving the
        /// transfer through the current registrar, either by clicking a link in an
        /// email from the registrar or by visiting the registrar's website.
        /// 
        /// A few minutes after transfer approval, the resource transitions to state
        /// `ACTIVE`, indicating that the transfer was successful. If the transfer is
        /// rejected or the request expires without being approved, the resource can
        /// end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete
        /// the resource and retry the transfer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> TransferDomainAsync(TransferDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callTransferDomain.Async(request, callSettings).ConfigureAwait(false), TransferDomainOperationsClient);
        }

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Registration"/> resources.</returns>
        public override gax::PagedEnumerable<ListRegistrationsResponse, Registration> ListRegistrations(ListRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegistrationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegistrationsRequest, ListRegistrationsResponse, Registration>(_callListRegistrations, request, callSettings);
        }

        /// <summary>
        /// Lists the `Registration` resources in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Registration"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRegistrationsResponse, Registration> ListRegistrationsAsync(ListRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegistrationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegistrationsRequest, ListRegistrationsResponse, Registration>(_callListRegistrations, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Registration GetRegistration(GetRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegistrationRequest(ref request, ref callSettings);
            return _callGetRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `Registration` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Registration> GetRegistrationAsync(GetRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegistrationRequest(ref request, ref callSettings);
            return _callGetRegistration.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateRegistration</c>.</summary>
        public override lro::OperationsClient UpdateRegistrationOperationsClient { get; }

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> UpdateRegistration(UpdateRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegistrationRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callUpdateRegistration.Sync(request, callSettings), UpdateRegistrationOperationsClient);
        }

        /// <summary>
        /// Updates select fields of a `Registration` resource, notably `labels`. To
        /// update other fields, use the appropriate custom update method:
        /// 
        /// * To update management settings, see `ConfigureManagementSettings`
        /// * To update DNS configuration, see `ConfigureDnsSettings`
        /// * To update contact information, see `ConfigureContactSettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> UpdateRegistrationAsync(UpdateRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegistrationRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callUpdateRegistration.Async(request, callSettings).ConfigureAwait(false), UpdateRegistrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ConfigureManagementSettings</c>.</summary>
        public override lro::OperationsClient ConfigureManagementSettingsOperationsClient { get; }

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> ConfigureManagementSettings(ConfigureManagementSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureManagementSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callConfigureManagementSettings.Sync(request, callSettings), ConfigureManagementSettingsOperationsClient);
        }

        /// <summary>
        /// Updates a `Registration`'s management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureManagementSettingsAsync(ConfigureManagementSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureManagementSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callConfigureManagementSettings.Async(request, callSettings).ConfigureAwait(false), ConfigureManagementSettingsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ConfigureDnsSettings</c>.</summary>
        public override lro::OperationsClient ConfigureDnsSettingsOperationsClient { get; }

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> ConfigureDnsSettings(ConfigureDnsSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureDnsSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callConfigureDnsSettings.Sync(request, callSettings), ConfigureDnsSettingsOperationsClient);
        }

        /// <summary>
        /// Updates a `Registration`'s DNS settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureDnsSettingsAsync(ConfigureDnsSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureDnsSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callConfigureDnsSettings.Async(request, callSettings).ConfigureAwait(false), ConfigureDnsSettingsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ConfigureContactSettings</c>.</summary>
        public override lro::OperationsClient ConfigureContactSettingsOperationsClient { get; }

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> ConfigureContactSettings(ConfigureContactSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureContactSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callConfigureContactSettings.Sync(request, callSettings), ConfigureContactSettingsOperationsClient);
        }

        /// <summary>
        /// Updates a `Registration`'s contact settings. Some changes require
        /// confirmation by the domain's registrant contact .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> ConfigureContactSettingsAsync(ConfigureContactSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureContactSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callConfigureContactSettings.Async(request, callSettings).ConfigureAwait(false), ConfigureContactSettingsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportRegistration</c>.</summary>
        public override lro::OperationsClient ExportRegistrationOperationsClient { get; }

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Registration, OperationMetadata> ExportRegistration(ExportRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportRegistrationRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(_callExportRegistration.Sync(request, callSettings), ExportRegistrationOperationsClient);
        }

        /// <summary>
        /// Exports a `Registration` resource, such that it is no longer managed by
        /// Cloud Domains.
        /// 
        /// When an active domain is successfully exported, you can continue to use the
        /// domain in [Google Domains](https://domains.google/) until it expires. The
        /// calling user becomes the domain's sole owner in Google Domains, and
        /// permissions for the domain are subsequently managed there. The domain does
        /// not renew automatically unless the new owner sets up billing in Google
        /// Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Registration, OperationMetadata>> ExportRegistrationAsync(ExportRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportRegistrationRequest(ref request, ref callSettings);
            return new lro::Operation<Registration, OperationMetadata>(await _callExportRegistration.Async(request, callSettings).ConfigureAwait(false), ExportRegistrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRegistration</c>.</summary>
        public override lro::OperationsClient DeleteRegistrationOperationsClient { get; }

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRegistration(DeleteRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegistrationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRegistration.Sync(request, callSettings), DeleteRegistrationOperationsClient);
        }

        /// <summary>
        /// Deletes a `Registration` resource.
        /// 
        /// This method works on any `Registration` resource using [Subscription or
        /// Commitment billing](/domains/pricing#billing-models), provided that the
        /// resource was created at least 1 day in the past.
        /// 
        /// For `Registration` resources using
        /// [Monthly billing](/domains/pricing#billing-models), this method works if:
        /// 
        /// * `state` is `EXPORTED` with `expire_time` in the past
        /// * `state` is `REGISTRATION_FAILED`
        /// * `state` is `TRANSFER_FAILED`
        /// 
        /// When an active registration is successfully deleted, you can continue to
        /// use the domain in [Google Domains](https://domains.google/) until it
        /// expires. The calling user becomes the domain's sole owner in Google
        /// Domains, and permissions for the domain are subsequently managed there. The
        /// domain does not renew automatically unless the new owner sets up billing in
        /// Google Domains.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRegistrationAsync(DeleteRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegistrationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRegistration.Async(request, callSettings).ConfigureAwait(false), DeleteRegistrationOperationsClient);
        }

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthorizationCode RetrieveAuthorizationCode(RetrieveAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveAuthorizationCodeRequest(ref request, ref callSettings);
            return _callRetrieveAuthorizationCode.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the authorization code of the `Registration` for the purpose of
        /// transferring the domain to another registrar.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthorizationCode> RetrieveAuthorizationCodeAsync(RetrieveAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveAuthorizationCodeRequest(ref request, ref callSettings);
            return _callRetrieveAuthorizationCode.Async(request, callSettings);
        }

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthorizationCode ResetAuthorizationCode(ResetAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetAuthorizationCodeRequest(ref request, ref callSettings);
            return _callResetAuthorizationCode.Sync(request, callSettings);
        }

        /// <summary>
        /// Resets the authorization code of the `Registration` to a new random string.
        /// 
        /// You can call this method only after 60 days have elapsed since the initial
        /// domain registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthorizationCode> ResetAuthorizationCodeAsync(ResetAuthorizationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetAuthorizationCodeRequest(ref request, ref callSettings);
            return _callResetAuthorizationCode.Async(request, callSettings);
        }
    }

    public partial class ListRegistrationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRegistrationsResponse : gaxgrpc::IPageResponse<Registration>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Registration> GetEnumerator() => Registrations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Domains
    {
        public partial class DomainsClient
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
