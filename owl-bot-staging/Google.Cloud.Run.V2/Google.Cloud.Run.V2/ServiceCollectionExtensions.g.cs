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
using gcrv = Google.Cloud.Run.V2;
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
        /// <summary>Adds a singleton <see cref="gcrv::BuildsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBuildsClient(this IServiceCollection services, sys::Action<gcrv::BuildsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::BuildsClientBuilder builder = new gcrv::BuildsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::BuildsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBuildsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::BuildsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::BuildsClientBuilder builder = new gcrv::BuildsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ExecutionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddExecutionsClient(this IServiceCollection services, sys::Action<gcrv::ExecutionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ExecutionsClientBuilder builder = new gcrv::ExecutionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ExecutionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddExecutionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ExecutionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ExecutionsClientBuilder builder = new gcrv::ExecutionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::JobsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobsClient(this IServiceCollection services, sys::Action<gcrv::JobsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::JobsClientBuilder builder = new gcrv::JobsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::JobsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::JobsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::JobsClientBuilder builder = new gcrv::JobsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::RevisionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRevisionsClient(this IServiceCollection services, sys::Action<gcrv::RevisionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::RevisionsClientBuilder builder = new gcrv::RevisionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::RevisionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRevisionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::RevisionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::RevisionsClientBuilder builder = new gcrv::RevisionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ServicesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServicesClient(this IServiceCollection services, sys::Action<gcrv::ServicesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::ServicesClientBuilder builder = new gcrv::ServicesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::ServicesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServicesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::ServicesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::ServicesClientBuilder builder = new gcrv::ServicesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TasksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTasksClient(this IServiceCollection services, sys::Action<gcrv::TasksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcrv::TasksClientBuilder builder = new gcrv::TasksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcrv::TasksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTasksClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcrv::TasksClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcrv::TasksClientBuilder builder = new gcrv::TasksClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
