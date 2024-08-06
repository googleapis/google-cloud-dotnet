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
using gaxgrpc = Google.Api.Gax.Grpc;
using gcav = Google.Cloud.ApiHub.V1;
using gcl = Google.Cloud.Location;
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
        /// <summary>Adds a singleton <see cref="gcav::ApiHubClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApiHubClient(this IServiceCollection services, sys::Action<gcav::ApiHubClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ApiHubClientBuilder builder = new gcav::ApiHubClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ApiHubClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApiHubClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::ApiHubClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::ApiHubClientBuilder builder = new gcav::ApiHubClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::ApiHubDependenciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApiHubDependenciesClient(this IServiceCollection services, sys::Action<gcav::ApiHubDependenciesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ApiHubDependenciesClientBuilder builder = new gcav::ApiHubDependenciesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::ApiHubDependenciesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApiHubDependenciesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::ApiHubDependenciesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::ApiHubDependenciesClientBuilder builder = new gcav::ApiHubDependenciesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ApiHubPluginClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApiHubPluginClient(this IServiceCollection services, sys::Action<gcav::ApiHubPluginClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ApiHubPluginClientBuilder builder = new gcav::ApiHubPluginClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ApiHubPluginClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApiHubPluginClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::ApiHubPluginClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::ApiHubPluginClientBuilder builder = new gcav::ApiHubPluginClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::HostProjectRegistrationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHostProjectRegistrationServiceClient(this IServiceCollection services, sys::Action<gcav::HostProjectRegistrationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::HostProjectRegistrationServiceClientBuilder builder = new gcav::HostProjectRegistrationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::HostProjectRegistrationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHostProjectRegistrationServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::HostProjectRegistrationServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::HostProjectRegistrationServiceClientBuilder builder = new gcav::HostProjectRegistrationServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::LintingServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLintingServiceClient(this IServiceCollection services, sys::Action<gcav::LintingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::LintingServiceClientBuilder builder = new gcav::LintingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::LintingServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLintingServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::LintingServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::LintingServiceClientBuilder builder = new gcav::LintingServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ProvisioningClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProvisioningClient(this IServiceCollection services, sys::Action<gcav::ProvisioningClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ProvisioningClientBuilder builder = new gcav::ProvisioningClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ProvisioningClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProvisioningClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::ProvisioningClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::ProvisioningClientBuilder builder = new gcav::ProvisioningClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::RuntimeProjectAttachmentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRuntimeProjectAttachmentServiceClient(this IServiceCollection services, sys::Action<gcav::RuntimeProjectAttachmentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::RuntimeProjectAttachmentServiceClientBuilder builder = new gcav::RuntimeProjectAttachmentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::RuntimeProjectAttachmentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRuntimeProjectAttachmentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcav::RuntimeProjectAttachmentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcav::RuntimeProjectAttachmentServiceClientBuilder builder = new gcav::RuntimeProjectAttachmentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
