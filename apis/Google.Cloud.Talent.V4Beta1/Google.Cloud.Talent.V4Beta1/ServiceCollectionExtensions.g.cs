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
using gctv = Google.Cloud.Talent.V4Beta1;
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
        /// <summary>Adds a singleton <see cref="gctv::CompanyServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompanyServiceClient(this IServiceCollection services, sys::Action<gctv::CompanyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gctv::CompanyServiceClientBuilder builder = new gctv::CompanyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::CompanyServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompanyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gctv::CompanyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gctv::CompanyServiceClientBuilder builder = new gctv::CompanyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::CompletionClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompletionClient(this IServiceCollection services, sys::Action<gctv::CompletionClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gctv::CompletionClientBuilder builder = new gctv::CompletionClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::CompletionClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompletionClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gctv::CompletionClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gctv::CompletionClientBuilder builder = new gctv::CompletionClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::EventServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEventServiceClient(this IServiceCollection services, sys::Action<gctv::EventServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gctv::EventServiceClientBuilder builder = new gctv::EventServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::EventServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEventServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gctv::EventServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gctv::EventServiceClientBuilder builder = new gctv::EventServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::JobServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobServiceClient(this IServiceCollection services, sys::Action<gctv::JobServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gctv::JobServiceClientBuilder builder = new gctv::JobServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::JobServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gctv::JobServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gctv::JobServiceClientBuilder builder = new gctv::JobServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::TenantServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTenantServiceClient(this IServiceCollection services, sys::Action<gctv::TenantServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gctv::TenantServiceClientBuilder builder = new gctv::TenantServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gctv::TenantServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTenantServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gctv::TenantServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gctv::TenantServiceClientBuilder builder = new gctv::TenantServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
