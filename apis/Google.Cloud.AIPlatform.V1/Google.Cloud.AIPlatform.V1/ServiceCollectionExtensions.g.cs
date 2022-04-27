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
using gcav = Google.Cloud.AIPlatform.V1;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>Adds a singleton <see cref="gcav::DatasetServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDatasetServiceClient(this IServiceCollection services, sys::Action<gcav::DatasetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::DatasetServiceClientBuilder builder = new gcav::DatasetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::EndpointServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEndpointServiceClient(this IServiceCollection services, sys::Action<gcav::EndpointServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::EndpointServiceClientBuilder builder = new gcav::EndpointServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::FeaturestoreOnlineServingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFeaturestoreOnlineServingServiceClient(this IServiceCollection services, sys::Action<gcav::FeaturestoreOnlineServingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::FeaturestoreOnlineServingServiceClientBuilder builder = new gcav::FeaturestoreOnlineServingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::FeaturestoreServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFeaturestoreServiceClient(this IServiceCollection services, sys::Action<gcav::FeaturestoreServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::FeaturestoreServiceClientBuilder builder = new gcav::FeaturestoreServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::IndexEndpointServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIndexEndpointServiceClient(this IServiceCollection services, sys::Action<gcav::IndexEndpointServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::IndexEndpointServiceClientBuilder builder = new gcav::IndexEndpointServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::IndexServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIndexServiceClient(this IServiceCollection services, sys::Action<gcav::IndexServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::IndexServiceClientBuilder builder = new gcav::IndexServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::JobServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobServiceClient(this IServiceCollection services, sys::Action<gcav::JobServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::JobServiceClientBuilder builder = new gcav::JobServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::MetadataServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMetadataServiceClient(this IServiceCollection services, sys::Action<gcav::MetadataServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::MetadataServiceClientBuilder builder = new gcav::MetadataServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::MigrationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMigrationServiceClient(this IServiceCollection services, sys::Action<gcav::MigrationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::MigrationServiceClientBuilder builder = new gcav::MigrationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::ModelServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddModelServiceClient(this IServiceCollection services, sys::Action<gcav::ModelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::ModelServiceClientBuilder builder = new gcav::ModelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::PipelineServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPipelineServiceClient(this IServiceCollection services, sys::Action<gcav::PipelineServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::PipelineServiceClientBuilder builder = new gcav::PipelineServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::PredictionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPredictionServiceClient(this IServiceCollection services, sys::Action<gcav::PredictionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::PredictionServiceClientBuilder builder = new gcav::PredictionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::SpecialistPoolServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSpecialistPoolServiceClient(this IServiceCollection services, sys::Action<gcav::SpecialistPoolServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::SpecialistPoolServiceClientBuilder builder = new gcav::SpecialistPoolServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcav::TensorboardServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTensorboardServiceClient(this IServiceCollection services, sys::Action<gcav::TensorboardServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::TensorboardServiceClientBuilder builder = new gcav::TensorboardServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcav::VizierServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVizierServiceClient(this IServiceCollection services, sys::Action<gcav::VizierServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcav::VizierServiceClientBuilder builder = new gcav::VizierServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
