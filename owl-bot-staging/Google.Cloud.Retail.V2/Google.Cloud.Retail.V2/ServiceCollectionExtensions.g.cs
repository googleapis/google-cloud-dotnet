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
using gcl = Google.Cloud.Location;
using gcrv = Google.Cloud.Retail.V2;
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
        /// Adds a singleton <see cref="gcrv::AnalyticsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAnalyticsServiceClient(this IServiceCollection services, sys::Action<gcrv::AnalyticsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::AnalyticsServiceClientBuilder builder = new gcrv::AnalyticsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::AnalyticsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAnalyticsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::AnalyticsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::AnalyticsServiceClientBuilder builder = new gcrv::AnalyticsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::CatalogServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCatalogServiceClient(this IServiceCollection services, sys::Action<gcrv::CatalogServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::CatalogServiceClientBuilder builder = new gcrv::CatalogServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::CatalogServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCatalogServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::CatalogServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::CatalogServiceClientBuilder builder = new gcrv::CatalogServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::CompletionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompletionServiceClient(this IServiceCollection services, sys::Action<gcrv::CompletionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::CompletionServiceClientBuilder builder = new gcrv::CompletionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::CompletionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompletionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::CompletionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::CompletionServiceClientBuilder builder = new gcrv::CompletionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ControlServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddControlServiceClient(this IServiceCollection services, sys::Action<gcrv::ControlServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ControlServiceClientBuilder builder = new gcrv::ControlServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ControlServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddControlServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ControlServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ControlServiceClientBuilder builder = new gcrv::ControlServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::GenerativeQuestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGenerativeQuestionServiceClient(this IServiceCollection services, sys::Action<gcrv::GenerativeQuestionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::GenerativeQuestionServiceClientBuilder builder = new gcrv::GenerativeQuestionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::GenerativeQuestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGenerativeQuestionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::GenerativeQuestionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::GenerativeQuestionServiceClientBuilder builder = new gcrv::GenerativeQuestionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ModelServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddModelServiceClient(this IServiceCollection services, sys::Action<gcrv::ModelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ModelServiceClientBuilder builder = new gcrv::ModelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ModelServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddModelServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ModelServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ModelServiceClientBuilder builder = new gcrv::ModelServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::PredictionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPredictionServiceClient(this IServiceCollection services, sys::Action<gcrv::PredictionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::PredictionServiceClientBuilder builder = new gcrv::PredictionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::PredictionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPredictionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::PredictionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::PredictionServiceClientBuilder builder = new gcrv::PredictionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ProductServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProductServiceClient(this IServiceCollection services, sys::Action<gcrv::ProductServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ProductServiceClientBuilder builder = new gcrv::ProductServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ProductServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProductServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ProductServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ProductServiceClientBuilder builder = new gcrv::ProductServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::SearchServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSearchServiceClient(this IServiceCollection services, sys::Action<gcrv::SearchServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::SearchServiceClientBuilder builder = new gcrv::SearchServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::SearchServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSearchServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::SearchServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::SearchServiceClientBuilder builder = new gcrv::SearchServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::ServingConfigServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServingConfigServiceClient(this IServiceCollection services, sys::Action<gcrv::ServingConfigServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ServingConfigServiceClientBuilder builder = new gcrv::ServingConfigServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::ServingConfigServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServingConfigServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ServingConfigServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ServingConfigServiceClientBuilder builder = new gcrv::ServingConfigServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::UserEventServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserEventServiceClient(this IServiceCollection services, sys::Action<gcrv::UserEventServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::UserEventServiceClientBuilder builder = new gcrv::UserEventServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcrv::UserEventServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserEventServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::UserEventServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::UserEventServiceClientBuilder builder = new gcrv::UserEventServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
