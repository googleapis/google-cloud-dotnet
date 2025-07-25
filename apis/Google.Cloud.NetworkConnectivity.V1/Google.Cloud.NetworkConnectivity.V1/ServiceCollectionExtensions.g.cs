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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gcnv = Google.Cloud.NetworkConnectivity.V1;
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
        /// <summary>
        /// Adds a singleton <see cref="gcnv::CrossNetworkAutomationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCrossNetworkAutomationServiceClient(this IServiceCollection services, sys::Action<gcnv::CrossNetworkAutomationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::CrossNetworkAutomationServiceClientBuilder builder = new gcnv::CrossNetworkAutomationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::CrossNetworkAutomationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCrossNetworkAutomationServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::CrossNetworkAutomationServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::CrossNetworkAutomationServiceClientBuilder builder = new gcnv::CrossNetworkAutomationServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcnv::HubServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHubServiceClient(this IServiceCollection services, sys::Action<gcnv::HubServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::HubServiceClientBuilder builder = new gcnv::HubServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcnv::HubServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHubServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::HubServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::HubServiceClientBuilder builder = new gcnv::HubServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::InternalRangeServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInternalRangeServiceClient(this IServiceCollection services, sys::Action<gcnv::InternalRangeServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::InternalRangeServiceClientBuilder builder = new gcnv::InternalRangeServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::InternalRangeServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddInternalRangeServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::InternalRangeServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::InternalRangeServiceClientBuilder builder = new gcnv::InternalRangeServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::PolicyBasedRoutingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPolicyBasedRoutingServiceClient(this IServiceCollection services, sys::Action<gcnv::PolicyBasedRoutingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcnv::PolicyBasedRoutingServiceClientBuilder builder = new gcnv::PolicyBasedRoutingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcnv::PolicyBasedRoutingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPolicyBasedRoutingServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcnv::PolicyBasedRoutingServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcnv::PolicyBasedRoutingServiceClientBuilder builder = new gcnv::PolicyBasedRoutingServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
