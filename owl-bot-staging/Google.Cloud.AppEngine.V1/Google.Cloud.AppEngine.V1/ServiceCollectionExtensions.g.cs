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
using gaxgrpc = Google.Api.Gax.Grpc;
using gcav = Google.Cloud.AppEngine.V1;
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
        /// <summary>Adds a singleton <see cref="gcav::ApplicationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApplicationsClient(this IServiceCollection services, sys::Action<gcav::ApplicationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ApplicationsClientBuilder builder = new gcav::ApplicationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ApplicationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApplicationsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::ApplicationsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::ApplicationsClientBuilder builder = new gcav::ApplicationsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::AuthorizedCertificatesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAuthorizedCertificatesClient(this IServiceCollection services, sys::Action<gcav::AuthorizedCertificatesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::AuthorizedCertificatesClientBuilder builder = new gcav::AuthorizedCertificatesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::AuthorizedCertificatesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAuthorizedCertificatesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::AuthorizedCertificatesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::AuthorizedCertificatesClientBuilder builder = new gcav::AuthorizedCertificatesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::AuthorizedDomainsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAuthorizedDomainsClient(this IServiceCollection services, sys::Action<gcav::AuthorizedDomainsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::AuthorizedDomainsClientBuilder builder = new gcav::AuthorizedDomainsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::AuthorizedDomainsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAuthorizedDomainsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::AuthorizedDomainsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::AuthorizedDomainsClientBuilder builder = new gcav::AuthorizedDomainsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::DomainMappingsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDomainMappingsClient(this IServiceCollection services, sys::Action<gcav::DomainMappingsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::DomainMappingsClientBuilder builder = new gcav::DomainMappingsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::DomainMappingsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDomainMappingsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::DomainMappingsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::DomainMappingsClientBuilder builder = new gcav::DomainMappingsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::FirewallClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFirewallClient(this IServiceCollection services, sys::Action<gcav::FirewallClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::FirewallClientBuilder builder = new gcav::FirewallClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::FirewallClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFirewallClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::FirewallClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::FirewallClientBuilder builder = new gcav::FirewallClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::InstancesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInstancesClient(this IServiceCollection services, sys::Action<gcav::InstancesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::InstancesClientBuilder builder = new gcav::InstancesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::InstancesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInstancesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::InstancesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::InstancesClientBuilder builder = new gcav::InstancesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ServicesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServicesClient(this IServiceCollection services, sys::Action<gcav::ServicesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ServicesClientBuilder builder = new gcav::ServicesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ServicesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServicesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::ServicesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::ServicesClientBuilder builder = new gcav::ServicesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::VersionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVersionsClient(this IServiceCollection services, sys::Action<gcav::VersionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::VersionsClientBuilder builder = new gcav::VersionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::VersionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVersionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::VersionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::VersionsClientBuilder builder = new gcav::VersionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
