// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using gcgv = Google.Cloud.Gaming.V1Beta;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcgv::GameServerClustersServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGameServerClustersServiceClient(this IServiceCollection services, sys::Action<gcgv::GameServerClustersServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::GameServerClustersServiceClientBuilder builder = new gcgv::GameServerClustersServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::GameServerConfigsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGameServerConfigsServiceClient(this IServiceCollection services, sys::Action<gcgv::GameServerConfigsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::GameServerConfigsServiceClientBuilder builder = new gcgv::GameServerConfigsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcgv::GameServerDeploymentsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGameServerDeploymentsServiceClient(this IServiceCollection services, sys::Action<gcgv::GameServerDeploymentsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::GameServerDeploymentsServiceClientBuilder builder = new gcgv::GameServerDeploymentsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcgv::RealmsServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRealmsServiceClient(this IServiceCollection services, sys::Action<gcgv::RealmsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcgv::RealmsServiceClientBuilder builder = new gcgv::RealmsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
