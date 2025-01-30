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
using gcrv = Google.Cloud.ResourceManager.V3;
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
        /// <summary>Adds a singleton <see cref="gcrv::FoldersClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFoldersClient(this IServiceCollection services, sys::Action<gcrv::FoldersClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::FoldersClientBuilder builder = new gcrv::FoldersClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::FoldersClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFoldersClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::FoldersClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::FoldersClientBuilder builder = new gcrv::FoldersClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::OrganizationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrganizationsClient(this IServiceCollection services, sys::Action<gcrv::OrganizationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::OrganizationsClientBuilder builder = new gcrv::OrganizationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::OrganizationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrganizationsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::OrganizationsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::OrganizationsClientBuilder builder = new gcrv::OrganizationsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ProjectsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProjectsClient(this IServiceCollection services, sys::Action<gcrv::ProjectsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ProjectsClientBuilder builder = new gcrv::ProjectsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ProjectsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProjectsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ProjectsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ProjectsClientBuilder builder = new gcrv::ProjectsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagBindingsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagBindingsClient(this IServiceCollection services, sys::Action<gcrv::TagBindingsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagBindingsClientBuilder builder = new gcrv::TagBindingsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagBindingsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagBindingsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::TagBindingsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagBindingsClientBuilder builder = new gcrv::TagBindingsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagHoldsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagHoldsClient(this IServiceCollection services, sys::Action<gcrv::TagHoldsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagHoldsClientBuilder builder = new gcrv::TagHoldsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagHoldsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagHoldsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::TagHoldsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagHoldsClientBuilder builder = new gcrv::TagHoldsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagKeysClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagKeysClient(this IServiceCollection services, sys::Action<gcrv::TagKeysClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagKeysClientBuilder builder = new gcrv::TagKeysClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagKeysClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagKeysClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::TagKeysClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagKeysClientBuilder builder = new gcrv::TagKeysClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagValuesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagValuesClient(this IServiceCollection services, sys::Action<gcrv::TagValuesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagValuesClientBuilder builder = new gcrv::TagValuesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TagValuesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTagValuesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::TagValuesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::TagValuesClientBuilder builder = new gcrv::TagValuesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
