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
using gadv = Google.Ads.DataManager.V1;
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gadv::IngestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIngestionServiceClient(this IServiceCollection services, sys::Action<gadv::IngestionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gadv::IngestionServiceClientBuilder builder = new gadv::IngestionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::IngestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIngestionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gadv::IngestionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gadv::IngestionServiceClientBuilder builder = new gadv::IngestionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::MarketingDataInsightsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMarketingDataInsightsServiceClient(this IServiceCollection services, sys::Action<gadv::MarketingDataInsightsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gadv::MarketingDataInsightsServiceClientBuilder builder = new gadv::MarketingDataInsightsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::MarketingDataInsightsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMarketingDataInsightsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gadv::MarketingDataInsightsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gadv::MarketingDataInsightsServiceClientBuilder builder = new gadv::MarketingDataInsightsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::PartnerLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPartnerLinkServiceClient(this IServiceCollection services, sys::Action<gadv::PartnerLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gadv::PartnerLinkServiceClientBuilder builder = new gadv::PartnerLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::PartnerLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPartnerLinkServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gadv::PartnerLinkServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gadv::PartnerLinkServiceClientBuilder builder = new gadv::PartnerLinkServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::UserListDirectLicenseServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserListDirectLicenseServiceClient(this IServiceCollection services, sys::Action<gadv::UserListDirectLicenseServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gadv::UserListDirectLicenseServiceClientBuilder builder = new gadv::UserListDirectLicenseServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::UserListDirectLicenseServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserListDirectLicenseServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gadv::UserListDirectLicenseServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gadv::UserListDirectLicenseServiceClientBuilder builder = new gadv::UserListDirectLicenseServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::UserListGlobalLicenseServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserListGlobalLicenseServiceClient(this IServiceCollection services, sys::Action<gadv::UserListGlobalLicenseServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gadv::UserListGlobalLicenseServiceClientBuilder builder = new gadv::UserListGlobalLicenseServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::UserListGlobalLicenseServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserListGlobalLicenseServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gadv::UserListGlobalLicenseServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gadv::UserListGlobalLicenseServiceClientBuilder builder = new gadv::UserListGlobalLicenseServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::UserListServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserListServiceClient(this IServiceCollection services, sys::Action<gadv::UserListServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gadv::UserListServiceClientBuilder builder = new gadv::UserListServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gadv::UserListServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserListServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gadv::UserListServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gadv::UserListServiceClientBuilder builder = new gadv::UserListServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
