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
using gccv = Google.Cloud.Ces.V1Beta;
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
        /// <summary>Adds a singleton <see cref="gccv::AgentServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAgentServiceClient(this IServiceCollection services, sys::Action<gccv::AgentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::AgentServiceClientBuilder builder = new gccv::AgentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::AgentServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAgentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::AgentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::AgentServiceClientBuilder builder = new gccv::AgentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::EvaluationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEvaluationServiceClient(this IServiceCollection services, sys::Action<gccv::EvaluationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::EvaluationServiceClientBuilder builder = new gccv::EvaluationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::EvaluationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEvaluationServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::EvaluationServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::EvaluationServiceClientBuilder builder = new gccv::EvaluationServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::SessionServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionServiceClient(this IServiceCollection services, sys::Action<gccv::SessionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::SessionServiceClientBuilder builder = new gccv::SessionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::SessionServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::SessionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::SessionServiceClientBuilder builder = new gccv::SessionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ToolServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddToolServiceClient(this IServiceCollection services, sys::Action<gccv::ToolServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::ToolServiceClientBuilder builder = new gccv::ToolServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::ToolServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddToolServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::ToolServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::ToolServiceClientBuilder builder = new gccv::ToolServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::WidgetServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWidgetServiceClient(this IServiceCollection services, sys::Action<gccv::WidgetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::WidgetServiceClientBuilder builder = new gccv::WidgetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gccv::WidgetServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWidgetServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::WidgetServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::WidgetServiceClientBuilder builder = new gccv::WidgetServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
