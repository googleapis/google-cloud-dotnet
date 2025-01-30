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
using gpr = Google.Protobuf.Reflection;
using gsmlv = Google.Shopping.Merchant.Lfp.V1Beta;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gsmlv::LfpInventoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLfpInventoryServiceClient(this IServiceCollection services, sys::Action<gsmlv::LfpInventoryServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmlv::LfpInventoryServiceClientBuilder builder = new gsmlv::LfpInventoryServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmlv::LfpInventoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLfpInventoryServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmlv::LfpInventoryServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmlv::LfpInventoryServiceClientBuilder builder = new gsmlv::LfpInventoryServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmlv::LfpSaleServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLfpSaleServiceClient(this IServiceCollection services, sys::Action<gsmlv::LfpSaleServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmlv::LfpSaleServiceClientBuilder builder = new gsmlv::LfpSaleServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmlv::LfpSaleServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLfpSaleServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmlv::LfpSaleServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmlv::LfpSaleServiceClientBuilder builder = new gsmlv::LfpSaleServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmlv::LfpStoreServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLfpStoreServiceClient(this IServiceCollection services, sys::Action<gsmlv::LfpStoreServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmlv::LfpStoreServiceClientBuilder builder = new gsmlv::LfpStoreServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmlv::LfpStoreServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddLfpStoreServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmlv::LfpStoreServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmlv::LfpStoreServiceClientBuilder builder = new gsmlv::LfpStoreServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
