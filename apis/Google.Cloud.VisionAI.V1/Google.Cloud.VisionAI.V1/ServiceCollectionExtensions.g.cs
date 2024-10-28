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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gcvv = Google.Cloud.VisionAI.V1;
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
        /// <summary>Adds a singleton <see cref="gcvv::AppPlatformClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAppPlatformClient(this IServiceCollection services, sys::Action<gcvv::AppPlatformClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcvv::AppPlatformClientBuilder builder = new gcvv::AppPlatformClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcvv::AppPlatformClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAppPlatformClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcvv::AppPlatformClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcvv::AppPlatformClientBuilder builder = new gcvv::AppPlatformClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcvv::HealthCheckServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHealthCheckServiceClient(this IServiceCollection services, sys::Action<gcvv::HealthCheckServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcvv::HealthCheckServiceClientBuilder builder = new gcvv::HealthCheckServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcvv::HealthCheckServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHealthCheckServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcvv::HealthCheckServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcvv::HealthCheckServiceClientBuilder builder = new gcvv::HealthCheckServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcvv::LiveVideoAnalyticsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLiveVideoAnalyticsClient(this IServiceCollection services, sys::Action<gcvv::LiveVideoAnalyticsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcvv::LiveVideoAnalyticsClientBuilder builder = new gcvv::LiveVideoAnalyticsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcvv::LiveVideoAnalyticsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLiveVideoAnalyticsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcvv::LiveVideoAnalyticsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcvv::LiveVideoAnalyticsClientBuilder builder = new gcvv::LiveVideoAnalyticsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcvv::StreamingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddStreamingServiceClient(this IServiceCollection services, sys::Action<gcvv::StreamingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcvv::StreamingServiceClientBuilder builder = new gcvv::StreamingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcvv::StreamingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddStreamingServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcvv::StreamingServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcvv::StreamingServiceClientBuilder builder = new gcvv::StreamingServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcvv::StreamsServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddStreamsServiceClient(this IServiceCollection services, sys::Action<gcvv::StreamsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcvv::StreamsServiceClientBuilder builder = new gcvv::StreamsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcvv::StreamsServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddStreamsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcvv::StreamsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcvv::StreamsServiceClientBuilder builder = new gcvv::StreamsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcvv::WarehouseClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWarehouseClient(this IServiceCollection services, sys::Action<gcvv::WarehouseClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcvv::WarehouseClientBuilder builder = new gcvv::WarehouseClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcvv::WarehouseClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWarehouseClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcvv::WarehouseClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcvv::WarehouseClientBuilder builder = new gcvv::WarehouseClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
