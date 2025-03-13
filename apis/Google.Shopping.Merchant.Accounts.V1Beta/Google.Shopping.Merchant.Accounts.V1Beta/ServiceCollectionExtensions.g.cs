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
using gsmav = Google.Shopping.Merchant.Accounts.V1Beta;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gsmav::AccountIssueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountIssueServiceClient(this IServiceCollection services, sys::Action<gsmav::AccountIssueServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::AccountIssueServiceClientBuilder builder = new gsmav::AccountIssueServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AccountIssueServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountIssueServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::AccountIssueServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::AccountIssueServiceClientBuilder builder = new gsmav::AccountIssueServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AccountTaxServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountTaxServiceClient(this IServiceCollection services, sys::Action<gsmav::AccountTaxServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::AccountTaxServiceClientBuilder builder = new gsmav::AccountTaxServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AccountTaxServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountTaxServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::AccountTaxServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::AccountTaxServiceClientBuilder builder = new gsmav::AccountTaxServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AccountsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountsServiceClient(this IServiceCollection services, sys::Action<gsmav::AccountsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::AccountsServiceClientBuilder builder = new gsmav::AccountsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AccountsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAccountsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::AccountsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::AccountsServiceClientBuilder builder = new gsmav::AccountsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AutofeedSettingsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutofeedSettingsServiceClient(this IServiceCollection services, sys::Action<gsmav::AutofeedSettingsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::AutofeedSettingsServiceClientBuilder builder = new gsmav::AutofeedSettingsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AutofeedSettingsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutofeedSettingsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::AutofeedSettingsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::AutofeedSettingsServiceClientBuilder builder = new gsmav::AutofeedSettingsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AutomaticImprovementsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutomaticImprovementsServiceClient(this IServiceCollection services, sys::Action<gsmav::AutomaticImprovementsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::AutomaticImprovementsServiceClientBuilder builder = new gsmav::AutomaticImprovementsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::AutomaticImprovementsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutomaticImprovementsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::AutomaticImprovementsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::AutomaticImprovementsServiceClientBuilder builder = new gsmav::AutomaticImprovementsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::BusinessIdentityServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBusinessIdentityServiceClient(this IServiceCollection services, sys::Action<gsmav::BusinessIdentityServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::BusinessIdentityServiceClientBuilder builder = new gsmav::BusinessIdentityServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::BusinessIdentityServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBusinessIdentityServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::BusinessIdentityServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::BusinessIdentityServiceClientBuilder builder = new gsmav::BusinessIdentityServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::BusinessInfoServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBusinessInfoServiceClient(this IServiceCollection services, sys::Action<gsmav::BusinessInfoServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::BusinessInfoServiceClientBuilder builder = new gsmav::BusinessInfoServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::BusinessInfoServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBusinessInfoServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::BusinessInfoServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::BusinessInfoServiceClientBuilder builder = new gsmav::BusinessInfoServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::EmailPreferencesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEmailPreferencesServiceClient(this IServiceCollection services, sys::Action<gsmav::EmailPreferencesServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::EmailPreferencesServiceClientBuilder builder = new gsmav::EmailPreferencesServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::EmailPreferencesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEmailPreferencesServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::EmailPreferencesServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::EmailPreferencesServiceClientBuilder builder = new gsmav::EmailPreferencesServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::HomepageServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHomepageServiceClient(this IServiceCollection services, sys::Action<gsmav::HomepageServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::HomepageServiceClientBuilder builder = new gsmav::HomepageServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::HomepageServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddHomepageServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::HomepageServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::HomepageServiceClientBuilder builder = new gsmav::HomepageServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::OnlineReturnPolicyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOnlineReturnPolicyServiceClient(this IServiceCollection services, sys::Action<gsmav::OnlineReturnPolicyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::OnlineReturnPolicyServiceClientBuilder builder = new gsmav::OnlineReturnPolicyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::OnlineReturnPolicyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddOnlineReturnPolicyServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::OnlineReturnPolicyServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::OnlineReturnPolicyServiceClientBuilder builder = new gsmav::OnlineReturnPolicyServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::ProgramsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProgramsServiceClient(this IServiceCollection services, sys::Action<gsmav::ProgramsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::ProgramsServiceClientBuilder builder = new gsmav::ProgramsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::ProgramsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddProgramsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::ProgramsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::ProgramsServiceClientBuilder builder = new gsmav::ProgramsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::RegionsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionsServiceClient(this IServiceCollection services, sys::Action<gsmav::RegionsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::RegionsServiceClientBuilder builder = new gsmav::RegionsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::RegionsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRegionsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::RegionsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::RegionsServiceClientBuilder builder = new gsmav::RegionsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::ShippingSettingsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddShippingSettingsServiceClient(this IServiceCollection services, sys::Action<gsmav::ShippingSettingsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::ShippingSettingsServiceClientBuilder builder = new gsmav::ShippingSettingsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::ShippingSettingsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddShippingSettingsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::ShippingSettingsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::ShippingSettingsServiceClientBuilder builder = new gsmav::ShippingSettingsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::TermsOfServiceAgreementStateServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTermsOfServiceAgreementStateServiceClient(this IServiceCollection services, sys::Action<gsmav::TermsOfServiceAgreementStateServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::TermsOfServiceAgreementStateServiceClientBuilder builder = new gsmav::TermsOfServiceAgreementStateServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::TermsOfServiceAgreementStateServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTermsOfServiceAgreementStateServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::TermsOfServiceAgreementStateServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::TermsOfServiceAgreementStateServiceClientBuilder builder = new gsmav::TermsOfServiceAgreementStateServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::TermsOfServiceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTermsOfServiceServiceClient(this IServiceCollection services, sys::Action<gsmav::TermsOfServiceServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::TermsOfServiceServiceClientBuilder builder = new gsmav::TermsOfServiceServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gsmav::TermsOfServiceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddTermsOfServiceServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::TermsOfServiceServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::TermsOfServiceServiceClientBuilder builder = new gsmav::TermsOfServiceServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gsmav::UserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserServiceClient(this IServiceCollection services, sys::Action<gsmav::UserServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gsmav::UserServiceClientBuilder builder = new gsmav::UserServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gsmav::UserServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gsmav::UserServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gsmav::UserServiceClientBuilder builder = new gsmav::UserServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
