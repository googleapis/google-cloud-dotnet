// Copyright 2026 Google LLC
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
using gcsv = Google.Cloud.Sql.V1;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;
using sys = System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcsv::BlueGreenDeploymentsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBlueGreenDeploymentsServiceClient(this IServiceCollection services, sys::Action<gcsv::BlueGreenDeploymentsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::BlueGreenDeploymentsServiceClientBuilder builder = new gcsv::BlueGreenDeploymentsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::BlueGreenDeploymentsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddBlueGreenDeploymentsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::BlueGreenDeploymentsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::BlueGreenDeploymentsServiceClientBuilder builder = new gcsv::BlueGreenDeploymentsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlAvailableDatabaseVersionsServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlAvailableDatabaseVersionsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlAvailableDatabaseVersionsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlAvailableDatabaseVersionsServiceClientBuilder builder = new gcsv::SqlAvailableDatabaseVersionsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlAvailableDatabaseVersionsServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlAvailableDatabaseVersionsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlAvailableDatabaseVersionsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlAvailableDatabaseVersionsServiceClientBuilder builder = new gcsv::SqlAvailableDatabaseVersionsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlBackupRunsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlBackupRunsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlBackupRunsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlBackupRunsServiceClientBuilder builder = new gcsv::SqlBackupRunsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlBackupRunsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlBackupRunsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlBackupRunsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlBackupRunsServiceClientBuilder builder = new gcsv::SqlBackupRunsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlBackupsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlBackupsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlBackupsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlBackupsServiceClientBuilder builder = new gcsv::SqlBackupsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlBackupsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlBackupsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlBackupsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlBackupsServiceClientBuilder builder = new gcsv::SqlBackupsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlConnectServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlConnectServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlConnectServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlConnectServiceClientBuilder builder = new gcsv::SqlConnectServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlConnectServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlConnectServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlConnectServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlConnectServiceClientBuilder builder = new gcsv::SqlConnectServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlDatabasesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlDatabasesServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlDatabasesServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlDatabasesServiceClientBuilder builder = new gcsv::SqlDatabasesServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlDatabasesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlDatabasesServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlDatabasesServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlDatabasesServiceClientBuilder builder = new gcsv::SqlDatabasesServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlEventsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlEventsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlEventsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlEventsServiceClientBuilder builder = new gcsv::SqlEventsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlEventsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlEventsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlEventsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlEventsServiceClientBuilder builder = new gcsv::SqlEventsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlFeatureEligibilityServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlFeatureEligibilityServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlFeatureEligibilityServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlFeatureEligibilityServiceClientBuilder builder = new gcsv::SqlFeatureEligibilityServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlFeatureEligibilityServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlFeatureEligibilityServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlFeatureEligibilityServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlFeatureEligibilityServiceClientBuilder builder = new gcsv::SqlFeatureEligibilityServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlFlagsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlFlagsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlFlagsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlFlagsServiceClientBuilder builder = new gcsv::SqlFlagsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlFlagsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlFlagsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlFlagsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlFlagsServiceClientBuilder builder = new gcsv::SqlFlagsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlIamPoliciesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlIamPoliciesServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlIamPoliciesServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlIamPoliciesServiceClientBuilder builder = new gcsv::SqlIamPoliciesServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlIamPoliciesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlIamPoliciesServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlIamPoliciesServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlIamPoliciesServiceClientBuilder builder = new gcsv::SqlIamPoliciesServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlInstanceNamesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlInstanceNamesServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlInstanceNamesServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlInstanceNamesServiceClientBuilder builder = new gcsv::SqlInstanceNamesServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlInstanceNamesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlInstanceNamesServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlInstanceNamesServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlInstanceNamesServiceClientBuilder builder = new gcsv::SqlInstanceNamesServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlInstancesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlInstancesServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlInstancesServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlInstancesServiceClientBuilder builder = new gcsv::SqlInstancesServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlInstancesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlInstancesServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlInstancesServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlInstancesServiceClientBuilder builder = new gcsv::SqlInstancesServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlOperationsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlOperationsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlOperationsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlOperationsServiceClientBuilder builder = new gcsv::SqlOperationsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlOperationsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlOperationsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlOperationsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlOperationsServiceClientBuilder builder = new gcsv::SqlOperationsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlRegionsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlRegionsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlRegionsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlRegionsServiceClientBuilder builder = new gcsv::SqlRegionsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlRegionsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlRegionsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlRegionsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlRegionsServiceClientBuilder builder = new gcsv::SqlRegionsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlSslCertsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlSslCertsServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlSslCertsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlSslCertsServiceClientBuilder builder = new gcsv::SqlSslCertsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlSslCertsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlSslCertsServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlSslCertsServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlSslCertsServiceClientBuilder builder = new gcsv::SqlSslCertsServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlTiersServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlTiersServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlTiersServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlTiersServiceClientBuilder builder = new gcsv::SqlTiersServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlTiersServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlTiersServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlTiersServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlTiersServiceClientBuilder builder = new gcsv::SqlTiersServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlUsersServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlUsersServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlUsersServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlUsersServiceClientBuilder builder = new gcsv::SqlUsersServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlUsersServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlUsersServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlUsersServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlUsersServiceClientBuilder builder = new gcsv::SqlUsersServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlWorkloadCapturesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlWorkloadCapturesServiceClient(this IServiceCollection services, sys::Action<gcsv::SqlWorkloadCapturesServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlWorkloadCapturesServiceClientBuilder builder = new gcsv::SqlWorkloadCapturesServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcsv::SqlWorkloadCapturesServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSqlWorkloadCapturesServiceClient(this IServiceCollection services, sys::Action<sys::IServiceProvider, gcsv::SqlWorkloadCapturesServiceClientBuilder> action) =>
            services.AddSingleton(provider =>
            {
                gcsv::SqlWorkloadCapturesServiceClientBuilder builder = new gcsv::SqlWorkloadCapturesServiceClientBuilder();
                action?.Invoke(provider, builder);
                return builder.Build(provider);
            });
    }
}
