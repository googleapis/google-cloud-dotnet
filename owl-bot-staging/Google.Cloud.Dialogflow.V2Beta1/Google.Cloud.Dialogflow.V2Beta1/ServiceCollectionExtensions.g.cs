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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
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
        /// <summary>Adds a singleton <see cref="gcdv::AgentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAgentsClient(this IServiceCollection services, sys::Action<gcdv::AgentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::AgentsClientBuilder builder = new gcdv::AgentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::AgentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAgentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::AgentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::AgentsClientBuilder builder = new gcdv::AgentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::AnswerRecordsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAnswerRecordsClient(this IServiceCollection services, sys::Action<gcdv::AnswerRecordsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::AnswerRecordsClientBuilder builder = new gcdv::AnswerRecordsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::AnswerRecordsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAnswerRecordsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::AnswerRecordsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::AnswerRecordsClientBuilder builder = new gcdv::AnswerRecordsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ContextsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContextsClient(this IServiceCollection services, sys::Action<gcdv::ContextsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ContextsClientBuilder builder = new gcdv::ContextsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ContextsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContextsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::ContextsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::ContextsClientBuilder builder = new gcdv::ContextsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::ConversationProfilesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConversationProfilesClient(this IServiceCollection services, sys::Action<gcdv::ConversationProfilesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ConversationProfilesClientBuilder builder = new gcdv::ConversationProfilesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::ConversationProfilesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConversationProfilesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::ConversationProfilesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::ConversationProfilesClientBuilder builder = new gcdv::ConversationProfilesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ConversationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConversationsClient(this IServiceCollection services, sys::Action<gcdv::ConversationsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ConversationsClientBuilder builder = new gcdv::ConversationsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ConversationsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConversationsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::ConversationsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::ConversationsClientBuilder builder = new gcdv::ConversationsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::DocumentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDocumentsClient(this IServiceCollection services, sys::Action<gcdv::DocumentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::DocumentsClientBuilder builder = new gcdv::DocumentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::DocumentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDocumentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::DocumentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::DocumentsClientBuilder builder = new gcdv::DocumentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::EncryptionSpecServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEncryptionSpecServiceClient(this IServiceCollection services, sys::Action<gcdv::EncryptionSpecServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::EncryptionSpecServiceClientBuilder builder = new gcdv::EncryptionSpecServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::EncryptionSpecServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEncryptionSpecServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::EncryptionSpecServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::EncryptionSpecServiceClientBuilder builder = new gcdv::EncryptionSpecServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::EntityTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntityTypesClient(this IServiceCollection services, sys::Action<gcdv::EntityTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::EntityTypesClientBuilder builder = new gcdv::EntityTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::EntityTypesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntityTypesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::EntityTypesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::EntityTypesClientBuilder builder = new gcdv::EntityTypesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::EnvironmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEnvironmentsClient(this IServiceCollection services, sys::Action<gcdv::EnvironmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::EnvironmentsClientBuilder builder = new gcdv::EnvironmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::EnvironmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEnvironmentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::EnvironmentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::EnvironmentsClientBuilder builder = new gcdv::EnvironmentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::FulfillmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFulfillmentsClient(this IServiceCollection services, sys::Action<gcdv::FulfillmentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::FulfillmentsClientBuilder builder = new gcdv::FulfillmentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::FulfillmentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddFulfillmentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::FulfillmentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::FulfillmentsClientBuilder builder = new gcdv::FulfillmentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::GeneratorsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGeneratorsClient(this IServiceCollection services, sys::Action<gcdv::GeneratorsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::GeneratorsClientBuilder builder = new gcdv::GeneratorsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::GeneratorsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGeneratorsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::GeneratorsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::GeneratorsClientBuilder builder = new gcdv::GeneratorsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::IntentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIntentsClient(this IServiceCollection services, sys::Action<gcdv::IntentsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::IntentsClientBuilder builder = new gcdv::IntentsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::IntentsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddIntentsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::IntentsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::IntentsClientBuilder builder = new gcdv::IntentsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::KnowledgeBasesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddKnowledgeBasesClient(this IServiceCollection services, sys::Action<gcdv::KnowledgeBasesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::KnowledgeBasesClientBuilder builder = new gcdv::KnowledgeBasesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::KnowledgeBasesClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddKnowledgeBasesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::KnowledgeBasesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::KnowledgeBasesClientBuilder builder = new gcdv::KnowledgeBasesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ParticipantsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddParticipantsClient(this IServiceCollection services, sys::Action<gcdv::ParticipantsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ParticipantsClientBuilder builder = new gcdv::ParticipantsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::ParticipantsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddParticipantsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::ParticipantsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::ParticipantsClientBuilder builder = new gcdv::ParticipantsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SessionEntityTypesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionEntityTypesClient(this IServiceCollection services, sys::Action<gcdv::SessionEntityTypesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionEntityTypesClientBuilder builder = new gcdv::SessionEntityTypesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SessionEntityTypesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionEntityTypesClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::SessionEntityTypesClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionEntityTypesClientBuilder builder = new gcdv::SessionEntityTypesClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::SessionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionsClient(this IServiceCollection services, sys::Action<gcdv::SessionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionsClientBuilder builder = new gcdv::SessionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::SessionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSessionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::SessionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::SessionsClientBuilder builder = new gcdv::SessionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::SipTrunksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSipTrunksClient(this IServiceCollection services, sys::Action<gcdv::SipTrunksClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SipTrunksClientBuilder builder = new gcdv::SipTrunksClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::SipTrunksClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSipTrunksClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::SipTrunksClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::SipTrunksClientBuilder builder = new gcdv::SipTrunksClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::VersionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVersionsClient(this IServiceCollection services, sys::Action<gcdv::VersionsClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::VersionsClientBuilder builder = new gcdv::VersionsClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::VersionsClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddVersionsClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcdv::VersionsClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcdv::VersionsClientBuilder builder = new gcdv::VersionsClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
