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
using gccv = Google.Cloud.CloudSecurityCompliance.V1;
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
        /// <summary>Adds a singleton <see cref="gccv::AuditClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAuditClient(this IServiceCollection services, sys::Action<gccv::AuditClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::AuditClientBuilder builder = new gccv::AuditClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::AuditClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAuditClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::AuditClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::AuditClientBuilder builder = new gccv::AuditClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::CmEnrollmentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmEnrollmentServiceClient(this IServiceCollection services, sys::Action<gccv::CmEnrollmentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::CmEnrollmentServiceClientBuilder builder = new gccv::CmEnrollmentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::CmEnrollmentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmEnrollmentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::CmEnrollmentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::CmEnrollmentServiceClientBuilder builder = new gccv::CmEnrollmentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ConfigClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConfigClient(this IServiceCollection services, sys::Action<gccv::ConfigClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ConfigClientBuilder builder = new gccv::ConfigClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ConfigClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConfigClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::ConfigClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::ConfigClientBuilder builder = new gccv::ConfigClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::DeploymentClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeploymentClient(this IServiceCollection services, sys::Action<gccv::DeploymentClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::DeploymentClientBuilder builder = new gccv::DeploymentClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::DeploymentClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeploymentClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::DeploymentClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::DeploymentClientBuilder builder = new gccv::DeploymentClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::MonitoringClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMonitoringClient(this IServiceCollection services, sys::Action<gccv::MonitoringClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::MonitoringClientBuilder builder = new gccv::MonitoringClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::MonitoringClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMonitoringClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::MonitoringClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::MonitoringClientBuilder builder = new gccv::MonitoringClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
