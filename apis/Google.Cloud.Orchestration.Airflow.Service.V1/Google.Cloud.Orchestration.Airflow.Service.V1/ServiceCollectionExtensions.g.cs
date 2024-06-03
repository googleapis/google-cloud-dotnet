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
using gcoasv = Google.Cloud.Orchestration.Airflow.Service.V1;
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
        /// <summary>Adds a singleton <see cref="gcoasv::EnvironmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEnvironmentsClient(this IServiceCollection services, sys::Action<gcoasv::EnvironmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcoasv::EnvironmentsClientBuilder builder = new gcoasv::EnvironmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcoasv::EnvironmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEnvironmentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcoasv::EnvironmentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcoasv::EnvironmentsClientBuilder builder = new gcoasv::EnvironmentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcoasv::ImageVersionsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddImageVersionsClient(this IServiceCollection services, sys::Action<gcoasv::ImageVersionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcoasv::ImageVersionsClientBuilder builder = new gcoasv::ImageVersionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcoasv::ImageVersionsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddImageVersionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcoasv::ImageVersionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcoasv::ImageVersionsClientBuilder builder = new gcoasv::ImageVersionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
