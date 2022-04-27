// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using gccv = Google.Cloud.Compute.V1;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gccv::AcceleratorTypesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAcceleratorTypesClient(this IServiceCollection services, sys::Action<gccv::AcceleratorTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::AcceleratorTypesClientBuilder builder = new gccv::AcceleratorTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::AddressesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAddressesClient(this IServiceCollection services, sys::Action<gccv::AddressesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::AddressesClientBuilder builder = new gccv::AddressesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::AutoscalersClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutoscalersClient(this IServiceCollection services, sys::Action<gccv::AutoscalersClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::AutoscalersClientBuilder builder = new gccv::AutoscalersClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::BackendBucketsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBackendBucketsClient(this IServiceCollection services, sys::Action<gccv::BackendBucketsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::BackendBucketsClientBuilder builder = new gccv::BackendBucketsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::BackendServicesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBackendServicesClient(this IServiceCollection services, sys::Action<gccv::BackendServicesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::BackendServicesClientBuilder builder = new gccv::BackendServicesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::DiskTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDiskTypesClient(this IServiceCollection services, sys::Action<gccv::DiskTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::DiskTypesClientBuilder builder = new gccv::DiskTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::DisksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDisksClient(this IServiceCollection services, sys::Action<gccv::DisksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::DisksClientBuilder builder = new gccv::DisksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::ExternalVpnGatewaysClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddExternalVpnGatewaysClient(this IServiceCollection services, sys::Action<gccv::ExternalVpnGatewaysClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ExternalVpnGatewaysClientBuilder builder = new gccv::ExternalVpnGatewaysClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::FirewallPoliciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFirewallPoliciesClient(this IServiceCollection services, sys::Action<gccv::FirewallPoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::FirewallPoliciesClientBuilder builder = new gccv::FirewallPoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::FirewallsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFirewallsClient(this IServiceCollection services, sys::Action<gccv::FirewallsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::FirewallsClientBuilder builder = new gccv::FirewallsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::ForwardingRulesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddForwardingRulesClient(this IServiceCollection services, sys::Action<gccv::ForwardingRulesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ForwardingRulesClientBuilder builder = new gccv::ForwardingRulesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::GlobalAddressesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGlobalAddressesClient(this IServiceCollection services, sys::Action<gccv::GlobalAddressesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::GlobalAddressesClientBuilder builder = new gccv::GlobalAddressesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::GlobalForwardingRulesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGlobalForwardingRulesClient(this IServiceCollection services, sys::Action<gccv::GlobalForwardingRulesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::GlobalForwardingRulesClientBuilder builder = new gccv::GlobalForwardingRulesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::GlobalNetworkEndpointGroupsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGlobalNetworkEndpointGroupsClient(this IServiceCollection services, sys::Action<gccv::GlobalNetworkEndpointGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::GlobalNetworkEndpointGroupsClientBuilder builder = new gccv::GlobalNetworkEndpointGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::GlobalOperationsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGlobalOperationsClient(this IServiceCollection services, sys::Action<gccv::GlobalOperationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::GlobalOperationsClientBuilder builder = new gccv::GlobalOperationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::GlobalOrganizationOperationsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGlobalOrganizationOperationsClient(this IServiceCollection services, sys::Action<gccv::GlobalOrganizationOperationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::GlobalOrganizationOperationsClientBuilder builder = new gccv::GlobalOrganizationOperationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::GlobalPublicDelegatedPrefixesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGlobalPublicDelegatedPrefixesClient(this IServiceCollection services, sys::Action<gccv::GlobalPublicDelegatedPrefixesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::GlobalPublicDelegatedPrefixesClientBuilder builder = new gccv::GlobalPublicDelegatedPrefixesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::HealthChecksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHealthChecksClient(this IServiceCollection services, sys::Action<gccv::HealthChecksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::HealthChecksClientBuilder builder = new gccv::HealthChecksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::ImageFamilyViewsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddImageFamilyViewsClient(this IServiceCollection services, sys::Action<gccv::ImageFamilyViewsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ImageFamilyViewsClientBuilder builder = new gccv::ImageFamilyViewsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ImagesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddImagesClient(this IServiceCollection services, sys::Action<gccv::ImagesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ImagesClientBuilder builder = new gccv::ImagesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::InstanceGroupManagersClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInstanceGroupManagersClient(this IServiceCollection services, sys::Action<gccv::InstanceGroupManagersClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InstanceGroupManagersClientBuilder builder = new gccv::InstanceGroupManagersClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::InstanceGroupsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInstanceGroupsClient(this IServiceCollection services, sys::Action<gccv::InstanceGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InstanceGroupsClientBuilder builder = new gccv::InstanceGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::InstanceTemplatesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInstanceTemplatesClient(this IServiceCollection services, sys::Action<gccv::InstanceTemplatesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InstanceTemplatesClientBuilder builder = new gccv::InstanceTemplatesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::InstancesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInstancesClient(this IServiceCollection services, sys::Action<gccv::InstancesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InstancesClientBuilder builder = new gccv::InstancesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::InterconnectAttachmentsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInterconnectAttachmentsClient(this IServiceCollection services, sys::Action<gccv::InterconnectAttachmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InterconnectAttachmentsClientBuilder builder = new gccv::InterconnectAttachmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::InterconnectLocationsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInterconnectLocationsClient(this IServiceCollection services, sys::Action<gccv::InterconnectLocationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InterconnectLocationsClientBuilder builder = new gccv::InterconnectLocationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::InterconnectsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInterconnectsClient(this IServiceCollection services, sys::Action<gccv::InterconnectsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::InterconnectsClientBuilder builder = new gccv::InterconnectsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::LicenseCodesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLicenseCodesClient(this IServiceCollection services, sys::Action<gccv::LicenseCodesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::LicenseCodesClientBuilder builder = new gccv::LicenseCodesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::LicensesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLicensesClient(this IServiceCollection services, sys::Action<gccv::LicensesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::LicensesClientBuilder builder = new gccv::LicensesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::MachineImagesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMachineImagesClient(this IServiceCollection services, sys::Action<gccv::MachineImagesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::MachineImagesClientBuilder builder = new gccv::MachineImagesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::MachineTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMachineTypesClient(this IServiceCollection services, sys::Action<gccv::MachineTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::MachineTypesClientBuilder builder = new gccv::MachineTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::NetworkEdgeSecurityServicesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkEdgeSecurityServicesClient(this IServiceCollection services, sys::Action<gccv::NetworkEdgeSecurityServicesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NetworkEdgeSecurityServicesClientBuilder builder = new gccv::NetworkEdgeSecurityServicesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::NetworkEndpointGroupsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkEndpointGroupsClient(this IServiceCollection services, sys::Action<gccv::NetworkEndpointGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NetworkEndpointGroupsClientBuilder builder = new gccv::NetworkEndpointGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::NetworkFirewallPoliciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkFirewallPoliciesClient(this IServiceCollection services, sys::Action<gccv::NetworkFirewallPoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NetworkFirewallPoliciesClientBuilder builder = new gccv::NetworkFirewallPoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::NetworksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworksClient(this IServiceCollection services, sys::Action<gccv::NetworksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NetworksClientBuilder builder = new gccv::NetworksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::NodeGroupsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNodeGroupsClient(this IServiceCollection services, sys::Action<gccv::NodeGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NodeGroupsClientBuilder builder = new gccv::NodeGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::NodeTemplatesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNodeTemplatesClient(this IServiceCollection services, sys::Action<gccv::NodeTemplatesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NodeTemplatesClientBuilder builder = new gccv::NodeTemplatesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::NodeTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNodeTypesClient(this IServiceCollection services, sys::Action<gccv::NodeTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::NodeTypesClientBuilder builder = new gccv::NodeTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::PacketMirroringsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPacketMirroringsClient(this IServiceCollection services, sys::Action<gccv::PacketMirroringsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::PacketMirroringsClientBuilder builder = new gccv::PacketMirroringsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ProjectsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProjectsClient(this IServiceCollection services, sys::Action<gccv::ProjectsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ProjectsClientBuilder builder = new gccv::ProjectsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::PublicAdvertisedPrefixesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPublicAdvertisedPrefixesClient(this IServiceCollection services, sys::Action<gccv::PublicAdvertisedPrefixesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::PublicAdvertisedPrefixesClientBuilder builder = new gccv::PublicAdvertisedPrefixesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::PublicDelegatedPrefixesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPublicDelegatedPrefixesClient(this IServiceCollection services, sys::Action<gccv::PublicDelegatedPrefixesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::PublicDelegatedPrefixesClientBuilder builder = new gccv::PublicDelegatedPrefixesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionAutoscalersClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionAutoscalersClient(this IServiceCollection services, sys::Action<gccv::RegionAutoscalersClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionAutoscalersClientBuilder builder = new gccv::RegionAutoscalersClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionBackendServicesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionBackendServicesClient(this IServiceCollection services, sys::Action<gccv::RegionBackendServicesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionBackendServicesClientBuilder builder = new gccv::RegionBackendServicesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionCommitmentsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionCommitmentsClient(this IServiceCollection services, sys::Action<gccv::RegionCommitmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionCommitmentsClientBuilder builder = new gccv::RegionCommitmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionDiskTypesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionDiskTypesClient(this IServiceCollection services, sys::Action<gccv::RegionDiskTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionDiskTypesClientBuilder builder = new gccv::RegionDiskTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::RegionDisksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionDisksClient(this IServiceCollection services, sys::Action<gccv::RegionDisksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionDisksClientBuilder builder = new gccv::RegionDisksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionHealthCheckServicesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionHealthCheckServicesClient(this IServiceCollection services, sys::Action<gccv::RegionHealthCheckServicesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionHealthCheckServicesClientBuilder builder = new gccv::RegionHealthCheckServicesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionHealthChecksClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionHealthChecksClient(this IServiceCollection services, sys::Action<gccv::RegionHealthChecksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionHealthChecksClientBuilder builder = new gccv::RegionHealthChecksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionInstanceGroupManagersClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionInstanceGroupManagersClient(this IServiceCollection services, sys::Action<gccv::RegionInstanceGroupManagersClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionInstanceGroupManagersClientBuilder builder = new gccv::RegionInstanceGroupManagersClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionInstanceGroupsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionInstanceGroupsClient(this IServiceCollection services, sys::Action<gccv::RegionInstanceGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionInstanceGroupsClientBuilder builder = new gccv::RegionInstanceGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionInstancesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionInstancesClient(this IServiceCollection services, sys::Action<gccv::RegionInstancesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionInstancesClientBuilder builder = new gccv::RegionInstancesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionNetworkEndpointGroupsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionNetworkEndpointGroupsClient(this IServiceCollection services, sys::Action<gccv::RegionNetworkEndpointGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionNetworkEndpointGroupsClientBuilder builder = new gccv::RegionNetworkEndpointGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionNetworkFirewallPoliciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionNetworkFirewallPoliciesClient(this IServiceCollection services, sys::Action<gccv::RegionNetworkFirewallPoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionNetworkFirewallPoliciesClientBuilder builder = new gccv::RegionNetworkFirewallPoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionNotificationEndpointsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionNotificationEndpointsClient(this IServiceCollection services, sys::Action<gccv::RegionNotificationEndpointsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionNotificationEndpointsClientBuilder builder = new gccv::RegionNotificationEndpointsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionOperationsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionOperationsClient(this IServiceCollection services, sys::Action<gccv::RegionOperationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionOperationsClientBuilder builder = new gccv::RegionOperationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionSecurityPoliciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionSecurityPoliciesClient(this IServiceCollection services, sys::Action<gccv::RegionSecurityPoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionSecurityPoliciesClientBuilder builder = new gccv::RegionSecurityPoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionSslCertificatesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionSslCertificatesClient(this IServiceCollection services, sys::Action<gccv::RegionSslCertificatesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionSslCertificatesClientBuilder builder = new gccv::RegionSslCertificatesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionTargetHttpProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionTargetHttpProxiesClient(this IServiceCollection services, sys::Action<gccv::RegionTargetHttpProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionTargetHttpProxiesClientBuilder builder = new gccv::RegionTargetHttpProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::RegionTargetHttpsProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionTargetHttpsProxiesClient(this IServiceCollection services, sys::Action<gccv::RegionTargetHttpsProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionTargetHttpsProxiesClientBuilder builder = new gccv::RegionTargetHttpsProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::RegionUrlMapsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionUrlMapsClient(this IServiceCollection services, sys::Action<gccv::RegionUrlMapsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionUrlMapsClientBuilder builder = new gccv::RegionUrlMapsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::RegionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionsClient(this IServiceCollection services, sys::Action<gccv::RegionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RegionsClientBuilder builder = new gccv::RegionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ReservationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddReservationsClient(this IServiceCollection services, sys::Action<gccv::ReservationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ReservationsClientBuilder builder = new gccv::ReservationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::ResourcePoliciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddResourcePoliciesClient(this IServiceCollection services, sys::Action<gccv::ResourcePoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ResourcePoliciesClientBuilder builder = new gccv::ResourcePoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::RoutersClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRoutersClient(this IServiceCollection services, sys::Action<gccv::RoutersClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RoutersClientBuilder builder = new gccv::RoutersClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::RoutesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRoutesClient(this IServiceCollection services, sys::Action<gccv::RoutesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::RoutesClientBuilder builder = new gccv::RoutesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::SecurityPoliciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSecurityPoliciesClient(this IServiceCollection services, sys::Action<gccv::SecurityPoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::SecurityPoliciesClientBuilder builder = new gccv::SecurityPoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::ServiceAttachmentsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServiceAttachmentsClient(this IServiceCollection services, sys::Action<gccv::ServiceAttachmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ServiceAttachmentsClientBuilder builder = new gccv::ServiceAttachmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::SnapshotsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSnapshotsClient(this IServiceCollection services, sys::Action<gccv::SnapshotsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::SnapshotsClientBuilder builder = new gccv::SnapshotsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::SslCertificatesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSslCertificatesClient(this IServiceCollection services, sys::Action<gccv::SslCertificatesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::SslCertificatesClientBuilder builder = new gccv::SslCertificatesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::SslPoliciesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSslPoliciesClient(this IServiceCollection services, sys::Action<gccv::SslPoliciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::SslPoliciesClientBuilder builder = new gccv::SslPoliciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::SubnetworksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSubnetworksClient(this IServiceCollection services, sys::Action<gccv::SubnetworksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::SubnetworksClientBuilder builder = new gccv::SubnetworksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetGrpcProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetGrpcProxiesClient(this IServiceCollection services, sys::Action<gccv::TargetGrpcProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetGrpcProxiesClientBuilder builder = new gccv::TargetGrpcProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetHttpProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetHttpProxiesClient(this IServiceCollection services, sys::Action<gccv::TargetHttpProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetHttpProxiesClientBuilder builder = new gccv::TargetHttpProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetHttpsProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetHttpsProxiesClient(this IServiceCollection services, sys::Action<gccv::TargetHttpsProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetHttpsProxiesClientBuilder builder = new gccv::TargetHttpsProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetInstancesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetInstancesClient(this IServiceCollection services, sys::Action<gccv::TargetInstancesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetInstancesClientBuilder builder = new gccv::TargetInstancesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::TargetPoolsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetPoolsClient(this IServiceCollection services, sys::Action<gccv::TargetPoolsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetPoolsClientBuilder builder = new gccv::TargetPoolsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetSslProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetSslProxiesClient(this IServiceCollection services, sys::Action<gccv::TargetSslProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetSslProxiesClientBuilder builder = new gccv::TargetSslProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetTcpProxiesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetTcpProxiesClient(this IServiceCollection services, sys::Action<gccv::TargetTcpProxiesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetTcpProxiesClientBuilder builder = new gccv::TargetTcpProxiesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::TargetVpnGatewaysClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTargetVpnGatewaysClient(this IServiceCollection services, sys::Action<gccv::TargetVpnGatewaysClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::TargetVpnGatewaysClientBuilder builder = new gccv::TargetVpnGatewaysClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::UrlMapsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUrlMapsClient(this IServiceCollection services, sys::Action<gccv::UrlMapsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::UrlMapsClientBuilder builder = new gccv::UrlMapsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::VpnGatewaysClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVpnGatewaysClient(this IServiceCollection services, sys::Action<gccv::VpnGatewaysClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::VpnGatewaysClientBuilder builder = new gccv::VpnGatewaysClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::VpnTunnelsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVpnTunnelsClient(this IServiceCollection services, sys::Action<gccv::VpnTunnelsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::VpnTunnelsClientBuilder builder = new gccv::VpnTunnelsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ZoneOperationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddZoneOperationsClient(this IServiceCollection services, sys::Action<gccv::ZoneOperationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ZoneOperationsClientBuilder builder = new gccv::ZoneOperationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ZonesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddZonesClient(this IServiceCollection services, sys::Action<gccv::ZonesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ZonesClientBuilder builder = new gccv::ZonesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
