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
using gaav = Google.Ads.AdManager.V1;
using gaxgrpc = Google.Api.Gax.Grpc;
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
        /// <summary>Adds a singleton <see cref="gaav::AdUnitServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdUnitServiceClient(this IServiceCollection services, sys::Action<gaav::AdUnitServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::AdUnitServiceClientBuilder builder = new gaav::AdUnitServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::AdUnitServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdUnitServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::AdUnitServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::AdUnitServiceClientBuilder builder = new gaav::AdUnitServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::CompanyServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompanyServiceClient(this IServiceCollection services, sys::Action<gaav::CompanyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CompanyServiceClientBuilder builder = new gaav::CompanyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::CompanyServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompanyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CompanyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CompanyServiceClientBuilder builder = new gaav::CompanyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomFieldServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomFieldServiceClient(this IServiceCollection services, sys::Action<gaav::CustomFieldServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomFieldServiceClientBuilder builder = new gaav::CustomFieldServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomFieldServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomFieldServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CustomFieldServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomFieldServiceClientBuilder builder = new gaav::CustomFieldServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingKeyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingKeyServiceClient(this IServiceCollection services, sys::Action<gaav::CustomTargetingKeyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingKeyServiceClientBuilder builder = new gaav::CustomTargetingKeyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingKeyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingKeyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CustomTargetingKeyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingKeyServiceClientBuilder builder = new gaav::CustomTargetingKeyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingValueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingValueServiceClient(this IServiceCollection services, sys::Action<gaav::CustomTargetingValueServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingValueServiceClientBuilder builder = new gaav::CustomTargetingValueServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingValueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingValueServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CustomTargetingValueServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingValueServiceClientBuilder builder = new gaav::CustomTargetingValueServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::EntitySignalsMappingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntitySignalsMappingServiceClient(this IServiceCollection services, sys::Action<gaav::EntitySignalsMappingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::EntitySignalsMappingServiceClientBuilder builder = new gaav::EntitySignalsMappingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::EntitySignalsMappingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntitySignalsMappingServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::EntitySignalsMappingServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::EntitySignalsMappingServiceClientBuilder builder = new gaav::EntitySignalsMappingServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::NetworkServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkServiceClient(this IServiceCollection services, sys::Action<gaav::NetworkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::NetworkServiceClientBuilder builder = new gaav::NetworkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::NetworkServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::NetworkServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::NetworkServiceClientBuilder builder = new gaav::NetworkServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::OrderServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrderServiceClient(this IServiceCollection services, sys::Action<gaav::OrderServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::OrderServiceClientBuilder builder = new gaav::OrderServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::OrderServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrderServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::OrderServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::OrderServiceClientBuilder builder = new gaav::OrderServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PlacementServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPlacementServiceClient(this IServiceCollection services, sys::Action<gaav::PlacementServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::PlacementServiceClientBuilder builder = new gaav::PlacementServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PlacementServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPlacementServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::PlacementServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::PlacementServiceClientBuilder builder = new gaav::PlacementServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ReportServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddReportServiceClient(this IServiceCollection services, sys::Action<gaav::ReportServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ReportServiceClientBuilder builder = new gaav::ReportServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ReportServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddReportServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ReportServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ReportServiceClientBuilder builder = new gaav::ReportServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::RoleServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRoleServiceClient(this IServiceCollection services, sys::Action<gaav::RoleServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::RoleServiceClientBuilder builder = new gaav::RoleServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::RoleServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRoleServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::RoleServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::RoleServiceClientBuilder builder = new gaav::RoleServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::TaxonomyCategoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTaxonomyCategoryServiceClient(this IServiceCollection services, sys::Action<gaav::TaxonomyCategoryServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::TaxonomyCategoryServiceClientBuilder builder = new gaav::TaxonomyCategoryServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::TaxonomyCategoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTaxonomyCategoryServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::TaxonomyCategoryServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::TaxonomyCategoryServiceClientBuilder builder = new gaav::TaxonomyCategoryServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::UserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserServiceClient(this IServiceCollection services, sys::Action<gaav::UserServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::UserServiceClientBuilder builder = new gaav::UserServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::UserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::UserServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::UserServiceClientBuilder builder = new gaav::UserServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
