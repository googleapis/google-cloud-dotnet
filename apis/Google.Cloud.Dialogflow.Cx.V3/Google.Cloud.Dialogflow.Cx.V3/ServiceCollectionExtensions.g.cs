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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
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
        /// <summary>Adds a singleton <see cref="gcdcv::AgentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAgentsClient(this IServiceCollection services, sys::Action<gcdcv::AgentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::AgentsClientBuilder builder = new gcdcv::AgentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::AgentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAgentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::AgentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::AgentsClientBuilder builder = new gcdcv::AgentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::ChangelogsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddChangelogsClient(this IServiceCollection services, sys::Action<gcdcv::ChangelogsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::ChangelogsClientBuilder builder = new gcdcv::ChangelogsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::ChangelogsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddChangelogsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::ChangelogsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::ChangelogsClientBuilder builder = new gcdcv::ChangelogsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::DeploymentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeploymentsClient(this IServiceCollection services, sys::Action<gcdcv::DeploymentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::DeploymentsClientBuilder builder = new gcdcv::DeploymentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::DeploymentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeploymentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::DeploymentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::DeploymentsClientBuilder builder = new gcdcv::DeploymentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::EntityTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntityTypesClient(this IServiceCollection services, sys::Action<gcdcv::EntityTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::EntityTypesClientBuilder builder = new gcdcv::EntityTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::EntityTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntityTypesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::EntityTypesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::EntityTypesClientBuilder builder = new gcdcv::EntityTypesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::EnvironmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEnvironmentsClient(this IServiceCollection services, sys::Action<gcdcv::EnvironmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::EnvironmentsClientBuilder builder = new gcdcv::EnvironmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::EnvironmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEnvironmentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::EnvironmentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::EnvironmentsClientBuilder builder = new gcdcv::EnvironmentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::ExperimentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddExperimentsClient(this IServiceCollection services, sys::Action<gcdcv::ExperimentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::ExperimentsClientBuilder builder = new gcdcv::ExperimentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::ExperimentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddExperimentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::ExperimentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::ExperimentsClientBuilder builder = new gcdcv::ExperimentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::FlowsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFlowsClient(this IServiceCollection services, sys::Action<gcdcv::FlowsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::FlowsClientBuilder builder = new gcdcv::FlowsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::FlowsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFlowsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::FlowsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::FlowsClientBuilder builder = new gcdcv::FlowsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::GeneratorsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGeneratorsClient(this IServiceCollection services, sys::Action<gcdcv::GeneratorsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::GeneratorsClientBuilder builder = new gcdcv::GeneratorsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::GeneratorsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGeneratorsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::GeneratorsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::GeneratorsClientBuilder builder = new gcdcv::GeneratorsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::IntentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIntentsClient(this IServiceCollection services, sys::Action<gcdcv::IntentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::IntentsClientBuilder builder = new gcdcv::IntentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::IntentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIntentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::IntentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::IntentsClientBuilder builder = new gcdcv::IntentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::PagesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPagesClient(this IServiceCollection services, sys::Action<gcdcv::PagesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::PagesClientBuilder builder = new gcdcv::PagesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::PagesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPagesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::PagesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::PagesClientBuilder builder = new gcdcv::PagesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdcv::SecuritySettingsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSecuritySettingsServiceClient(this IServiceCollection services, sys::Action<gcdcv::SecuritySettingsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::SecuritySettingsServiceClientBuilder builder = new gcdcv::SecuritySettingsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdcv::SecuritySettingsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSecuritySettingsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::SecuritySettingsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::SecuritySettingsServiceClientBuilder builder = new gcdcv::SecuritySettingsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdcv::SessionEntityTypesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionEntityTypesClient(this IServiceCollection services, sys::Action<gcdcv::SessionEntityTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::SessionEntityTypesClientBuilder builder = new gcdcv::SessionEntityTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdcv::SessionEntityTypesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionEntityTypesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::SessionEntityTypesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::SessionEntityTypesClientBuilder builder = new gcdcv::SessionEntityTypesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::SessionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionsClient(this IServiceCollection services, sys::Action<gcdcv::SessionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::SessionsClientBuilder builder = new gcdcv::SessionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::SessionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::SessionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::SessionsClientBuilder builder = new gcdcv::SessionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::TestCasesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTestCasesClient(this IServiceCollection services, sys::Action<gcdcv::TestCasesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::TestCasesClientBuilder builder = new gcdcv::TestCasesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::TestCasesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTestCasesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::TestCasesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::TestCasesClientBuilder builder = new gcdcv::TestCasesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdcv::TransitionRouteGroupsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTransitionRouteGroupsClient(this IServiceCollection services, sys::Action<gcdcv::TransitionRouteGroupsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::TransitionRouteGroupsClientBuilder builder = new gcdcv::TransitionRouteGroupsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdcv::TransitionRouteGroupsClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTransitionRouteGroupsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::TransitionRouteGroupsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::TransitionRouteGroupsClientBuilder builder = new gcdcv::TransitionRouteGroupsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::VersionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVersionsClient(this IServiceCollection services, sys::Action<gcdcv::VersionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::VersionsClientBuilder builder = new gcdcv::VersionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::VersionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVersionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::VersionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::VersionsClientBuilder builder = new gcdcv::VersionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::WebhooksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWebhooksClient(this IServiceCollection services, sys::Action<gcdcv::WebhooksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdcv::WebhooksClientBuilder builder = new gcdcv::WebhooksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdcv::WebhooksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWebhooksClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdcv::WebhooksClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdcv::WebhooksClientBuilder builder = new gcdcv::WebhooksClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
