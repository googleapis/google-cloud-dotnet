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
using gcdv = Google.Cloud.Dataplex.V1;
using gciv = Google.Cloud.Iam.V1;
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
        /// <summary>Adds a singleton <see cref="gcdv::CatalogServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCatalogServiceClient(this IServiceCollection services, sys::Action<gcdv::CatalogServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::CatalogServiceClientBuilder builder = new gcdv::CatalogServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::CatalogServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCatalogServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::CatalogServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::CatalogServiceClientBuilder builder = new gcdv::CatalogServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::CmekServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmekServiceClient(this IServiceCollection services, sys::Action<gcdv::CmekServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::CmekServiceClientBuilder builder = new gcdv::CmekServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::CmekServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmekServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::CmekServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::CmekServiceClientBuilder builder = new gcdv::CmekServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ContentServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentServiceClient(this IServiceCollection services, sys::Action<gcdv::ContentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ContentServiceClientBuilder builder = new gcdv::ContentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ContentServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::ContentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::ContentServiceClientBuilder builder = new gcdv::ContentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataScanServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataScanServiceClient(this IServiceCollection services, sys::Action<gcdv::DataScanServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataScanServiceClientBuilder builder = new gcdv::DataScanServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataScanServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataScanServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::DataScanServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataScanServiceClientBuilder builder = new gcdv::DataScanServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataTaxonomyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        [sys::ObsoleteAttribute]
        public static IServiceCollection AddDataTaxonomyServiceClient(this IServiceCollection services, sys::Action<gcdv::DataTaxonomyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataTaxonomyServiceClientBuilder builder = new gcdv::DataTaxonomyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataTaxonomyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        [sys::ObsoleteAttribute]
        public static IServiceCollection AddDataTaxonomyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::DataTaxonomyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataTaxonomyServiceClientBuilder builder = new gcdv::DataTaxonomyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataplexServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataplexServiceClient(this IServiceCollection services, sys::Action<gcdv::DataplexServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataplexServiceClientBuilder builder = new gcdv::DataplexServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataplexServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataplexServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::DataplexServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataplexServiceClientBuilder builder = new gcdv::DataplexServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::MetadataServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMetadataServiceClient(this IServiceCollection services, sys::Action<gcdv::MetadataServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::MetadataServiceClientBuilder builder = new gcdv::MetadataServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::MetadataServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMetadataServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::MetadataServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::MetadataServiceClientBuilder builder = new gcdv::MetadataServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
