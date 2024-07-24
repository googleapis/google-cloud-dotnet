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
using gcdv = Google.Cloud.Dataproc.V1;
using gciv = Google.Cloud.Iam.V1;
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
        /// Adds a singleton <see cref="gcdv::AutoscalingPolicyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutoscalingPolicyServiceClient(this IServiceCollection services, sys::Action<gcdv::AutoscalingPolicyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::AutoscalingPolicyServiceClientBuilder builder = new gcdv::AutoscalingPolicyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::AutoscalingPolicyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutoscalingPolicyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::AutoscalingPolicyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::AutoscalingPolicyServiceClientBuilder builder = new gcdv::AutoscalingPolicyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::BatchControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBatchControllerClient(this IServiceCollection services, sys::Action<gcdv::BatchControllerClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::BatchControllerClientBuilder builder = new gcdv::BatchControllerClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::BatchControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBatchControllerClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::BatchControllerClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::BatchControllerClientBuilder builder = new gcdv::BatchControllerClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::ClusterControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddClusterControllerClient(this IServiceCollection services, sys::Action<gcdv::ClusterControllerClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ClusterControllerClientBuilder builder = new gcdv::ClusterControllerClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::ClusterControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddClusterControllerClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::ClusterControllerClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::ClusterControllerClientBuilder builder = new gcdv::ClusterControllerClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::JobControllerClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobControllerClient(this IServiceCollection services, sys::Action<gcdv::JobControllerClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::JobControllerClientBuilder builder = new gcdv::JobControllerClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::JobControllerClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddJobControllerClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::JobControllerClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::JobControllerClientBuilder builder = new gcdv::JobControllerClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::NodeGroupControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNodeGroupControllerClient(this IServiceCollection services, sys::Action<gcdv::NodeGroupControllerClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::NodeGroupControllerClientBuilder builder = new gcdv::NodeGroupControllerClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::NodeGroupControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNodeGroupControllerClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::NodeGroupControllerClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::NodeGroupControllerClientBuilder builder = new gcdv::NodeGroupControllerClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SessionControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionControllerClient(this IServiceCollection services, sys::Action<gcdv::SessionControllerClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionControllerClientBuilder builder = new gcdv::SessionControllerClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SessionControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionControllerClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::SessionControllerClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionControllerClientBuilder builder = new gcdv::SessionControllerClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SessionTemplateControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionTemplateControllerClient(this IServiceCollection services, sys::Action<gcdv::SessionTemplateControllerClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionTemplateControllerClientBuilder builder = new gcdv::SessionTemplateControllerClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SessionTemplateControllerClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionTemplateControllerClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::SessionTemplateControllerClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionTemplateControllerClientBuilder builder = new gcdv::SessionTemplateControllerClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::WorkflowTemplateServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWorkflowTemplateServiceClient(this IServiceCollection services, sys::Action<gcdv::WorkflowTemplateServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::WorkflowTemplateServiceClientBuilder builder = new gcdv::WorkflowTemplateServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::WorkflowTemplateServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddWorkflowTemplateServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::WorkflowTemplateServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::WorkflowTemplateServiceClientBuilder builder = new gcdv::WorkflowTemplateServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
