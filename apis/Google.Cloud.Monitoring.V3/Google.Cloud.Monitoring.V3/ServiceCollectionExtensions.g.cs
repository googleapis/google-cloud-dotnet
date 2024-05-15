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
using gcmv = Google.Cloud.Monitoring.V3;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcmv::AlertPolicyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAlertPolicyServiceClient(this IServiceCollection services, sys::Action<gcmv::AlertPolicyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::AlertPolicyServiceClientBuilder builder = new gcmv::AlertPolicyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::AlertPolicyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAlertPolicyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::AlertPolicyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::AlertPolicyServiceClientBuilder builder = new gcmv::AlertPolicyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::GroupServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGroupServiceClient(this IServiceCollection services, sys::Action<gcmv::GroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::GroupServiceClientBuilder builder = new gcmv::GroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::GroupServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGroupServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::GroupServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::GroupServiceClientBuilder builder = new gcmv::GroupServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::MetricServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMetricServiceClient(this IServiceCollection services, sys::Action<gcmv::MetricServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::MetricServiceClientBuilder builder = new gcmv::MetricServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::MetricServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMetricServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::MetricServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::MetricServiceClientBuilder builder = new gcmv::MetricServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::NotificationChannelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNotificationChannelServiceClient(this IServiceCollection services, sys::Action<gcmv::NotificationChannelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::NotificationChannelServiceClientBuilder builder = new gcmv::NotificationChannelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::NotificationChannelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNotificationChannelServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::NotificationChannelServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::NotificationChannelServiceClientBuilder builder = new gcmv::NotificationChannelServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::QueryServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddQueryServiceClient(this IServiceCollection services, sys::Action<gcmv::QueryServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::QueryServiceClientBuilder builder = new gcmv::QueryServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::QueryServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddQueryServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::QueryServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::QueryServiceClientBuilder builder = new gcmv::QueryServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::ServiceMonitoringServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServiceMonitoringServiceClient(this IServiceCollection services, sys::Action<gcmv::ServiceMonitoringServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::ServiceMonitoringServiceClientBuilder builder = new gcmv::ServiceMonitoringServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::ServiceMonitoringServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServiceMonitoringServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::ServiceMonitoringServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::ServiceMonitoringServiceClientBuilder builder = new gcmv::ServiceMonitoringServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::SnoozeServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSnoozeServiceClient(this IServiceCollection services, sys::Action<gcmv::SnoozeServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::SnoozeServiceClientBuilder builder = new gcmv::SnoozeServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcmv::SnoozeServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSnoozeServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::SnoozeServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::SnoozeServiceClientBuilder builder = new gcmv::SnoozeServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::UptimeCheckServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUptimeCheckServiceClient(this IServiceCollection services, sys::Action<gcmv::UptimeCheckServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcmv::UptimeCheckServiceClientBuilder builder = new gcmv::UptimeCheckServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcmv::UptimeCheckServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUptimeCheckServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcmv::UptimeCheckServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcmv::UptimeCheckServiceClientBuilder builder = new gcmv::UptimeCheckServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
