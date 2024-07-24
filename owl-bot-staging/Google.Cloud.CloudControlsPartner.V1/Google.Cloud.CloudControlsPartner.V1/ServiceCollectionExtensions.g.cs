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
using gccv = Google.Cloud.CloudControlsPartner.V1;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gccv::CloudControlsPartnerCoreClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCloudControlsPartnerCoreClient(this IServiceCollection services, sys::Action<gccv::CloudControlsPartnerCoreClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::CloudControlsPartnerCoreClientBuilder builder = new gccv::CloudControlsPartnerCoreClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::CloudControlsPartnerCoreClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCloudControlsPartnerCoreClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::CloudControlsPartnerCoreClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::CloudControlsPartnerCoreClientBuilder builder = new gccv::CloudControlsPartnerCoreClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::CloudControlsPartnerMonitoringClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCloudControlsPartnerMonitoringClient(this IServiceCollection services, sys::Action<gccv::CloudControlsPartnerMonitoringClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gccv::CloudControlsPartnerMonitoringClientBuilder builder = new gccv::CloudControlsPartnerMonitoringClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gccv::CloudControlsPartnerMonitoringClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCloudControlsPartnerMonitoringClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gccv::CloudControlsPartnerMonitoringClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gccv::CloudControlsPartnerMonitoringClientBuilder builder = new gccv::CloudControlsPartnerMonitoringClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
