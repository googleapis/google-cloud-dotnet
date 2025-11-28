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
using gaav = Google.Ads.AdManager.V1;
using gaxgrpc = Google.Api.Gax.Grpc;
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
        /// <summary>Adds a singleton <see cref="gaav::AdBreakServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdBreakServiceClient(this IServiceCollection services, sys::Action<gaav::AdBreakServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::AdBreakServiceClientBuilder builder = new gaav::AdBreakServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::AdBreakServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdBreakServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::AdBreakServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::AdBreakServiceClientBuilder builder = new gaav::AdBreakServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::AdReviewCenterAdServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdReviewCenterAdServiceClient(this IServiceCollection services, sys::Action<gaav::AdReviewCenterAdServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::AdReviewCenterAdServiceClientBuilder builder = new gaav::AdReviewCenterAdServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::AdReviewCenterAdServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdReviewCenterAdServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::AdReviewCenterAdServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::AdReviewCenterAdServiceClientBuilder builder = new gaav::AdReviewCenterAdServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::AdUnitServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdUnitServiceClient(this IServiceCollection services, sys::Action<gaav::AdUnitServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::AdUnitServiceClientBuilder builder = new gaav::AdUnitServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::AdUnitServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAdUnitServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::AdUnitServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::AdUnitServiceClientBuilder builder = new gaav::AdUnitServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ApplicationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApplicationServiceClient(this IServiceCollection services, sys::Action<gaav::ApplicationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ApplicationServiceClientBuilder builder = new gaav::ApplicationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ApplicationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddApplicationServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ApplicationServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ApplicationServiceClientBuilder builder = new gaav::ApplicationServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::AudienceSegmentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAudienceSegmentServiceClient(this IServiceCollection services, sys::Action<gaav::AudienceSegmentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::AudienceSegmentServiceClientBuilder builder = new gaav::AudienceSegmentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::AudienceSegmentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAudienceSegmentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::AudienceSegmentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::AudienceSegmentServiceClientBuilder builder = new gaav::AudienceSegmentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::BandwidthGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBandwidthGroupServiceClient(this IServiceCollection services, sys::Action<gaav::BandwidthGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::BandwidthGroupServiceClientBuilder builder = new gaav::BandwidthGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::BandwidthGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBandwidthGroupServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::BandwidthGroupServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::BandwidthGroupServiceClientBuilder builder = new gaav::BandwidthGroupServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::BrowserLanguageServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBrowserLanguageServiceClient(this IServiceCollection services, sys::Action<gaav::BrowserLanguageServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::BrowserLanguageServiceClientBuilder builder = new gaav::BrowserLanguageServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::BrowserLanguageServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBrowserLanguageServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::BrowserLanguageServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::BrowserLanguageServiceClientBuilder builder = new gaav::BrowserLanguageServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::BrowserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBrowserServiceClient(this IServiceCollection services, sys::Action<gaav::BrowserServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::BrowserServiceClientBuilder builder = new gaav::BrowserServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::BrowserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBrowserServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::BrowserServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::BrowserServiceClientBuilder builder = new gaav::BrowserServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CmsMetadataKeyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmsMetadataKeyServiceClient(this IServiceCollection services, sys::Action<gaav::CmsMetadataKeyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CmsMetadataKeyServiceClientBuilder builder = new gaav::CmsMetadataKeyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CmsMetadataKeyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmsMetadataKeyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CmsMetadataKeyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CmsMetadataKeyServiceClientBuilder builder = new gaav::CmsMetadataKeyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CmsMetadataValueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmsMetadataValueServiceClient(this IServiceCollection services, sys::Action<gaav::CmsMetadataValueServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CmsMetadataValueServiceClientBuilder builder = new gaav::CmsMetadataValueServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CmsMetadataValueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCmsMetadataValueServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CmsMetadataValueServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CmsMetadataValueServiceClientBuilder builder = new gaav::CmsMetadataValueServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::CompanyServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompanyServiceClient(this IServiceCollection services, sys::Action<gaav::CompanyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CompanyServiceClientBuilder builder = new gaav::CompanyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::CompanyServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompanyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CompanyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CompanyServiceClientBuilder builder = new gaav::CompanyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ContactServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContactServiceClient(this IServiceCollection services, sys::Action<gaav::ContactServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ContactServiceClientBuilder builder = new gaav::ContactServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ContactServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContactServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ContactServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ContactServiceClientBuilder builder = new gaav::ContactServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ContentBundleServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentBundleServiceClient(this IServiceCollection services, sys::Action<gaav::ContentBundleServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ContentBundleServiceClientBuilder builder = new gaav::ContentBundleServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ContentBundleServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentBundleServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ContentBundleServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ContentBundleServiceClientBuilder builder = new gaav::ContentBundleServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ContentLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentLabelServiceClient(this IServiceCollection services, sys::Action<gaav::ContentLabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ContentLabelServiceClientBuilder builder = new gaav::ContentLabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ContentLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentLabelServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ContentLabelServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ContentLabelServiceClientBuilder builder = new gaav::ContentLabelServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ContentServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentServiceClient(this IServiceCollection services, sys::Action<gaav::ContentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ContentServiceClientBuilder builder = new gaav::ContentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ContentServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddContentServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ContentServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ContentServiceClientBuilder builder = new gaav::ContentServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CreativeTemplateServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCreativeTemplateServiceClient(this IServiceCollection services, sys::Action<gaav::CreativeTemplateServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CreativeTemplateServiceClientBuilder builder = new gaav::CreativeTemplateServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CreativeTemplateServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCreativeTemplateServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CreativeTemplateServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CreativeTemplateServiceClientBuilder builder = new gaav::CreativeTemplateServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomFieldServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomFieldServiceClient(this IServiceCollection services, sys::Action<gaav::CustomFieldServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomFieldServiceClientBuilder builder = new gaav::CustomFieldServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomFieldServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomFieldServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CustomFieldServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomFieldServiceClientBuilder builder = new gaav::CustomFieldServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingKeyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingKeyServiceClient(this IServiceCollection services, sys::Action<gaav::CustomTargetingKeyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingKeyServiceClientBuilder builder = new gaav::CustomTargetingKeyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingKeyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingKeyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CustomTargetingKeyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingKeyServiceClientBuilder builder = new gaav::CustomTargetingKeyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingValueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingValueServiceClient(this IServiceCollection services, sys::Action<gaav::CustomTargetingValueServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingValueServiceClientBuilder builder = new gaav::CustomTargetingValueServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::CustomTargetingValueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCustomTargetingValueServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::CustomTargetingValueServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::CustomTargetingValueServiceClientBuilder builder = new gaav::CustomTargetingValueServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::DeviceCapabilityServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeviceCapabilityServiceClient(this IServiceCollection services, sys::Action<gaav::DeviceCapabilityServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::DeviceCapabilityServiceClientBuilder builder = new gaav::DeviceCapabilityServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::DeviceCapabilityServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeviceCapabilityServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::DeviceCapabilityServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::DeviceCapabilityServiceClientBuilder builder = new gaav::DeviceCapabilityServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::DeviceCategoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeviceCategoryServiceClient(this IServiceCollection services, sys::Action<gaav::DeviceCategoryServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::DeviceCategoryServiceClientBuilder builder = new gaav::DeviceCategoryServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::DeviceCategoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeviceCategoryServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::DeviceCategoryServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::DeviceCategoryServiceClientBuilder builder = new gaav::DeviceCategoryServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::DeviceManufacturerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeviceManufacturerServiceClient(this IServiceCollection services, sys::Action<gaav::DeviceManufacturerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::DeviceManufacturerServiceClientBuilder builder = new gaav::DeviceManufacturerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::DeviceManufacturerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDeviceManufacturerServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::DeviceManufacturerServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::DeviceManufacturerServiceClientBuilder builder = new gaav::DeviceManufacturerServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::EntitySignalsMappingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntitySignalsMappingServiceClient(this IServiceCollection services, sys::Action<gaav::EntitySignalsMappingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::EntitySignalsMappingServiceClientBuilder builder = new gaav::EntitySignalsMappingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::EntitySignalsMappingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEntitySignalsMappingServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::EntitySignalsMappingServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::EntitySignalsMappingServiceClientBuilder builder = new gaav::EntitySignalsMappingServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::GeoTargetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGeoTargetServiceClient(this IServiceCollection services, sys::Action<gaav::GeoTargetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::GeoTargetServiceClientBuilder builder = new gaav::GeoTargetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::GeoTargetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGeoTargetServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::GeoTargetServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::GeoTargetServiceClientBuilder builder = new gaav::GeoTargetServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::MobileCarrierServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMobileCarrierServiceClient(this IServiceCollection services, sys::Action<gaav::MobileCarrierServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::MobileCarrierServiceClientBuilder builder = new gaav::MobileCarrierServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::MobileCarrierServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMobileCarrierServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::MobileCarrierServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::MobileCarrierServiceClientBuilder builder = new gaav::MobileCarrierServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::MobileDeviceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMobileDeviceServiceClient(this IServiceCollection services, sys::Action<gaav::MobileDeviceServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::MobileDeviceServiceClientBuilder builder = new gaav::MobileDeviceServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::MobileDeviceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMobileDeviceServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::MobileDeviceServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::MobileDeviceServiceClientBuilder builder = new gaav::MobileDeviceServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::MobileDeviceSubmodelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMobileDeviceSubmodelServiceClient(this IServiceCollection services, sys::Action<gaav::MobileDeviceSubmodelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::MobileDeviceSubmodelServiceClientBuilder builder = new gaav::MobileDeviceSubmodelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::MobileDeviceSubmodelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddMobileDeviceSubmodelServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::MobileDeviceSubmodelServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::MobileDeviceSubmodelServiceClientBuilder builder = new gaav::MobileDeviceSubmodelServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::NetworkServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkServiceClient(this IServiceCollection services, sys::Action<gaav::NetworkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::NetworkServiceClientBuilder builder = new gaav::NetworkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::NetworkServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddNetworkServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::NetworkServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::NetworkServiceClientBuilder builder = new gaav::NetworkServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::OperatingSystemServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOperatingSystemServiceClient(this IServiceCollection services, sys::Action<gaav::OperatingSystemServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::OperatingSystemServiceClientBuilder builder = new gaav::OperatingSystemServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::OperatingSystemServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOperatingSystemServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::OperatingSystemServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::OperatingSystemServiceClientBuilder builder = new gaav::OperatingSystemServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::OperatingSystemVersionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOperatingSystemVersionServiceClient(this IServiceCollection services, sys::Action<gaav::OperatingSystemVersionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::OperatingSystemVersionServiceClientBuilder builder = new gaav::OperatingSystemVersionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::OperatingSystemVersionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOperatingSystemVersionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::OperatingSystemVersionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::OperatingSystemVersionServiceClientBuilder builder = new gaav::OperatingSystemVersionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::OrderServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrderServiceClient(this IServiceCollection services, sys::Action<gaav::OrderServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::OrderServiceClientBuilder builder = new gaav::OrderServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::OrderServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOrderServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::OrderServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::OrderServiceClientBuilder builder = new gaav::OrderServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PlacementServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPlacementServiceClient(this IServiceCollection services, sys::Action<gaav::PlacementServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::PlacementServiceClientBuilder builder = new gaav::PlacementServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PlacementServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPlacementServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::PlacementServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::PlacementServiceClientBuilder builder = new gaav::PlacementServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PrivateAuctionDealServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPrivateAuctionDealServiceClient(this IServiceCollection services, sys::Action<gaav::PrivateAuctionDealServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::PrivateAuctionDealServiceClientBuilder builder = new gaav::PrivateAuctionDealServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PrivateAuctionDealServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPrivateAuctionDealServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::PrivateAuctionDealServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::PrivateAuctionDealServiceClientBuilder builder = new gaav::PrivateAuctionDealServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PrivateAuctionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPrivateAuctionServiceClient(this IServiceCollection services, sys::Action<gaav::PrivateAuctionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::PrivateAuctionServiceClientBuilder builder = new gaav::PrivateAuctionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::PrivateAuctionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddPrivateAuctionServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::PrivateAuctionServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::PrivateAuctionServiceClientBuilder builder = new gaav::PrivateAuctionServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ProgrammaticBuyerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProgrammaticBuyerServiceClient(this IServiceCollection services, sys::Action<gaav::ProgrammaticBuyerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ProgrammaticBuyerServiceClientBuilder builder = new gaav::ProgrammaticBuyerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::ProgrammaticBuyerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProgrammaticBuyerServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ProgrammaticBuyerServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ProgrammaticBuyerServiceClientBuilder builder = new gaav::ProgrammaticBuyerServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ReportServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddReportServiceClient(this IServiceCollection services, sys::Action<gaav::ReportServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::ReportServiceClientBuilder builder = new gaav::ReportServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::ReportServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddReportServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::ReportServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::ReportServiceClientBuilder builder = new gaav::ReportServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::RoleServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRoleServiceClient(this IServiceCollection services, sys::Action<gaav::RoleServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::RoleServiceClientBuilder builder = new gaav::RoleServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::RoleServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRoleServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::RoleServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::RoleServiceClientBuilder builder = new gaav::RoleServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::SiteServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSiteServiceClient(this IServiceCollection services, sys::Action<gaav::SiteServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::SiteServiceClientBuilder builder = new gaav::SiteServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::SiteServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSiteServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::SiteServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::SiteServiceClientBuilder builder = new gaav::SiteServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::TaxonomyCategoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTaxonomyCategoryServiceClient(this IServiceCollection services, sys::Action<gaav::TaxonomyCategoryServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::TaxonomyCategoryServiceClientBuilder builder = new gaav::TaxonomyCategoryServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gaav::TaxonomyCategoryServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTaxonomyCategoryServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::TaxonomyCategoryServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::TaxonomyCategoryServiceClientBuilder builder = new gaav::TaxonomyCategoryServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::TeamServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTeamServiceClient(this IServiceCollection services, sys::Action<gaav::TeamServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::TeamServiceClientBuilder builder = new gaav::TeamServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::TeamServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTeamServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::TeamServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::TeamServiceClientBuilder builder = new gaav::TeamServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::UserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserServiceClient(this IServiceCollection services, sys::Action<gaav::UserServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gaav::UserServiceClientBuilder builder = new gaav::UserServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gaav::UserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gaav::UserServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gaav::UserServiceClientBuilder builder = new gaav::UserServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
