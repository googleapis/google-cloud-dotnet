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
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gcnv = Google.Cloud.NetworkSecurity.V1;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcnv::AddressGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAddressGroupServiceClient(this IServiceCollection services, sys::Action<gcnv::AddressGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::AddressGroupServiceClientBuilder builder = new gcnv::AddressGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::AddressGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAddressGroupServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::AddressGroupServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::AddressGroupServiceClientBuilder builder = new gcnv::AddressGroupServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::DnsThreatDetectorServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDnsThreatDetectorServiceClient(this IServiceCollection services, sys::Action<gcnv::DnsThreatDetectorServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::DnsThreatDetectorServiceClientBuilder builder = new gcnv::DnsThreatDetectorServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::DnsThreatDetectorServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDnsThreatDetectorServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::DnsThreatDetectorServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::DnsThreatDetectorServiceClientBuilder builder = new gcnv::DnsThreatDetectorServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::FirewallActivationClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFirewallActivationClient(this IServiceCollection services, sys::Action<gcnv::FirewallActivationClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::FirewallActivationClientBuilder builder = new gcnv::FirewallActivationClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::FirewallActivationClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFirewallActivationClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::FirewallActivationClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::FirewallActivationClientBuilder builder = new gcnv::FirewallActivationClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcnv::InterceptClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInterceptClient(this IServiceCollection services, sys::Action<gcnv::InterceptClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::InterceptClientBuilder builder = new gcnv::InterceptClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcnv::InterceptClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInterceptClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::InterceptClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::InterceptClientBuilder builder = new gcnv::InterceptClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcnv::MirroringClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMirroringClient(this IServiceCollection services, sys::Action<gcnv::MirroringClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::MirroringClientBuilder builder = new gcnv::MirroringClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcnv::MirroringClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMirroringClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::MirroringClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::MirroringClientBuilder builder = new gcnv::MirroringClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::NetworkSecurityClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkSecurityClient(this IServiceCollection services, sys::Action<gcnv::NetworkSecurityClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::NetworkSecurityClientBuilder builder = new gcnv::NetworkSecurityClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::NetworkSecurityClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkSecurityClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::NetworkSecurityClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::NetworkSecurityClientBuilder builder = new gcnv::NetworkSecurityClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::OrganizationAddressGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrganizationAddressGroupServiceClient(this IServiceCollection services, sys::Action<gcnv::OrganizationAddressGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::OrganizationAddressGroupServiceClientBuilder builder = new gcnv::OrganizationAddressGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::OrganizationAddressGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrganizationAddressGroupServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::OrganizationAddressGroupServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::OrganizationAddressGroupServiceClientBuilder builder = new gcnv::OrganizationAddressGroupServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::OrganizationSecurityProfileGroupServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrganizationSecurityProfileGroupServiceClient(this IServiceCollection services, sys::Action<gcnv::OrganizationSecurityProfileGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::OrganizationSecurityProfileGroupServiceClientBuilder builder = new gcnv::OrganizationSecurityProfileGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::OrganizationSecurityProfileGroupServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrganizationSecurityProfileGroupServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::OrganizationSecurityProfileGroupServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::OrganizationSecurityProfileGroupServiceClientBuilder builder = new gcnv::OrganizationSecurityProfileGroupServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::SSERealmServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSSERealmServiceClient(this IServiceCollection services, sys::Action<gcnv::SSERealmServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::SSERealmServiceClientBuilder builder = new gcnv::SSERealmServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::SSERealmServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSSERealmServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::SSERealmServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::SSERealmServiceClientBuilder builder = new gcnv::SSERealmServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::SecurityProfileGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSecurityProfileGroupServiceClient(this IServiceCollection services, sys::Action<gcnv::SecurityProfileGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::SecurityProfileGroupServiceClientBuilder builder = new gcnv::SecurityProfileGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::SecurityProfileGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSecurityProfileGroupServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::SecurityProfileGroupServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::SecurityProfileGroupServiceClientBuilder builder = new gcnv::SecurityProfileGroupServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
